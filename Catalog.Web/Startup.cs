using System.Reflection;
using Catalog.DataAccess;
using Catalog.DataAccess.Repositories;
using Catalog.Service.Service;
using DemoLibrary;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Catalog.Web
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(builder =>
                builder.UseNpgsql(_configuration.GetConnectionString("CatalogDataBase")));
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
            services.AddMediatR(typeof(DemoLibraryMediatREntrypoint).Assembly);
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


            services.AddScoped<ISellerService,SellerService>();
            services.AddScoped<ISellerRepository,SellerRepository>();
            
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IProductRepository, ProductRepository>();
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
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}