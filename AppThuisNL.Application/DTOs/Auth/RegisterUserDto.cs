using System;

namespace AppThuisNL.Application.DTOs.Auth;
public class RegisterUserDto
{
    // email del usuario que usará para iniciar sesión
    public string Email { get; set; } = string.Empty;
    // contraseña que el usuario enviará al registrarse
    public string Password { get; set; } = string.Empty;
    // nombre del usuario
    public string FirstName { get; set; } = string.Empty;
    // apellido del usuario
    public string LastName { get; set; } = string.Empty;
}


