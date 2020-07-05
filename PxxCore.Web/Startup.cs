using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PxxCore.Repository.EFCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.Extensions.Hosting;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.OpenApi.Models;
using System;

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

            //设置连接字符串
            services.AddDbContext<DbContextBase>(options =>
                options.UseSqlServer(ConfigurationExtensions.GetConnectionString(configuration, "Pxx_Database"), b => b.MigrationsAssembly("PxxCore.Web")));

            //Mvc服务  在DotNet Core 3.0中可选择性添加Mvc的部分服务。如AddControllers(), 
            services.AddMvc();

            //services.AddMvcCore();  //稍微精简的mvc注册
            //services.AddControllers(); //适用于api的mvc部分服务注册
            //services.AddRazorPages();   //含有api和view的部分服务注册
            //services.AddControllersWithViews(); //razor服务注册

            #region Swagger Service
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("PxxCoreSwaggerV1", new OpenApiInfo
                {
                    Version = "V1.0",
                    Title = "PxxCore WepApi",
                    Description = "PxxCore.Swagger Doc",
                    Contact = new OpenApiContact { Name = "Pxx", Email = "pengxi1520@outlook.com", Url = new Uri("https://www.cnblogs.com/await-pxx/") }
                    //TermsOfService = "None"
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

                //c.OperationFilter<SecurityRequirementsOperationFilter>();
            });
            #endregion

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            app.UseRouting();   //路由中间件
            app.UseEndpoints(endPoints =>
            {
                endPoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseCookiePolicy();
        }
    }
}
