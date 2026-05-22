using SimulacionTiendaElProfe.Vistas.Mercancia.Administrador;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SimulacionTiendaElProfe.controller;

namespace SimulacionTiendaElProfe.Vistas.Administrador
{
    public partial class Catalogo : UserControl
    {
        private Dictionary<int,string> categorias;

        private Dictionary<string, TabPage> tabPages;
        private Dictionary<string, FlowLayoutPanel> flowLayouts;
       
        private string nombre, precio, cantidad,nombreImagen,categoriaSeleccionada;
        private int indiceCategoria;
        
        public Catalogo()
        {
            InitializeComponent();

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
                ControladorProducto.addProducto(objetoProducto());
                
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
        //Crea un objeto del producto a almacenar
        public Producto objetoProducto()
        {
            Producto producto = new Producto();
            producto.nombre = nombre;
            producto.precio = precio;
            producto.cantidad = cantidad;
            producto.nombreIMG = nombreImagen;
            producto.idCategoria = indiceCategoria + "";

            return producto;
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
                //indiceCategoria = comboCategoria.SelectedIndex;
                categoriaSeleccionada = comboCategoria.SelectedItem.ToString();
                if (categoriaSeleccionada == "Agregar")
                {
                    CategoriaConfig categoriaConfig = new CategoriaConfig();
                    categoriaConfig.Show();
            
                    comboCategoria.SelectedIndex = -1;
                } 
                else
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
            using (var leer = ControladorProducto.obtenerCategorias())
            {
                while (leer.Read())
                {
                    categorias.Add(int.Parse(leer["idCategorias"].ToString()), leer["Nombre"].ToString());
                    //flowLayouts
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
        //Agrega los productos a los flowlayouts (Muestra los productos en la pantalla)
        public void cargarEstantes()
        {
            limpiarFlowsLayouts();

            var leer = ControladorProducto.obtenerProductos();
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
        public void limpiarFlowsLayouts()
        {
            foreach(var item in flowLayouts)
            {
                item.Value.Controls.Clear();
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


/* Algoritmo para gestionar el catálogo de productos 
         * 
         * --------Al iniciar el programa TapPage Default = 1
         * Descargar categorias de la DB (en un diccionario con su PK)
         * Actualizar el comboBox de categorias
         * Actualizar el TapPage con las categorias (se agrega un FlowLayoutPanel a cada TapPage)
         * 
         * --------Mostrar productos en la pantalla
         * Descargar productos de la DB (en un diccionario con su PK)
         * Limpiar los TapPage (limpiar pantalla)
         * Agregar los productos a la pantalla 
         * 
         * --------Agregar un nuevo producto
         * Cargar los datos del producto 
         * Crear un objeto del producto
         * Agregar el producto a la DB
         * Descargar productos de la DB (en un diccionario con su PK)
         * Limpiar los TapPage (limpiar pantalla)
         * Agregar los productos a la pantalla 
         * 
         * --------Eliminar un producto
         * Eliminar el producto de la DB
         * Descargar productos de la DB (en un diccionario con su PK)
         * Limpiar los TapPage (limpiar pantalla)
         * Agregar los productos a la pantalla 
         * 
         * --------Modificar un producto
         * Modificar los datos del objeto del producto correspondiente
         * Enviar una peticion de actualizacion a la DB con la PK del producto
         * Descargar productos de la DB (en un diccionario con su PK)
         * Limpiar los TapPage (limpiar pantalla)
         * Agregar los productos a la pantalla 
            */
