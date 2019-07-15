using Code.RepositoryPattern.Model;
using Microsoft.EntityFrameworkCore;

namespace Code.RepositoryPattern.EntityFramework.Context
{
    public class ApplicationDatabaseContext : DbContext 
    {
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) :base(options)
        { }

        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}