﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TechnoSale.Business.Abstract;
using TechnoSale.Business.Concrete;
using TechnoSale.DataAccess.Abstract;
using TechnoSale.DataAccess.Concrete.EntityFramework;

namespace TechnoSale.MvcWebUI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IUrunService, UrunManager>();
            services.AddScoped<IUrunDal, EfUrunDal>();
            services.AddScoped<IKampanyaService, KampanyaManager>();
            services.AddScoped<IKampanyaDal, EfKampanyaDal>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();
        }
    }
}
