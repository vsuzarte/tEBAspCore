using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using teb.AspNetCore.Data;
using teb.AspNetCore.Repository.Interfaces;
using teb.AspNetCore.Repository.Repositories;

namespace teb.AspNetCore
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
            //Adicionar o serviço do Entity passando meu Contexto
            services.AddDbContext<BarContext>(options => {

                //Uso o option para colocar alguams configurações, neste caso que vou usar Sql server
                //e também usa o Configuration que me da acesso ao app setings para pegar a string de conexão que eu coloquei la
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            
            });

            services.AddScoped(typeof(ICategoriaRepository), typeof(CategoriaRepository));
            services.AddScoped(typeof(IProdutoRepository), typeof(ProdutoRepository));

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

            if (env.IsProduction())
            {
                //Qualquer.
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
