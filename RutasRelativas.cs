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
        public static string rutaVarEntorno = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName,"Conexiones","Entorno.env");
        
        public static string rutaDataxx = Path.Combine(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName, "Datos");
        public static string rutaImagenes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Recursos\Imagenes");
    }
}