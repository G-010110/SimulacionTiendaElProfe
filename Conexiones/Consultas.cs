using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTiendaElProfe.Conexiones
{
    internal class Consultas
    {
        private static Conector conecta = new ConectorSQLite();

        //Retorna registros de la DB a partir de una consulta
        public static DbDataReader consulta(string query)
        {
            DbConnection conexion = conecta.crearConexion();
            conexion.Open();

            DbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            DbDataReader leer = comando.ExecuteReader();
            return leer;
        }

        //Metodo para cargar un nuevo registro de producto
        public static void agregarProducto(Producto p)
        {
            DbConnection conexion = conecta.crearConexion();
            conexion.Open();
            string query = "INSERT INTO Productos (Nombre,Precio,Cantidad,Imagen,idCategorias) VALUES (@nombre,@precio,@cantidad,@imagen,@idCatego);";

            DbCommand comando = conexion.CreateCommand();
            comando.CommandText = query;

            comando.Parameters.AddRange(new DbParameter[]
            {
                new SQLiteParameter("@nombre", p.nombre),
                new SQLiteParameter("@precio",p.precio),
                new SQLiteParameter("@cantidad",p.cantidad),
                new SQLiteParameter("@imagen", p.nombreIMG),
                new SQLiteParameter("@idCatego", p.idCategoria)
            });

            comando.ExecuteNonQuery();
        }

    }
}
