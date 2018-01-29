using Data;
using MediatR;
using BankingDomain.Data;
using MarketingDomain.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi
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
            services.AddDbContext<AppContext>(opt => opt.UseInMemoryDatabase("AppDatabase"));
            services.AddDbContext<BankingDbContext>(opt => opt.UseInMemoryDatabase("AppDatabase"));
            services.AddDbContext<MarketingDbContext>(opt => opt.UseInMemoryDatabase("AppDatabase"));
            services.AddMvc();
            services.AddMediatR(
                System.Reflection.Assembly.Load("MarketingDomain"),
                System.Reflection.Assembly.Load("BankingDomain")
                );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(
            IApplicationBuilder app, 
            IHostingEnvironment env, 
            AppContext appContext,
            BankingDbContext bankingDbContext,
            MarketingDbContext marketingDbContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            appContext.Seed().Wait();

            // Normally I shouldn't need these extra Seed methods
            // But somehow UseInMemoryDatabase won't let me share data across contexts
            bankingDbContext.Seed().Wait();
            marketingDbContext.Seed().Wait();
        }
    }
}
