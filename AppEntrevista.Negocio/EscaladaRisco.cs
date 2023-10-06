using AppEntrevista.Datos;
using AppEntrevista.Negocio.Interface;

namespace AppEntrevista.Negocio
{
    public class EscaladaRisco : IEscaladaRisco
    {
        /// <summary>
        /// Metodo encargado de encontrar la combinación optima de elementos requeridos para la escalada.
        /// </summary>
        /// <param name="elementos">Listado de elementos con el que se cuenta</param>
        /// <param name="caloriasMinimas">Número minimo de cálorias necesarias</param>
        /// <param name="pesoMaximo">Número maximo del peso</param>
        /// <returns>Listado de elementos optimos para la escalada</returns>
        public List<Elemento> EncontrarCombinacionOptima(List<Elemento> elementos, int caloriasMinimas, int pesoMaximo)
        {
            try
            {
                List<Elemento> combinacionOptima = null;
                int mejorCalorias = 0;
                int menorPeso = int.MaxValue;

                int n = elementos.Count;
                for (int i = 1; i < (1 << n); i++)
                {
                    List<Elemento> combinacionActual = new List<Elemento>();
                    int pesoActual = 0;
                    int caloriasActual = 0;

                    for (int j = 0; j < n; j++)
                    {
                        if ((i & (1 << j)) != 0)
                        {
                            combinacionActual.Add(elementos[j]);
                            pesoActual += elementos[j].Peso;
                            caloriasActual += elementos[j].Calorias;
                        }
                    }

                    if (caloriasActual >= caloriasMinimas && pesoActual <= pesoMaximo)
                    {
                        if (caloriasActual > mejorCalorias || (caloriasActual == mejorCalorias && pesoActual < menorPeso))
                        {
                            combinacionOptima = combinacionActual;
                            mejorCalorias = caloriasActual;
                            menorPeso = pesoActual;
                        }
                    }
                }
                return combinacionOptima;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se ha producido una excepción al momento de encontrar la combinación optima solicitada: {ex.Message}");
                throw;
            }
            
        }
        /// <summary>
        /// Metodo encargado de mostrar la combinación optima de elementos requeridos para la escalada por consola.
        /// </summary>
        /// <param name="combinacionOptima">Listado de elementos optimos a mostrar</param>
        public void MostrarElementosOptimos(List<Elemento> combinacionOptima)
        {
            if(combinacionOptima== null)
            {
                Console.WriteLine("No contamos con Elementos optimos para escalar el risco");
            }
            else
            {
                Console.WriteLine("Elementos óptimos para escalar el risco:");

                foreach (var elemento in combinacionOptima)
                {
                    Console.WriteLine($"{elemento.Nombre} - Peso: {elemento.Peso}, Calorías: {elemento.Calorias}");
                }
            }
        }

    }
       
}
