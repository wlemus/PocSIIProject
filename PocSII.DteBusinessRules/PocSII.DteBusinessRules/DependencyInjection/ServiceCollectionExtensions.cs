using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using PocSII.DteBusinessRules.Domain;
using PocSII.DteBusinessRules.Validation;

namespace PocSII.DteBusinessRules.DependencyInjection
{
   public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDteBusinessRules(this IServiceCollection services) {

            services.AddScoped<IValidator<Invoice>, InvoiceValidator>();
            services.AddScoped<ElectronicDocument, Invoice>();
            // services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<DocumentoValidator>());
            return services;
        }
    }
}
