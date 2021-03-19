using Microsoft.EntityFrameworkCore;
using teb.AspNetCore.Models;

namespace teb.AspNetCore.Data
{
    //Herdar de DbContext
    public class BarContext : DbContext
    {
        public BarContext(DbContextOptions<BarContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }
    }
}
