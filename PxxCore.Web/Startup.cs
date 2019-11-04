using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PxxCore.Repository.EFCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Swashbuckle.AspNetCore.Swagger;

namespace PxxCore.Web
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //设置配置文件
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false).Build();

            //设置连接字符串 NoTracking
            services.AddDbContext<DbContextBase>(options =>
                options.UseSqlServer(ConfigurationExtensions.GetConnectionString(configuration, "Pxx_Database")));


            services.AddMvc();

            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("PxxCoreSwaggerV1", new Info
                {
                    Version = "V1.0",
                    Title = "PxxCore WepApi",
                    Description = "PxxCore.Swagger Doc",
                    Contact = new Contact { Name = "Pxx", Email = "pengxi1520@outlook.com", Url = "www.google.com" },
                    TermsOfService = "None"
                });

                //Swagger 读取xml注释，显示 接口注释
                var basePath = Directory.GetCurrentDirectory();

                //var basePath1 = AppDomain.CurrentDomain.BaseDirectory;

                //var basePath2 = Microsoft.DotNet.PlatformAbstractions.ApplicationEnvironment.ApplicationBasePath;

                var swaggerXmlPath = Path.Combine(basePath, "PxxCore.Web.Swagger.xml");
                c.IncludeXmlComments(swaggerXmlPath, true); //第二个参数是 Controller 的注释

                //Swagger 显示Model注释
                var swaggerModelXmlPath = Path.Combine(basePath, "PxxCore.Web.Entity.Swagger.xml");
                c.IncludeXmlComments(swaggerModelXmlPath);
            });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            #region IsDevelopment => ErrorPage
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                #region Use Swagger in Development
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    //PxxCoreSwaggerV1 需要和 ConfigureServices 中 SwaggerDoc的name相同，否则提示Not found json file problem
                    c.SwaggerEndpoint("/swagger/PxxCoreSwaggerV1/swagger.json", "PxxCoreSwagger V1");
                    c.RoutePrefix = "";
                });
                #endregion

            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            #endregion

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});

            app.UseMvc();

            app.UseCookiePolicy();
            
        }
    }
}
