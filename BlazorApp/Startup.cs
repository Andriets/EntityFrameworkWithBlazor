using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorApp.Data;
using ClassLibrary1.Context;
using ClassLibrary1.Interfaces.IRepositories;
using ClassLibrary1.Repositories;
using ClassLibrary1.Interfaces.IServices;
using ClassLibrary1.Services;
using ClassLibrary1.Interfaces;
using ClassLibrary1.UOW;
using EFWebApiV3.Controllers;
using ClassLibrary1;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using Blazored.SessionStorage;
using BlazorApp.Validation;
using FluentValidation;

namespace BlazorApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddScoped<AuthenticationStateProvider, StateProvider>();
            services.AddBlazoredSessionStorage();

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
            services.AddValidatorsFromAssemblyContaining<RegisterViewModelValidator>();

            services.AddHttpClient<Services.ProductService>(client =>
            {
                client.BaseAddress = new Uri("http://localhost:5001");
            });

            services.AddHttpClient<Services.AccountService>(client =>
            {
                client.BaseAddress = new Uri("http://localhost:5001");
            });

            services.AddHttpClient<Services.ProductTypeService>(client =>
            {
                client.BaseAddress = new Uri("http://localhost:5001");
            });

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
                app.UseExceptionHandler("/Error");
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
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
