using Microsoft.AspNetCore.Identity;
using AppThuisNL.Domain.Enums;

namespace AppThuisNL.Domain.Entities
{
    public class AppUsers : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfilePictureUrl { get; set; } // URL de la foto de perfil (en fases posteriores se guardará en Azure Blob Storage).
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Fecha de creación del registro (UTC).
        public DateTime? UpdatedAt { get; set; }
        public string PreferredLanguage { get; set; } = "nl"; // Idioma preferido del usuario
        public string? ExternalVerificationId { get; set; } // Campo para expansión futura (ej. verificación DigiD, número de BSN, etc.).
        public UserType UserType { get; set; } = UserType.Refugee; // Tipo principal del usuario (para filtros y lógica de negocio)
        public AccountStatus AccountStatus { get; set; } = AccountStatus.Pending; // Estado actual de la cuenta (control de ciclo de vida).

        //  constructor: Como un método que toma variables y las asigna. basico, tipo "FirstName = firstName;"
        public AppUsers(string firstName, string lastName, string email, UserType userType)
        {
            FirstName = firstName; // Asigna var simple
            LastName = lastName;
            Email = email; // Setea la prop de Identity
            UserName = email; // Importante: Identity usa esto pa' login, lo ponemos = email
            UserType = userType; // Tu enum
            // Si quieres validar: if (string.IsNullOrEmpty(email)) throw new Exception("Email required"); – un if básico
        }
    }
}


  /// <summary>
    /// Entidad de usuario principal de AppThuisNL.
    /// Hereda de IdentityUser<Guid> para integrar completamente con ASP.NET Core Identity.
    /// Guid se usa como clave primaria (más seguro y compatible con PostgreSQL).
    /// </summary>
    /// 
        // Aquí puedes añadir más propiedades en el futuro sin romper nada.
        // Ejemplo de expansión: public ICollection<RefreshToken> RefreshTokens { get; set; } = new();