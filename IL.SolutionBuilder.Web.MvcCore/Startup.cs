using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using IL.SolutionBuilder.Business.Abstract;
using IL.SolutionBuilder.Business.Concrete;
using IL.SolutionBuilder.DataAccess.Abstract;
using IL.SolutionBuilder.DataAccess.Concrete.EntityFramework.Contexts;
using IL.SolutionBuilder.DataAccess.Concrete.EntityFramework.Dals;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;

namespace IL.SolutionBuilder.Web.MvcCore
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddScoped<ICommandService, CommandManager>();
            services.AddScoped<IFileCreateService, FileCreateManager>();

            services.AddScoped<ISolutionService, SolutionManager>();
            services.AddScoped<IUnitService, UnitManager>();
            services.AddScoped<IProjectService, ProjectManager>();

            services.AddScoped<ISolutionDal, EfSolutionDal<SolutionBuilderContext>>();
            services.AddScoped<IUnitDal, EfUnitDal<SolutionBuilderContext>>();
            services.AddScoped<IProjectDal, EfProjectDal<SolutionBuilderContext>>();



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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCookiePolicy();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                RequestPath = "/node_modules",
                FileProvider = new PhysicalFileProvider(Path.Combine(env.ContentRootPath, "node_modules"))
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Solution}/{action=Index}/{id?}");
            });
        }
    }
}
