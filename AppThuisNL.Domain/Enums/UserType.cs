namespace AppThuisNL.Domain.Enums
{
    public enum UserType
    {
        /// Refugiado o solicitante de asilo.
        Refugee = 0,
        /// Vecino/local holandés que quiere ayudar.
        Local = 1,
        /// Proveedor de servicios (particular).
        Provider = 2,
        /// Empresa registrada.
        Company = 3
    }
}

   /// <summary>
    /// Tipo principal de usuario en AppThuisNL.
    /// Se usa para filtros rápidos y lógica de negocio.
    /// Se sincroniza automáticamente con el Role de Identity.
    /// </summary>