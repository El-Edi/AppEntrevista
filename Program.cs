using AppEntrevista.Datos;
using AppEntrevista.Negocio;
namespace EntrevistaApp
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Bienvenido al AppEntrevista de Escalada de Risco");
                Console.WriteLine("-----------------------------------------");

                Console.Write("Escribe el Mínimo de calorías: ");
                int minCalorias = int.Parse(Console.ReadLine());

                Console.Write("Escribe Peso máximo: ");
                int pesoMaximo = int.Parse(Console.ReadLine());

                if (minCalorias<0 || pesoMaximo<0)
                {
                    throw new ArgumentException("El valor ingresado no puede ser negativo");
                }

                EscaladaRisco escaladaRiscoService = new EscaladaRisco();
                RepositorioElementos repositorioElementos = new RepositorioElementos();

                List<Elemento> elementos = repositorioElementos.ObtenerElementos();
                List<Elemento> elementosOptimos = escaladaRiscoService.EncontrarCombinacionOptima(elementos, minCalorias, pesoMaximo);

                escaladaRiscoService.MostrarElementosOptimos(elementosOptimos);

                Console.WriteLine("\nPresione cualquier tecla para salir...");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debe ingresar números enteros válidos.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se ha producido una excepción al momento de ingresar los valores del peso máximo y calorias minimas: {ex.Message}");
            }
            
        }

    }

}
