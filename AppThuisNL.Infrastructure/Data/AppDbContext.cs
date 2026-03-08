using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppThuisNL.Infrastructure.Identity;

namespace AppThuisNL.Infrastructure.Data
{
    // Contexto principal de la base de datos
    public class AppDbContext : IdentityDbContext<IdentityUserEntity>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           builder.Entity<IdentityUserEntity>(entity =>
        {
            entity.Property(x => x.FirstName)
                  .HasMaxLength(100);

            entity.Property(x => x.LastName)
                  .HasMaxLength(100);

            entity.Property(x => x.PrefeLanguage)
                  .HasMaxLength(10);
        });
        }
    }
}