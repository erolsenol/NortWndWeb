using NorthwndWeb.Entities;
using System.Data.Entity;

namespace NorthwndWeb
{
    public class DataContext : DbContext 
    {
        public DataContext():base("NorthwndConStr")
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieType> MovieTypes { get; set; }
        public DbSet<MovieLanguage> MovieLanguage { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasRequired(m => m.MovieType).WithMany(mt => mt.Movies).HasForeignKey(m => m.FilmTipi);

            modelBuilder.Entity<Movie>().HasRequired(m1 => m1.MovieLanguage).WithMany(ml => ml.Movies).HasForeignKey(m => m.FilmDili);

            modelBuilder.Entity<Movie>().HasRequired(m2 => m2.Director).WithMany(m2 => m2.Movies).HasForeignKey(m => m.FilmYonetmen);

            modelBuilder.Entity<Comment>().HasRequired(m3 => m3.Movie).WithMany(m3 => m3.Comment).HasForeignKey(m => m.filmIdComment);
        }
        
       

    }
}