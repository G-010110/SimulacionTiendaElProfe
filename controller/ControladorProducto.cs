using SimulacionTiendaElProfe.Conexiones;
using System.Data.Common;

namespace SimulacionTiendaElProfe.controller
{
    internal class ControladorProducto
    {

        //Metodo para leer todos los registros de productos
        public static void addProducto(Producto producto)
        {
            Consultas.agregarProducto(producto);
        }

        public static DbDataReader obtenerProductos()
        {
            return Consultas.consulta("select p.idProductos,p.Nombre as NombreProductos,p.Precio,p.Cantidad,p.Imagen,p.idCategorias,Categorias.Nombre as NombreCategoria,Categorias.idCategorias from Productos p inner join Categorias ON p.idCategorias=Categorias.idCategorias;");
        }
        
        //-------------------Categorias
        public static DbDataReader obtenerCategorias()
        {
            return Consultas.consulta("SELECT idCategorias,Nombre FROM Categorias;");
        }
    }
}
