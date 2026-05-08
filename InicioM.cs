using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionTiendaElProfe
{
    public partial class InicioM : Form
    {
        public static event Action cerrar;
        public InicioM()
        {
            InitializeComponent();
            
        }
        public void cargar()
        {
            panel.Controls.Clear();
            Vistas.Administrador.Usuarios catalogos = new Vistas.Administrador.Usuarios();
            catalogos.Dock = DockStyle.Fill;
            panel.Controls.Add(catalogos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            Vistas.Administrador.Catalogos catalogos = new Vistas.Administrador.Catalogos();
            catalogos.Dock = DockStyle.Fill;
            panel.Controls.Add(catalogos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cerrar?.Invoke();
            this.Close();
        }
    }
}
