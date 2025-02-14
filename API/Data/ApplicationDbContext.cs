using Microsoft.EntityFrameworkCore;
using API.Entitys;
namespace API.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Productos> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Productos>().Property(product => product.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Productos>().HasIndex(product => product.Nombre).IsUnique();
        }
    }
}
