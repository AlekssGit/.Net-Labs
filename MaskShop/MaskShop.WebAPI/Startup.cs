using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MaskShop.BLL.Contracts;
using MaskShop.BLL.Implementation;
using MaskShop.DataAccess.Context;
using MaskShop.DataAccess.Contracts;
using MaskShop.DataAccess.Implementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace MaskShop.WebAPI
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddAutoMapper(typeof(Startup));

            //BLL
            services.Add(new ServiceDescriptor(typeof(IMaskCreateService), typeof(MaskCreateService), ServiceLifetime.Scoped));
            services.Add(new ServiceDescriptor(typeof(IMaskGetService), typeof(MaskGetService), ServiceLifetime.Scoped));
            services.Add(new ServiceDescriptor(typeof(IMaskUpdateService), typeof(MaskUpdateService), ServiceLifetime.Scoped));
            services.Add(new ServiceDescriptor(typeof(ICategoryGetService), typeof(CategoryGetService), ServiceLifetime.Scoped));

            //Data Access
            services.Add(new ServiceDescriptor(typeof(IMaskDataAccess), typeof(MaskDataAccess), ServiceLifetime.Scoped));
            services.Add(new ServiceDescriptor(typeof(ICategoryDataAccess), typeof(CategoryDataAccess), ServiceLifetime.Scoped));

            //DB contexts
            services.AddDbContext<MaskDirectoryContext>(options => options.UseSqlServer(this.Configuration.GetConnectionString("MaskDirectory")));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            //app.UseRouting();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller}/{action}/{id?}");
            });
            
        }
    }
}
