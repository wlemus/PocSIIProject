using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using PocSII.DteBusinessRules.Dto;
using PocSII.DteBusinessRules.Interfaces;
using PocSII.DteBusinessRules.Validation;
using PocSII.DteProcessor.Services;

namespace PocSII.DteProcessor.DependencyInjection
{
   public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDteSender(this IServiceCollection services) {

           
            services.AddHttpClient<DteSenderService>();

            return services;
        }
    }
}
