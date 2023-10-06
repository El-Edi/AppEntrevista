using AppEntrevista.Datos.Interface;
namespace AppEntrevista.Datos
{
    public class RepositorioElementos : IRepositorioElementos
    {
        /// <summary>
        /// Metodo encargado de obtener los elementos almacenados para la escalada
        /// </summary>
        /// <returns>Listado de elementos almacenados</returns>
        public List<Elemento> ObtenerElementos()
        {
            var elementos = new List<Elemento>
            {
                new Elemento { Nombre = "E1", Peso = 5, Calorias = 3 },
                new Elemento { Nombre = "E2", Peso = 3, Calorias = 5 },
                new Elemento { Nombre = "E3", Peso = 5, Calorias = 2 },
                new Elemento { Nombre = "E4", Peso = 1, Calorias = 8 },
                new Elemento { Nombre = "E5", Peso = 2, Calorias = 3 }
            };
            return elementos;
        }
    }
}
