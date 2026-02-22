using AppThuisNL.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppThuisNL.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
     public DbSet<AppUsers> Users => Set<AppUsers>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AppUsers>(entity =>
        {
            entity.HasKey(x => x.Id);

            entity.Property(x => x.FirstName)
                  .IsRequired()
                  .HasMaxLength(100);

            entity.Property(x => x.LastName)
                  .IsRequired()
                  .HasMaxLength(100);

            entity.Property(x => x.Email)
                  .IsRequired()
                  .HasMaxLength(200);

            entity.HasIndex(x => x.Email)
                  .IsUnique();
        });
    }

}
