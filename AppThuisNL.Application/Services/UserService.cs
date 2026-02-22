using AppThuisNL.Application.DTOs;
using AppThuisNL.Application.Interfaces;
using AppThuisNL.Application.Interfaces.Persistence;
using AppThuisNL.Domain.Entities;

namespace AppThuisNL.Application.Services;

public class UserService : IUserService
{
    private readonly IAppUserRepository _userRepository;

    public UserService(IAppUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<AppUsers> RegisterAsync(RegisterUserRequest request)
    {
        // 1️⃣ Validar si el email ya existe
        var exists = await _userRepository.ExistsByEmailAsync(request.Email);

        if (exists)
            throw new Exception("Email already registered.");

        // 2️⃣ Crear entidad de dominio
        var user = new AppUsers(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Role
        );

        // 3️⃣ Guardar en repositorio
        await _userRepository.AddAsync(user);

        return user;
    }
}