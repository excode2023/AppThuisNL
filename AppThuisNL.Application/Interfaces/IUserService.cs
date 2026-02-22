using AppThuisNL.Application.DTOs;
using AppThuisNL.Domain.Entities;

namespace AppThuisNL.Application.Interfaces;

public interface IUserService
{
    Task<AppUsers> RegisterAsync(RegisterUserRequest request);
}