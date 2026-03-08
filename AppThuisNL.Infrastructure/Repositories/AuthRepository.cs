using AppThuisNL.Application.DTOs.Auth;
using AppThuisNL.Application.Interfaces;
using AppThuisNL.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;


namespace AppThuisNL.Infrastructure.Repositories;

public class AuthRepository : IAuthRepository
{
    private readonly UserManager<IdentityUserEntity> _userManager;
    private readonly SignInManager<IdentityUserEntity> _signInManager;

    public AuthRepository(
        UserManager<IdentityUserEntity> userManager,
        SignInManager<IdentityUserEntity> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<bool> RegisterUserAsync(RegisterUserDto dto)
    {
        var user = new IdentityUserEntity
        {
            UserName = dto.Email,
            Email = dto.Email,
            FirstName = dto.FirstName,
            LastName = dto.LastName
        };

        var result = await _userManager.CreateAsync(user, dto.Password);

        return result.Succeeded;
    }

    public async Task<AuthResponseDto?> LoginAsync(LoginUserDto dto)
    {
        var user = await _userManager.FindByEmailAsync(dto.Email);

        if (user == null)
            return null;

        var result = await _signInManager.CheckPasswordSignInAsync(user, dto.Password, false);

        if (!result.Succeeded)
            return null;

        return new AuthResponseDto
        {
            Token = "TEMP_TOKEN",
            Expiration = DateTime.UtcNow.AddHours(1)
        };
    }
}