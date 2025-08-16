using Microsoft.EntityFrameworkCore;

namespace plantas_peru.Models  
{
    public class PlantasContext : DbContext
    {
        public PlantasContext(DbContextOptions<PlantasContext> options) : base(options) { }

        public DbSet<Planta> Plantas { get; set; } // 👈 conecta con la tabla Plantas
    }
}
