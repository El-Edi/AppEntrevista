namespace AppEntrevista.Datos.Interface
{
    /// <summary>
    /// Esta interfaz define un contrato para clases que pueden contener datos del aplicativo.
    /// </summary>
    internal interface IRepositorioElementos
    {
        /// <summary>
        /// Metodo encargado de obtener los elementos almacenados para la escalada
        /// </summary>
        /// <returns>Listado de elementos almacenados</returns>
        List<Elemento> ObtenerElementos();
    }
}
