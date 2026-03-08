using AppThuisNL.Domain.Enums;

namespace AppThuisNL.Domain.Entities
{
    // Representa un usuario del sistema desde la perspectiva del negocio
    public class AppUser
    {
        // Identificador único del usuario
        public string Id { get; set; } = Guid.NewGuid().ToString();

        // Email principal del usuario
        public string Email { get; set; } = string.Empty;

        // Nombre visible en el perfil
        public string FirstName { get; set; } = string.Empty;

        // Apellido visible en el perfil
        public string LastName { get; set; } = string.Empty;

        // Idioma preferido del usuario (ej: "nl", "en", "ar")
        public string PreferredLanguage { get; set; } = "nl";

        // Indica si el usuario fue verificado manualmente por un administrador
        public bool IsVerified { get; set; } = false;

        // Estado actual del usuario dentro del sistema
        public UserStatus Status { get; set; } = UserStatus.Active;

        // Fecha de creación del usuario en el sistema (UTC)
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}