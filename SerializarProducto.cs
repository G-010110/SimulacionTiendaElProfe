using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace SimulacionTiendaElProfe
{
    internal class SerializarProducto
    {
        private static string json;
        public static void guardar(List<Producto> lista, string nombreArchivo)
        {
            json = JsonSerializer.Serialize(lista);
            File.WriteAllText(RutasRelativas.rutaDatos+nombreArchivo,json);
        }
    }
}
