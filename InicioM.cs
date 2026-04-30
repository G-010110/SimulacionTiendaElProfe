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
        public InicioM()
        {
            InitializeComponent();
            cargar();
        }
        public void cargar()
        {
            panel.Controls.Clear();
            Vistas.Administrador.Catalogos catalogos = new Vistas.Administrador.Catalogos();
            catalogos.Dock = DockStyle.Fill;
            panel.Controls.Add(catalogos);
        }
    }
}
