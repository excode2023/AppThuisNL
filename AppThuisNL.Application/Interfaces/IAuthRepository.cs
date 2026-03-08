using AppThuisNL.Application.DTOs.Auth;

namespace AppThuisNL.Application.Interfaces;
public interface IAuthRepository
{
    Task<bool> RegisterUserAsync(RegisterUserDto dto);
     Task<AuthResponseDto?> LoginAsync(LoginUserDto dto);
}
