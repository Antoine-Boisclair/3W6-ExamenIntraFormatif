using Halloween.Models;
using Microsoft.EntityFrameworkCore;


namespace Halloween.Data
{
    public class HalloweenContext: DbContext
    {
        public HalloweenContext(DbContextOptions<HalloweenContext> options)
            : base(options)
        {

        }

        public DbSet<Sorciere> Sorcieres { get; set; }
        public DbSet<Potion> Potions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //Générer des données de départ
            modelBuilder.GenerateData();
        }
    }
}
