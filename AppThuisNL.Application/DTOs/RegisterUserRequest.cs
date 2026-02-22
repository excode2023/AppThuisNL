using AppThuisNL.Domain.Enums;

namespace AppThuisNL.Application.DTOs;

public class RegisterUserRequest
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public UserRole Role { get; set; }
}
