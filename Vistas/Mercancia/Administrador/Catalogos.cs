using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionTiendaElProfe.Vistas.Administrador
{
    public partial class Catalogos : UserControl
    {
        private string nombre, precio, cantidad, nombreImagen;
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
            productos0 = new List<Producto>();
            productos1 = new List<Producto>();
            productos2 = new List<Producto>();
            productos3 = new List<Producto>();

            cargarProductos();
            SerializarProducto.guardar(productos0, secciones[0]);
            SerializarProducto.guardar(productos1, secciones[1]);
            SerializarProducto.guardar(productos2, secciones[2]);
            SerializarProducto.guardar(productos3, secciones[3]);
            //
            // cargarProductos();
            ////
            ///
            cargarEstantes();
            /*for (int i = 0; i < 10; i++)
            {
                ProductoVista pr = new ProductoVista();
                flowLayoutPanel1.Controls.Add(pr);
            }*/
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bCargar_Click(object sender, EventArgs e)
        {
            cargarEntradas();
            cargarProductos();
            if(nombreImagen != "")
            {
                
                switch(indiceCategoria) 
                {
                    case (int)Categoria.Aperitivos:
                        productos0.Add(CrearProducto.crear(nombre, precio, cantidad, nombreImagen));
                        SerializarProducto.guardar(productos0, "ProductosAperitivos.json");
                    break;
                    case (int)Categoria.Lacteos:
                        productos1.Add(CrearProducto.crear(nombre, precio, cantidad, nombreImagen));
                        SerializarProducto.guardar(productos1, "ProductosLacteos.json");
                        break;
                    case (int)Categoria.Enlatado:
                        productos2.Add(CrearProducto.crear(nombre, precio, cantidad, nombreImagen));
                        SerializarProducto.guardar(productos2, "ProductosEnlatados.json");
                        break;
                    case (int)Categoria.Otros:
                        productos3.Add(CrearProducto.crear(nombre, precio, cantidad, nombreImagen));
                        SerializarProducto.guardar(productos3, "ProductosOtros.json");
                        break;
                }
                
                cargarEstantes();
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

        private void button1_Click(object sender, EventArgs e)
        {
            nombreImagen=SeleccionarImagenYGuardar();
        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            indiceCategoria = comboCategoria.SelectedIndex;
        }
        
        public void cargarEstantes()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel2.Controls.Clear();
            flowLayoutPanel3.Controls.Clear();
            flowLayoutPanel4.Controls.Clear();
            try
            {
                foreach (var s in secciones)
                {
                    foreach (var item in DeserializarProducto.leer(s))
                    {
                        ProductoVista productoVista = new ProductoVista();

                        productoVista.nombreProducto.Text = item.nombre;
                        productoVista.precioProducto.Text = item.precio;
                        productoVista.stock.Text = item.cantidad;
                        productoVista.pictureProducto.Image = Image.FromFile(item.nombreIMG);
                        switch (i)
                        {
                            case 0:
                                flowLayoutPanel1.Controls.Add(productoVista);
                                break;
                            case 1:
                                flowLayoutPanel2.Controls.Add(productoVista);
                                break;
                            case 2:
                                flowLayoutPanel3.Controls.Add(productoVista);
                                break;
                            case 3:
                                flowLayoutPanel4.Controls.Add(productoVista);
                                break;
                        }
                        
                        //flowLayoutPanel1.Controls.Add(productoVista);
                        //productoVista.pictureProducto.Image = item.nombreIMG;
                    }
                    i++;
                }
            }
            catch(System.ArgumentNullException e)
            {

            }
            
        }
        public void cargarProductos()
        {
            var listaObtenida1 = DeserializarProducto.leer(secciones[0]);
            var listaObtenida2 = DeserializarProducto.leer(secciones[1]);
            var listaObtenida3 = DeserializarProducto.leer(secciones[2]);
            var listaObtenida4 = DeserializarProducto.leer(secciones[3]);

            productos0.Clear();
            productos1.Clear();
            productos2.Clear();
            productos3.Clear();

            if (listaObtenida1 != null)
            {
                foreach (var item in listaObtenida1)
                {
                    productos0.Add(item);
                }
            }
            if (listaObtenida2 != null)
            {
                foreach (var item in listaObtenida2)
                {
                    productos1.Add(item);
                }
            }
            if (listaObtenida3 != null)
            {
                foreach (var item in listaObtenida3)
                {
                    productos2.Add(item);
                }
            }
            if (listaObtenida4 != null)
            {
                foreach (var item in listaObtenida4)
                {
                    productos3.Add(item);
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
