using AppThuisNL.Application.DTOs.Auth;
using AppThuisNL.Application.Interfaces;

namespace AppThuisNL.Application.Services;

public class AuthService
{
    private readonly IAuthRepository _authRepository;
    public AuthService(IAuthRepository authRepository)
    {
        _authRepository = authRepository;
    }
    public async Task<bool> RegisterUserAsync(RegisterUserDto dto)
    {
        return await _authRepository.RegisterUserAsync(dto);
    }
    public async Task<AuthResponseDto?> LoginAsync(LoginUserDto dto)
    {
        return await _authRepository.LoginAsync(dto);
    }
}