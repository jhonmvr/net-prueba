using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gestion_pistas_core.Models;
using gestion_pistas_core.repository;
using gestion_pistas_core.repository.imp;
using gestion_pistas_core.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace gestion_pistas_core
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            var mvc = services.AddMvc(options =>
            {
               
        })
        .AddJsonOptions(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.AddDbContext<pistasContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("PistasContext")));
            services.AddScoped<GestionPistasService>();
            services.AddTransient<IParametroRepository, ParametroRepository>();
          

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseCors(builder =>
            builder.WithOrigins("*")
                .AllowAnyHeader()
                .AllowAnyMethod());
            app.UseHttpsRedirection();
            app.UseMvc();

        }
    }
}
