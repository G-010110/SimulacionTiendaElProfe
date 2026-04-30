using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTiendaElProfe
{
    internal class RutasRelativas
    {
        public static string rutaDatos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Datos\");
        public static string rutaImagenes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Recursos\Imagenes");
    }
}