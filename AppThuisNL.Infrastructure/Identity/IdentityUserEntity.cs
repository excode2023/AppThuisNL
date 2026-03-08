
using Microsoft.AspNetCore.Identity;

namespace AppThuisNL.Infrastructure.Identity
{
    // Representa el usuario en el sistema de Identity (infraestructura)
    public class IdentityUserEntity : IdentityUser
    {
        // Nombre del usuario almacenado en Identity
        public string FirstName { get; set; } = string.Empty;

        // Apellido del usuario almacenado en Identity
        public string LastName { get; set; } = string.Empty;

        // Idioma preferido
        public string PrefeLanguage { get; set; } = "nl";

        // Indica si el usuario fue verificado
        public bool IsVerified { get; set; } = false;

        // Estado almacenado como entero (enum en dominio)
        public int Status { get; set; } = 1;

        // Fecha de creación
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
