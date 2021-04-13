using Loja.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Loja.Repository.Data
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasIndex(c => c.Id);

            modelBuilder.Entity<Client>().ToTable("clients");
            modelBuilder.Entity<Client>().Property(c => c.Id).HasColumnName("client_id");
            modelBuilder.Entity<Client>().Property(c => c.Name).HasColumnName("client_name").HasMaxLength(60);
            modelBuilder.Entity<Client>().Property(c => c.Cpf).HasColumnName("client_cpf").HasMaxLength(11);
            modelBuilder.Entity<Client>().HasIndex(c => c.Cpf).IsUnique();
            modelBuilder.Entity<Client>().Property(c => c.BirthDate).HasColumnName("client_birth_date").HasColumnType("date");
        }
    }
}