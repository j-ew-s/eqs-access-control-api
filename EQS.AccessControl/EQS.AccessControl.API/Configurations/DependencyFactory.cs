using EQS.AccessControl.API.JWT;
using EQS.AccessControl.API.JWT.Interface;
using EQS.AccessControl.Application.Interfaces;
using EQS.AccessControl.Application.Services;
using EQS.AccessControl.Domain.Interfaces.Repository;
using EQS.AccessControl.Domain.Interfaces.Services;
using EQS.AccessControl.Domain.Services;
using EQS.AccessControl.Repository.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace EQS.AccessControl.API.Configurations
{
    public static class DependencyFactory
    {

        static DependencyFactory()
        {

        }

        public static IServiceCollection RegisterInstance(IServiceCollection services, KeyConfig keyConfig, JwtConfiguration tokenConfig)
        {
            Singleton(services, keyConfig, tokenConfig);
            Transient(services);
            return services;
        }

        private static IServiceCollection Singleton(IServiceCollection services, KeyConfig keyConfig, JwtConfiguration tokenConfig)
        {
            services.AddSingleton<IKeyConfig>(keyConfig);
            services.AddSingleton<IJwtConfiguration>(tokenConfig);
            return services;
        }

        private static IServiceCollection Transient(IServiceCollection services)
        {
            services.AddTransient<ILoginService, LoginService>();
            services.AddTransient<ILoginAppService, LoginAppService>();
            services.AddTransient<ILoginRepository, LoginRepository>();

            services.AddTransient<IRegisterService, RegisterService>();
            services.AddTransient<IRegisterAppService, RegisterAppService>();
            services.AddTransient<IRegisterRepository, RegisterRepository>();

            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IRoleAppService, RoleAppService>();
            services.AddTransient<IRoleRepository, RoleRepository>();

            services.AddTransient<ITokenGenerator, TokenGenerator>();
            return services;
        }
    }
}
