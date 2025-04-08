
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using PatronesTest.PubSub;
using PocSII.DteAPI.Common;
using PocSII.DteAPIApplicacion.Common;
using PocSII.DteAPIApplicacion.DTOs;
using PocSII.DteAPIApplicacion.Interfaces;
using PocSII.DteAPIApplicacion.Mappings;
using PocSII.DteAPIApplicacion.Services;
using PocSII.DteAPIApplicacion.Services.Interfaces;
using PocSII.DteAPIIDataAccess.Repositories;
using PocSII.DteAPIInfrastructure.Context;
using PocSII.DteAPIInfrastructure.Repositories;
using PocSII.DteBusinessRules.Dto;
using PocSII.DteBusinessRules.Interfaces;
using PocSII.DteComunicaciones;
using PocSII.DteProcessor.Services;
using System.Text;

namespace PocSII.DteAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllers();

            #region Dependences
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IDocumentService, InvoiceService>();
            builder.Services.AddScoped<DocumentServiceFactory>();
            builder.Services.AddHttpClient<DteSenderService>();
            builder.Services.AddHttpClient<DteQueryService>();
            builder.Services.AddScoped<IProcessDocumentService, ProcessDTEService>();

            builder.Services.AddScoped<ICompanyService, CompanyService>();
            builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
            builder.Services.AddScoped<IResolutionRepository, ResolutionRepository>();
            builder.Services.AddScoped<INonSQLRepository, DocumentoNonSQLRepository>();
            builder.Services.AddScoped<IDocumentNonSQLService<InvoiceFullDTO>, InvoiceNonSQLService>();


            #endregion

            #region "Publicador/suscriptor"


            // Forzar la inicialización del suscriptor para que se registre al evento
            builder.Services.AddSingleton<PublisherNotification>();

            builder.Services.AddSingleton<SubscriptorEmailNotification>(sp => {
                // Aquí nos aseguramos de que se suscriba al publicador
                var publisher = sp.GetRequiredService<PublisherNotification>();
                var subscriber = new SubscriptorEmailNotification("Notificación vía Correo electrónico");
                subscriber.Suscribe(publisher);
                return subscriber;
            });
            #endregion
            #region Database

            builder.Services.AddDbContext<PocSIIDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("PocSIIConnectionString")));

        #endregion
        //Configuración de la base de datos
     
            //Configuración de AppSettings
            #region AppSettings

        var appSettingsSection = builder.Configuration.GetSection("AppSettings");
            builder.Services.Configure<AppSettings>(appSettingsSection);
            #endregion

            //JWT Authentication
            #region JWT Authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);

            builder.Services.AddAuthentication(x => {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(x => { 
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(key),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

            #endregion



            // Configurar AutoMapper
            builder.Services.AddAutoMapper(typeof(MappingProfile), typeof(MappingProfile));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region "Email configuration"
            builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("SmtpSettings"));

            #endregion
            var app = builder.Build();

            using (var scope = app.Services.CreateScope()) {
                // Forzamos la resolución del suscriptor para que se registre al publisher
                var _ = scope.ServiceProvider.GetRequiredService<SubscriptorEmailNotification>();
            }

            #region Environment Variable
            var siiSettingsSection = builder.Configuration.GetSection("SiiSettings");
            var siiSettings = siiSettingsSection.Get<SiiSettings>();

            Environment.SetEnvironmentVariable("SII_ENDPOINT_ENVIO", siiSettings.SendEndpoint);
            Environment.SetEnvironmentVariable("SII_ENDPOINT_CONSULTA", siiSettings.GetEndpoint);
            #endregion
            //Log de errores
            #region logger
            builder.Services.AddLogging(loggingBuilder => {              
                loggingBuilder.AddConsole();
            });
            //Capturar excepciones no controladas
            app.UseExceptionHandler(errorApp =>
            {
                errorApp.Run(async context =>
                {
                    var exceptionHandlerPathFeature = context.Features.Get<IExceptionHandlerPathFeature>();
                    var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();

                    logger.LogError(exceptionHandlerPathFeature?.Error, "Excepció no controlada");

                    context.Response.StatusCode = 500;
                    context.Response.ContentType = "application/json";

                    await context.Response.WriteAsJsonAsync(new { error = "Ocurrió un error inesperado." });
                });
            });
            #endregion
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
