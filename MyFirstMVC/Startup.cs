using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVC
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseEndpoints(settings => {
                settings.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");
            });

            //app.Run(async x =>
            //{
            //   await x.Response.WriteAsync("hello world");
            //});

            //app.Run(async x =>
            //{
            //    await x.Response.WriteAsync("hello Namik");
            //});

            //app.Use(async (x, next) =>
            //{
            //   await x.Response.WriteAsync("Hello Async" + Environment.NewLine);
            //    await next.Invoke();
            //});


            //app.Use(async (x, next) =>
            //{
            //    await x.Response.WriteAsync("Hello Next async");
            //});
        }
    }
}
