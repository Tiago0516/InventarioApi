using InventarioApi.Models;
using Microsoft.EntityFrameworkCore;

namespace InventarioApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Inventario> Inventario { get; set; } = null!;
    }
}
