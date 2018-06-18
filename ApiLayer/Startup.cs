using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using DataLayer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer;

namespace ApiLayer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var builder = new ContainerBuilder();
            builder.Populate(services);
            // Register components for data layer
            builder.RegisterAssemblyTypes(typeof(IUserDataLayer).Assembly)
                .AsImplementedInterfaces();

            // Register components for service layer
            builder.RegisterAssemblyTypes(typeof(IUserServiceLayer).Assembly)
                .AsImplementedInterfaces();

            return new AutofacServiceProvider(builder.Build());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
