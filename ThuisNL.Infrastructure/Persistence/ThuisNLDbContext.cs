using Microsoft.EntityFrameworkCore;
using ThuisNL.Core.Domain;

namespace ThuisNL.Infrastructure.Persistence;

public class ThuisNLDbContext : DbContext  // <-- nombre clase cambiado
{
    public ThuisNLDbContext(DbContextOptions<ThuisNLDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users => Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(u => u.Id);

            entity.HasIndex(u => u.Email).IsUnique();

            entity.Property(u => u.FirstName)
                  .IsRequired()
                  .HasMaxLength(100);

            entity.Property(u => u.LastName)
                  .IsRequired()
                  .HasMaxLength(100);

            entity.Property(u => u.Email)
                  .IsRequired()
                  .HasMaxLength(200);

            entity.Property(u => u.PhoneNumber)
                  .HasMaxLength(20);

            entity.Property(u => u.Role)
                  .HasConversion<int>();

            entity.Property(u => u.City)
                  .HasMaxLength(100);

            entity.Property(u => u.PreferredLanguage)
                  .HasMaxLength(10)
                  .HasDefaultValue("nl");

            entity.ToTable("Users");
        });
    }
}