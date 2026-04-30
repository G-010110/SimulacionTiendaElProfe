using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace SimulacionTiendaElProfe
{
    internal class DeserializarProducto
    {
        public static List<Producto> leer(string nombreArchivo)
        {
            try
            {
                string datos = File.ReadAllText(RutasRelativas.rutaDatos + nombreArchivo);
                var Productos = JsonSerializer.Deserialize<List<Producto>>(datos);
                return Productos;
            }catch(Exception e)
            {
                Console.WriteLine("Error al leer el archivo: "  + e.Message);
            }
            return null;
        }
    }
}
