using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Mapping;
using ClassLibrary1;
using ClassLibrary1.Context;
using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IRepositories;
using ClassLibrary1.Interfaces.IServices;
using ClassLibrary1.Repositories;
using ClassLibrary1.Services;
using ClassLibrary1.UOW;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication
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
            services.AddControllersWithViews();
            services.AddAutoMapper(typeof(UserMap));

            services.AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationContext>();

            #region  repositories
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<ApplicationContext>();
            services.AddTransient<IProductTypeRepository, ProductTypeRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            #endregion

            #region  services

            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductTypeService, ProductTypeService>();
            services.AddTransient<IUserService, UserService>();

            #endregion

            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddRazorPages();

            services.AddServerSideBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();    
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
