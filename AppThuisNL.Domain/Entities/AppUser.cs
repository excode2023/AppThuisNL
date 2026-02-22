using AppThuisNL.Domain.Enums;

namespace AppThuisNL.Domain.Entities;

public class AppUsers
{
    public Guid Id { get; private set; }

    public string FirstName { get; private set; } = string.Empty;

    public string LastName { get; private set; } = string.Empty;

    public string Email { get; private set; } = string.Empty;

    public UserRole Role { get; private set; }

    public UserStatus Status { get; private set; }

    public DateTime CreatedAt { get; private set; }

    private AppUsers() { } // Required for EF later

    public AppUsers(string firstName, string lastName, string email, UserRole role)
    {
        Id = Guid.NewGuid();//genera un nuevo GUID para el usuario y lo asigna a la propiedad Id. que se guardará en la base de datos. 
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Role = role;
        Status = UserStatus.Pending;// Establece el estado inicial del usuario como "Pending" (pendiente) hasta que sea activado y lo establece en la propiedad Status. Esto permite controlar el flujo de activación del usuario en la aplicación.
        CreatedAt = DateTime.UtcNow;// establece la fecha y hora de creación del usuario utilizando la hora universal coordinada (UTC) para garantizar la consistencia en diferentes zonas horarias.
    }

    public void Activate()//
    {
        Status = UserStatus.Active;//
    }

    public void Suspend()
    {
        Status = UserStatus.Suspended;
    }
}
