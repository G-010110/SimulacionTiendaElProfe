using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTiendaElProfe
{
    internal class CrearProducto
    {
        public static Producto crear(string nombre, string precio, string cantidad, string nombreImagen)
        {
                Producto producto = new Producto();
                producto.id = 1;
                producto.nombre = nombre;
                producto.precio = precio;
                producto.cantidad = cantidad;
                producto.nombreIMG = nombreImagen;
            return producto;
        }
    }
}
