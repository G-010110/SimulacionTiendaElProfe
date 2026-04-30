using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTiendaElProfe
{
    internal class AgregarProducto
    {
        private static List<Producto> productos;
        public static List<Producto> crearLista(Producto p)
        {
            productos = new List<Producto>();
            productos.Add(p);
            return productos;
        }
    }
}
