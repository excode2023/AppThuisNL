
using AppThuisNL.Domain.Entities;

namespace AppThuisNL.Application.Interfaces.Persistence;

public interface IAppUserRepository
{
    Task AddAsync(AppUsers users);// 1. Crear un usuario nuevo
    Task<AppUsers?> GetByIdAsync(Guid id);// 2. Buscar un usuario por su ID (el Guid ese largo)
    Task<AppUsers?> GetByEmailAsync(string email);// 3. Buscar un usuario por su correo
    Task UpdateAsync(AppUsers user);// 4. Actualizar datos de un usuario que ya existe
    Task<bool> ExistsByEmailAsync(string email);// 5. Preguntar rápido: ¿ya existe alguien con este email?
}
