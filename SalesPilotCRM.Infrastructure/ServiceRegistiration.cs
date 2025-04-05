using Microsoft.Extensions.DependencyInjection;
using SalesPilotCRM.Application.Interfaces.Auth;
using SalesPilotCRM.Infrastructure.Hashing;
using SalesPilotCRM.Infrastructure.Security;
using SalesPilotCRM.Infrastructure.Services.Auth;

namespace SalesPilotCRM.Infrastructure
{
    public static class InfraServiceRegistiration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenService, TokenService>();

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IPasswordHasher, PasswordHasher>();


            return services;
        }
    }
}
