using ITAssetTracker.Application.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace ITAssetTracker.Application
{
    public static class RegisterApplicationServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(configuration =>
            {
                configuration.AddProfile<MappingProfile>();
            });

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

            return services;
        }
    }
}
