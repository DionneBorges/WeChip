using System.IO;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DB
{
    public class WeChipContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Oferta> Ofertas { get; set; }
        public DbSet<OfertaItem> OfertaItems { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Directory.GetCurrentDirectory();

            while (! Directory.Exists(Path.Combine(path, "DataBase")))
              path = Directory.GetParent(path).FullName;

            path = Path.Combine(path, "DataBase");

            string dbPath = Path.Combine(path, "WeChip.db3");

            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Oferta>().ToTable("Oferta");
            modelBuilder.Entity<OfertaItem>().ToTable("OfertaItem");
            modelBuilder.Entity<OfertaItem>().HasOne(o => o.Oferta).WithMany(b => b.OfertaItems).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Produto>().ToTable("Produto");
            modelBuilder.Entity<Status>().ToTable("Status");
        }
    }
}
