using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppThuisNL.Domain.Entities;   // ← ¡Importante!

namespace AppThuisNL.Infraestructura.Data
{
    public class AppThuisDbContext : IdentityDbContext<AppUsers, IdentityRole<Guid>, Guid>
    {
        public AppThuisDbContext(DbContextOptions<AppThuisDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapeo de enums como texto (mejor legibilidad en PostgreSQL)
            modelBuilder.Entity<AppUsers>()
                .Property(u => u.UserType)
                .HasConversion<string>();

            modelBuilder.Entity<AppUsers>()
                .Property(u => u.AccountStatus)
                .HasConversion<string>();

            // Índices para búsquedas rápidas (usaremos mucho en Fase 1)
            modelBuilder.Entity<AppUsers>()
                .HasIndex(u => u.UserType);

            modelBuilder.Entity<AppUsers>()
                .HasIndex(u => u.AccountStatus);
        }
    }
}
    /// <summary>
    /// Contexto principal de base de datos para AppThuisNL.
    /// Hereda de IdentityDbContext para tener todas las tablas de autenticación listas.
    /// Soporta PostgreSQL mediante Npgsql.
    /// </summary>