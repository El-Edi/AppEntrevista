using AppEntrevista.Datos;
namespace AppEntrevista.Negocio.Interface
{
    /// <summary>
    /// Esta interfaz define un contrato para clases que contienen la logica del negocio.
    /// </summary>
    internal interface IEscaladaRisco
    {
        /// <summary>
        /// Metodo encargado de encontrar la combinación optima de elementos requeridos para la escalada.
        /// </summary>
        /// <param name="elementos">Listado de elementos con el que se cuenta</param>
        /// <param name="caloriasMinimas">Número minimo de cálorias necesarias</param>
        /// <param name="pesoMaximo">Número maximo del peso</param>
        /// <returns>Listado de elementos optimos para la escalada</returns>
        List<Elemento> EncontrarCombinacionOptima(List<Elemento> elementos, int caloriasMinimas, int pesoMaximo);
        /// <summary>
        /// Metodo encargado de mostrar la combinación optima de elementos requeridos para la escalada por consola.
        /// </summary>
        /// <param name="combinacionOptima">Listado de elementos optimos a mostrar</param>
        void MostrarElementosOptimos(List<Elemento> combinacionOptima);
    }
}
