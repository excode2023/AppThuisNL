
namespace ThuisNL.Core.Domain;

public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public UserRole Role { get; set; } // Rol para matching: Refugiado, Local holandés, Voluntario, Admin
    public bool IsVerified { get; set; } = false;// Verificación identidad (pasaporte/DNI + selfie → badge azul)
    public DateTime? VerifiedAt { get; set; }
    public string PreferredLanguage { get; set; } = "nl"; // nl, en, ar, ti, etc.  // Preferencia idioma (para multilingüe brutal)
    public string City { get; set; } = string.Empty;// Ubicación aproximada para matching local (ciudad o código postal)
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Fecha creación (automático)
    public string? ProfilePictureUrl { get; set; } // Foto perfil (URL futura a Azure Blob o Cloudinary)
}

// Enum fuera de la clase (mismo archivo)
public enum UserRole
{
    Refugee = 0,
    Local = 1,
    Volunteer = 2,
    Admin = 99
}