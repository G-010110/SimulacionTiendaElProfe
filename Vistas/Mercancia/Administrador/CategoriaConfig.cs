using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimulacionTiendaElProfe.Conexiones;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;

namespace SimulacionTiendaElProfe.Vistas.Mercancia.Administrador
{
    public partial class CategoriaConfig : Form
    {
        private Conector conectar;
        private string query, categoria, categoriaBuffer;
        public static event Action cargarEstantes;
        
        public CategoriaConfig()
        {
            InitializeComponent();
            conectar = new ConectorSQLite();
            cargarCategorias();
        }
        //Metodo para agregar una categoria a la base de datos
        private void bAdd_Click(object sender, EventArgs e)
        {
            categoria = tbNombreAdd.Text;
            if (categoria != "")
                using (DbConnection conexion = conectar.crearConexion())
                {
                    conexion.Open();
                    query = "INSERT INTO Categorias (Nombre) values (@nombre);";
                    using (DbCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandText = query;

                        /*En MySql sería
                         comando.Parameters.AddWithValue("@nombre", categoria);
                        comando.ExecuteNonQuery()*/
                        DbParameter parametro = comando.CreateParameter();
                        parametro.ParameterName = "@nombre";
                        parametro.Value = categoria;
                        comando.Parameters.Add(parametro);

                        comando.ExecuteNonQuery();
                    }
                }
            else
                MessageBox.Show("Ingrese un nombre a la categoría","Error");
            tbNombreAdd.Text = "";
            cargarCategorias();
            cargarEstantes?.Invoke();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(categoriaBuffer != "")
                using(DbConnection conexion = conectar.crearConexion())
                {
                    conexion.Open();
                    query = "DELETE FROM Categorias WHERE Nombre = @nombre;";
                    using (DbCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandText = query;
                        DbParameter parametro = comando.CreateParameter();
                        parametro.ParameterName = "@nombre";
                        parametro.Value = categoriaBuffer;
                        comando.Parameters.Add(parametro);

                        comando.ExecuteNonQuery();
                    }
                }
            else
                MessageBox.Show("Seleccione una categoría para eliminar", "Error");
            cargarCategorias();
            cargarEstantes?.Invoke();
        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            if (tbNombreUpdate.Text != "")
                using (DbConnection conexion = conectar.crearConexion())
                {
                    query = "UPDATE Categorias SET Nombre=@nombreEnd WHERE Nombre=@nombreInit;";
                    conexion.Open();
                    using (DbCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandText = query;

                        DbParameter parametro1 = comando.CreateParameter();
                        parametro1.ParameterName = "@nombreEnd";
                        parametro1.Value = tbNombreUpdate.Text;
                        comando.Parameters.Add(parametro1);

                        DbParameter parametro2 = comando.CreateParameter();
                        parametro2.ParameterName = "@nombreInit";
                        parametro2.Value = categoriaBuffer;
                        comando.Parameters.Add(parametro2);

                        comando.ExecuteNonQuery();
                    }
                }
            else
                MessageBox.Show("Seleccione una categoria para editar, escriba un nombre valido", "Error");
            cargarCategorias();
            tbNombreUpdate.Text = "";
            cargarEstantes?.Invoke();
        }

        //Obtiene el nombre de la categoria seleccionada en el listbox y lo muestra en el textbox para actualizarlo
        private void listBoxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoriaBuffer = listBoxCategorias.SelectedItem.ToString();
            tbNombreUpdate.Text= categoriaBuffer;
        }

        //Metodo para cargar las categorias de la base de datos en el listbox
        public void cargarCategorias() 
        {
            listBoxCategorias.Items.Clear();
            using (DbConnection conexion = conectar.crearConexion())
            {
                conexion.Open();
                query = "SELECT Nombre FROM Categorias;";
                //SQLiteCommand comando = new SQLiteCommand(query,(SQliteConnection)conexion);
                DbCommand comando = conexion.CreateCommand();
                comando.CommandText = query;

                using (DbDataReader leer = comando.ExecuteReader())
                {
                    while(leer.Read())
                    {
                        categoria = leer.GetString(0);
                        listBoxCategorias.Items.Add(categoria);
                    }
                }
            }
        }
    }
}
