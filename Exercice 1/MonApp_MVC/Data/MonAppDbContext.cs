using Microsoft.EntityFrameworkCore;
using MonApp_MVC.Entities;

namespace MonApp_MVC.Data
{
    public class MonAppDbContext: DbContext
    {

      
      
        public MonAppDbContext(DbContextOptions<MonAppDbContext> options)
            : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
   
        }

        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<FicheOfficielle> FicheOfficielles { get; set; }
        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<Tournois> Tournois { get; set; }
    }
}
