using AutoMapper;
using EQS.AccessControl.API.Filters;
using EQS.AccessControl.Application.Interfaces;
using EQS.AccessControl.Application.Services;
using EQS.AccessControl.Domain.Interfaces.Repository;
using EQS.AccessControl.Domain.Interfaces.Services;
using EQS.AccessControl.Domain.Services;
using EQS.AccessControl.Repository.Context;
using EQS.AccessControl.Repository.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace EQS.AccessControl.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<EntityFrameworkContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("EQSDBCONNECTION")));

            services.AddTransient<ILoginService, LoginService>();
            services.AddTransient<ILoginAppService, LoginAppService>();
            services.AddTransient<ILoginRepository, LoginRepository>();

            services.AddTransient<IRegisterService, RegisterService>();
            services.AddTransient<IRegisterAppService, RegisterAppService>();
            services.AddTransient<IRegisterRepository, RegisterRepository>();

            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IRoleAppService, RoleAppService>();
            services.AddTransient<IRoleRepository, RoleRepository>();


            services.AddMvc(options =>{ options.Filters.Add(new ExceptionHandlingFilter()); });

            services.AddAutoMapper();

            services.AddMvc();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "EQS Access Control API", Version = "v1" });
                c.DescribeAllEnumsAsStrings();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "EQS Access Control API"); });
            app.UseMvc();
        }
    }
}
