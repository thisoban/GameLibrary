using ILogic;
using Logic;
using DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IDal;
using Back_End.IGDBService;

namespace Back_End
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
            //services.AddDbContext<MyContext>(Options => Options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection")));
            services.AddDbContext<MyContext>(options =>options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnection")));
            services.Configure<IGDBConfig>(Configuration.GetSection(nameof(IGDBConfig)));
            services.AddScoped<IMyContext, MyContext>();
            services.AddScoped<IUserLogic, UserLogic>();
            services.AddScoped<IUserDal, UserDal>();
          //  services.AddSingleton(new IGDBClient("dtyf1m6sh84pvfxpml37o5nv9ybapy", "veeb1lzntrosmmk0fzg93y90cn12xi"));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Back_End", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
               
            }
            app.UseSwagger();
           // app.UseSwaggerUI();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Back_End v1"));

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
