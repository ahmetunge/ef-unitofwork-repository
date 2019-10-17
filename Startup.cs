﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EfCoreTransactionTest.Api.Business;
using EfCoreTransactionTest.Api.DataAccess;
using EfCoreTransactionTest.Api.DataAccess.EntityFramework;
using EfCoreTransactionTest.Api.DataAccess.UnitOfWork;
using EfCoreTransactionTest.Api.DataAccess.UnitOfWork.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EfCoreTransactionTest.Api
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
            services.AddDbContext<EfMsSqlDbContext>(db => db.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection")));

            services.AddScoped<IArticleRepository, EfArticleRepository>();
            services.AddScoped<IArticleBusiness, ArticleBusiness>();
            services.AddScoped<IMsSqlUnitOfWork, EfMsSqlUnitOfWork>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
