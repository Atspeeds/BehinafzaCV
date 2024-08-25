using _0_FrameWork.FW.Application;
using _0_FrameWork.FW.Infrastrure;
using AccountManagement.Infrastrure;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PersonalInformationManagement.Infrastrure.Bootstrapper;
using System;

namespace ServiceHost
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
          

            services.AddRazorPages();
            services.AddSession();
            var dbContext = Configuration.GetConnectionString("DbContext");

			services.AddSingleton<IAuthHelper, AuthHelper>();
            services.AddScoped<IResumeSession, ResumeSession>();

			AccountConfigBootstrapper.Configure(services, dbContext);
            PersonalInformationConfigBootstrapper.Configure(services, dbContext);

            #region Cookie
            services.AddHttpContextAccessor(); 

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LoginPath = "/Accounts/Signing";
                    options.LogoutPath = "/Accounts/Signing/Logout"; 
                    options.ExpireTimeSpan = TimeSpan.FromDays(30);
                });

         
            #endregion

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

            app.UseCookiePolicy();

            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
