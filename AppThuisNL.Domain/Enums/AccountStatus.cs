namespace AppThuisNL.Domain.Enums
{
    public enum AccountStatus
    {
        /// Cuenta creada, pendiente de verificación o aprobación manual.
        Pending = 0,
        /// Cuenta completamente activa.
        Active = 1,
        /// Cuenta temporalmente suspendida (puede reactivarse).
        Suspended = 2,
        /// Cuenta baneada permanentemente.
        Banned = 3,
        /// Cuenta eliminada (soft-delete, se mantiene registro).
        Deleted = 4
    }
}

    /// <summary>
    /// Estados posibles de una cuenta de usuario.
    /// Usado para controlar login, visibilidad y moderación.
    /// </summary>