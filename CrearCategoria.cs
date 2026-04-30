using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTiendaElProfe
{
    internal class CrearCategoria
    {
        public static void crear(string nombre, int id)
        {
            Categorias categoria = new Categorias
            {
                nombre = nombre,
                id = id
            };
        }
    }
}
