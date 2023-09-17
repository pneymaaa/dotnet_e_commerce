using dotnet_e_commerce.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_e_commerce.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(o => new 
            {
                o.ActorId,
                o.MovieId
            });

            modelBuilder.Entity<Actor_Movie>().HasOne(o => o.Movie).WithMany(o => o.Actors_Movies).HasForeignKey(o => o.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(o => o.Actor).WithMany(o => o.Actors_Movies).HasForeignKey(o => o.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Moives { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
    }
}