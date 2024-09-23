using Microsoft.EntityFrameworkCore;

namespace eTickets.Models
{
    public class AppDbContext:DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> Options):base(Options) 
        {
            
        }

        public AppDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Actor> Actors { get; set; }

        public virtual DbSet<Cinema> Cinemas { get; set; }

        public virtual DbSet<Producer> Producers { get; set; }

    }
}
