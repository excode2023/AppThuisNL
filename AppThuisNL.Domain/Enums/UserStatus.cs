namespace AppThuisNL.Domain.Enums
{
    // Representa el estado actual del usuario dentro del sistema
    public enum UserStatus
    {
        // Usuario activo y puede usar la plataforma normalmente
        Active = 1,
        // Usuario desactivado voluntariamente o por inactividad
        Inactive = 2,
        // Usuario suspendido temporalmente por incumplimiento de normas
        Suspended = 3,
        // Usuario bloqueado permanentemente
        Banned = 4
    }
}