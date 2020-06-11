using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using Exmination.Data;
using Exmination.Data.AdmitCardRepositry;
using Exmination.Data.CenterRepositry;
using Exmination.Data.EnrollRepositry;
using Exmination.Data.RegisterRepositry;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Rotativa.AspNetCore;

namespace Exmination
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            _configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private readonly IConfiguration _configuration;

        [Obsolete]
        //public void Configure(IApplicationBuilder app, IWebHostEnvironment env, Microsoft.AspNetCore.Hosting.IHostingEnvironment env2)

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            services.AddDbContextPool<ExaminationDBAccess>(entity => entity.UseSqlServer(_configuration.GetConnectionString("ExamDbConnection")));
            services.AddScoped<IRegisterRepositry, RegisterRepositry>();
            services.AddScoped<IEnrollRepositry,EnrollRepositry >();
            services.AddScoped<ICernterRepositry, CernterRepositry>();
            services.AddScoped<IAdmitCardRepositry, AdmitCardRepositry>();
            //services.AddControllers();
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(30);//You can set Time   
            });
            services.AddControllersWithViews();
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

            app.UseAuthorization();
            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
            //RotativaConfiguration.Setup(env);
            RotativaConfiguration.Setup(env.WebRootPath, "Rotativa");
        }
    }
}
