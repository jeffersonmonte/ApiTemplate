using ApiTemplate.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiTemplate.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<PagamentoEntity> Pagamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PagamentoEntity>()
                .HasKey(p => p.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
