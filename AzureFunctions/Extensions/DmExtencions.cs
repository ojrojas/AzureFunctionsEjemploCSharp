using Core.Interfaces;
using Core.Services;
using Infraestructure;
using Microsoft.Extensions.DependencyInjection;

namespace AzureFunctions.Extensions
{
    public static class ServicesExtensions
    {
        internal static IServiceCollection AddServiceExtensionDM(this IServiceCollection services)
        {
            /// <summary>
            /// Services 
            /// </summary>
            services.AddScoped(typeof(IAsyncRepository<>),typeof(GenericEfRepository<>));
            services.AddScoped<ITokenClaim, TokenClaim>();
            services.AddScoped<ILoginService,LoginService>();
            services.AddScoped<IActivityService, ActivityService>();
            services.AddScoped<IUserService, UserService>();


            return services;
        } 
    }
}