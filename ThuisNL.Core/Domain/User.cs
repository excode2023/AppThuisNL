namespace ThuisNL.Core.Domain;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public UserRole Role { get; set; }

    public bool IsVerified { get; set; } = false;

    public DateTime? VerifiedAt { get; set; }

    public string PreferredLanguage { get; set; } = "nl";

    public string City { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public string? ProfilePictureUrl { get; set; }
}

public enum UserRole
{
    Refugee = 0,
    Local = 1,
    Volunteer = 2,
    Admin = 99
}
