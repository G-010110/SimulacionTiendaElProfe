using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace SimulacionTiendaElProfe.Conexiones
{
    internal interface Conector
    {
        DbConnection crearConexion();
        DbDataReader leerProductos();
    }
}
