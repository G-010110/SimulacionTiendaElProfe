using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using DotNetEnv;
using System.IO;
using System.Data.Common;

namespace SimulacionTiendaElProfe.Conexiones
{
    internal class ConectorSQLite : Conector
    {
        private string variableEntorno, cadenaConexion;

        //Crea la conexion a SQLite
        public DbConnection crearConexion()
        {
            Env.Load(RutasRelativas.rutaVarEntorno);
            cargarAtributos();
            try
            {
                return ObtenerConexion();
            } catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse con la base de datos");
            }
            return null;
        }

        public void cargarAtributos()
        {
            variableEntorno = Path.Combine(RutasRelativas.rutaDataxx, Environment.GetEnvironmentVariable("N_DATABASE"));
            cadenaConexion = $"Data Source={variableEntorno}; Version=3;";
        }
        public SQLiteConnection ObtenerConexion()
        {
            return new SQLiteConnection(cadenaConexion);
        }

        public DbDataReader leerProductos()
        {
            using (DbConnection conexion = crearConexion())
            {
                conexion.Open();
                string query = "select p.idProductos,p.Nombre as NombreProductos,p.Precio,p.Cantidad,p.Imagen,p.idCategorias,Categorias.Nombre as NombreCategoria from Productos p inner join Categorias ON p.idCategorias=Categorias.idCategorias;";
                using (DbCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = query;
                    
                    return comando.ExecuteReader();
                }
            }
        }
        public DbDataReader obtenerConsultasSimples(string consulta)
        {
            using (DbConnection conexion = crearConexion())
            {
                conexion.Open();
                string query = consulta;
                using (DbCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = query;

                    return comando.ExecuteReader();
                }
            }
        }
    }
}
