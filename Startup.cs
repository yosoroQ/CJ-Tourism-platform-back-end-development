using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _01NET___CJ_ASP_Travel.Database;
using _01NET___CJ_ASP_Travel.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace _01NET___CJ_ASP_Travel
{
    public class Startup
    {

        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(setupAction =>
            {
                setupAction.ReturnHttpNotAcceptable = true;
            }).AddXmlDataContractSerializerFormatters();
            //ע�����ݲֿ�ķ�������
            //��������Add��������������ע��
            //services.AddSingleton
            //services.AddScoped
            services.AddTransient<ITouristRouteRepository, TouristRouteRepository>();

            /*            ���ݿ�ӳ��*/
            services.AddDbContext<AppDbContext>
                (options => {
                    options.UseSqlServer(Configuration["DbContext:ConnectionString"]);
                });

            // ɨ��profile�ļ�
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}