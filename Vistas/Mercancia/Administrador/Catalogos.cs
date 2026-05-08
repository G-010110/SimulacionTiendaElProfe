using SimulacionTiendaElProfe.Conexiones;
using SimulacionTiendaElProfe.Vistas.Mercancia.Administrador;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimulacionTiendaElProfe.Conexiones;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace SimulacionTiendaElProfe.Vistas.Administrador
{
    public partial class Catalogos : UserControl
    {
        private Conector conecta;
        private Dictionary<int,string> categorias;

        private Dictionary<string, TabPage> tabPages;
        private Dictionary<string, FlowLayoutPanel> flowLayouts;
       
        private string nombre, precio, cantidad,nombreImagen,query,categoriaSeleccionada;
        private int indiceCategoria;
        private string[] secciones = {
            "ProductosAperitivos.json",
            "ProductosLacteos.json",
            "ProductosEnlatados.json",
            "ProductosOtros.json" };
        int i = 0;
        private enum Categoria { Aperitivos=0, Lacteos=1, Enlatado = 2, Bebidas =45,  Carnes=5, FrutasVerduras=6, Congelados=7, HigienePersonal=8, LimpiezaHogar=9, Otros=3 };
        private List<Producto> productos0;
        private List<Producto> productos1;
        private List<Producto> productos2;
        private List<Producto> productos3;
        public Catalogos()
        {
            InitializeComponent();

            conecta = new ConectorSQLite();
            tabPages = new Dictionary<string, TabPage>();
            flowLayouts= new Dictionary<string, FlowLayoutPanel>();
            categorias = new Dictionary<int,string>();

            CategoriaConfig.cargarEstantes += limpiarCategorias;
            CategoriaConfig.cargarEstantes += mostrarCategorias;
            CategoriaConfig.cargarEstantes += cargarEstantes;

            limpiarCategorias();
            mostrarCategorias();
            cargarEstantes();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bCargar_Click(object sender, EventArgs e)
        {
            //cargarPasillos();
            cargarEntradas();
            
            if(nombreImagen != "")
            {
                agregarProductos();
                
                cargarEstantes();
                descargarEntradas();
            } else
            {
                MessageBox.Show("Debe seleccionar una imagen para el producto.");
            }
            nombreImagen = "";
        }
        public void cargarEntradas()
        {
            nombre = tNombre.Text;
            precio = tPrecio.Text;
            cantidad = tCantidad.Text;
        }
        public void descargarEntradas()
        {
            tNombre.Text ="";
            tPrecio.Text ="";
            tCantidad.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombreImagen=SeleccionarImagenYGuardar();
        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                indiceCategoria = comboCategoria.SelectedIndex;
                categoriaSeleccionada = comboCategoria.SelectedItem.ToString();
                if (categoriaSeleccionada == "Agregar")
                {

                    CategoriaConfig categoriaConfig = new CategoriaConfig();
                    categoriaConfig.Show();
            
                    comboCategoria.SelectedIndex = -1;

                } else
                {
                    foreach(var i in categorias)
                    {
                        if(i.Value == categoriaSeleccionada)
                        {
                            indiceCategoria = i.Key;
                        }
                    }
                }
            } catch(Exception ex)
            {

            }
        }
        
        public void mostrarCategorias()
        {
            descargarCategoriasDB();
            foreach (var i in  categorias)
            {
                cargarPasillos(i.Value);
                comboCategoria.Items.Add(i.Value);
            }
        }

        public void limpiarCategorias()
        {
            tabControl1.TabPages.Clear();
            flowLayouts.Clear();
        }
        //Carga Categorias con su PRIMARY KEY
        public void descargarCategoriasDB()
        {
            categorias.Clear();
            using (DbConnection conexion = conecta.crearConexion())
            {
                conexion.Open();
                query = "SELECT idCategorias,Nombre FROM Categorias;";
                //SQLiteCommand comando = new SQLiteCommand(query,(SQliteConnection)conexion);
                DbCommand comando = conexion.CreateCommand();
                comando.CommandText = query;

                using (DbDataReader leer = comando.ExecuteReader())
                {
                    while (leer.Read())
                    {
                        categorias.Add(int.Parse(leer["idCategorias"].ToString()), leer["Nombre"].ToString());
                        //flowLayouts
                    }
                }
            }
        }
        //Carga todas las categorias
        public void cargarPasillos(string nombre)
        { 
            tabControl1.TabPages.Add(pagina(nombre));
            
        }
        public TabPage pagina(string nombre)
        {
            
            TabPage tp = new TabPage();
            tp.Text= nombre;
            tp.AutoScroll = true;
            tp.Size = new Size(657, 314);
            tp.BackColor = SystemColors.Window;
            tp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);


            FlowLayoutPanel fl = new FlowLayoutPanel();
            fl.Dock = DockStyle.Fill;
            fl.AutoScroll = true;
            fl.Size = new Size(651, 308);
            //Diccionario de flows
            flowLayouts.Add(nombre, fl);
            tp.Controls.Add(flowLayouts[nombre]);
            return tp;
        }
        //agrega los productos a los flowlayouts
        public void cargarEstantes()
        {
            limpiarFlowsLayouts();
            using (DbConnection conexion = conecta.crearConexion())
            {
                conexion.Open();
                query = "select p.idProductos,p.Nombre as NombreProductos,p.Precio,p.Cantidad,p.Imagen,p.idCategorias,Categorias.Nombre as NombreCategoria,Categorias.idCategorias from Productos p inner join Categorias ON p.idCategorias=Categorias.idCategorias;";
                //SQLiteCommand comando = new SQLiteCommand(query,(SQliteConnection)conexion);
                DbCommand comando = conexion.CreateCommand();
                comando.CommandText = query;

                using (DbDataReader leer = comando.ExecuteReader())
                {
                    while (leer.Read())
                    {
                        //flowLayouts
                        ProductoVista productoVista = new ProductoVista();

                        productoVista.nombreProducto.Text = leer["NombreProductos"].ToString();
                        productoVista.precioProducto.Text = leer["Precio"].ToString();
                        productoVista.stock.Text = leer["Cantidad"].ToString();
                        productoVista.pictureProducto.Image = Image.FromFile(leer["Imagen"].ToString());

                        foreach (var item in categorias)
                        {

                            if (item.Value == leer["NombreCategoria"].ToString())
                            {
                                flowLayouts[item.Value].Controls.Add(productoVista);
                            }
                        }
                    }
                }
            }
        }
        public void limpiarFlowsLayouts()
        {
            foreach(var item in flowLayouts)
            {
                item.Value.Controls.Clear();
            }
        }
        public void agregarProductos()
        {
            using (DbConnection conexion = conecta.crearConexion())
            {
                conexion.Open();
                query = "INSERT INTO Productos (Nombre,Precio,Cantidad,Imagen,idCategorias) VALUES (@nombre,@precio,@cantidad,@imagen,@idCatego);";
                using (DbCommand comando = conexion.CreateCommand())
                {
                    comando.CommandText = query;

                    comando.Parameters.AddRange(new DbParameter[]
                    {
                        new SQLiteParameter("@nombre", nombre),
                        new SQLiteParameter("@precio",precio),
                        new SQLiteParameter("@cantidad",cantidad),
                        new SQLiteParameter("@imagen",nombreImagen),
                        new SQLiteParameter("@idCatego", indiceCategoria)
                    });
                
                    comando.ExecuteNonQuery();
                }
            }
        }

        public string SeleccionarImagenYGuardar()
        {
            OpenFileDialog ofd;
            try
            {
                ofd = this.openFileDialog1 ?? new OpenFileDialog();
            }
            catch
            {
                ofd = new OpenFileDialog();
            }

            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            ofd.Title = "Seleccione una imagen";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string sourcePath = ofd.FileName;
                string imagesFolder = RutasRelativas.rutaImagenes;
                if (!Directory.Exists(imagesFolder)) Directory.CreateDirectory(imagesFolder);

                string originalFileName = Path.GetFileName(sourcePath);
                string destFileName = originalFileName;
                string destPath = Path.Combine(imagesFolder, destFileName);

                int count = 1;
                while (File.Exists(destPath))
                {
                    destFileName = $"{Path.GetFileNameWithoutExtension(originalFileName)}_{count}{Path.GetExtension(originalFileName)}";
                    destPath = Path.Combine(imagesFolder, destFileName);
                    count++;
                }

                File.Copy(sourcePath, destPath);

                string relativePath = Path.Combine(RutasRelativas.rutaImagenes, destFileName);
                nombreImagen = relativePath;
                return relativePath;
            }

            return null;
        }
    }
}
