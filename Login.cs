using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimulacionTiendaElProfe.Conexiones;
using System.Data.Common;
using System.Data.SQLite;
using SimulacionTiendaElProfe;

namespace LoginMejorado
{
    public partial class Login : Form
    {
        List<Panel> historial = new List<Panel>();

        private Conector conectar = new ConectorSQLite();

        public Login()
        {
            InitializeComponent();
            InicioM.cerrar += mostrarLogin;
            //+= funciona como un comando de 'suscribir' cuando el evento RegresarLogin se dispara
            //tambien se ejecuta dicho evento
            //Inicio.RegresarLogin += accionRegresar;
            //CrearUser.RegresarToLogin += accionRegresar;
            //CrearUser.generarHistorial += pasarControles;
            //CrearUser.pasarNuevo += cambiarActividad;
            //CrearUser2.regresar += accionRegresar;
        }
        int contador = 1;
        private void bEntrar_Click(object sender, EventArgs e)
        {
            string alias = tbCorreo.Text?.Trim();
            string clave = tbPassword.Text?.Trim();

            if (string.IsNullOrEmpty(alias) || string.IsNullOrEmpty(clave))
            {
                MessageBox.Show("Por favor ingrese usuario y contraseña.");
                return;
            }

            using (DbConnection conexion = conectar.crearConexion())
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT * FROM Usuarios WHERE Alias = @alias AND Clave = @clave;";
                    using (DbCommand comando = conexion.CreateCommand())
                    {
                        comando.CommandText = query;
                        comando.Parameters.Add(new SQLiteParameter("@alias", alias));
                        comando.Parameters.Add(new SQLiteParameter("@clave", clave));

                        using (DbDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Usuario válido
                                MessageBox.Show("Bienvenido");
                                tbCorreo.Text = tbPassword.Text = "";
                                //pasarControles();
                               
                                // Navegar a formulario principal
                                InicioM inicio = new InicioM();
                                inicio.Show();
                                this.Visible = false;
                                return;
                            }
                            else
                            {
                                // Credenciales inválidas
                                MessageBox.Show("Usuario o contraseña incorrectos");
                                if (contador == 3)
                                {
                                    MessageBox.Show("Máximo intentos alcanzado");
                                    this.Close();
                                }
                                contador++;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con la base de datos. Contacte soporte.");
                }
            }
        }
        public void cambiarActividad(Form objeto)
        {
            panel1.Controls.Clear();
            objeto.Dock = DockStyle.Fill;
            objeto.TopLevel = false;
            panel1.Controls.Add(objeto);

            
            objeto.Show();
        }
        public void pasarControles()
        {
            historial.Add(new Panel());
            //panelHistoria = new Panel();
            while (panel1.Controls.Count > 0)
            {
                Control c = panel1.Controls[0];
                historial[historial.Count - 1].Controls.Add(c);
            }
        }
        public void accionRegresar()
        {
            panel1.Controls.Clear();
            historial[historial.Count-1].Dock = DockStyle.Fill;
            panel1.Controls.Add(historial[historial.Count-1]);
            //Elimina el ultimo elemento
            if(historial.Count != 1)
            {
                historial.RemoveAt(historial.Count - 1);
            }
        }

        private void linkLabelCrearUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Pasar todo el contenido de un panel a otro
            pasarControles();
            //cambiarActividad(new CrearUser());
        }
        public void mostrarLogin()
        {
            this.Visible = true;
        }
    }
}