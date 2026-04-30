using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionTiendaElProfe.Vistas.Usuario
{
    public partial class Catalogos : UserControl
    {
        public Catalogos()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                ProductoVista pr = new ProductoVista();
                flowLayoutPanel1.Controls.Add(pr);
            }
        }
    }
}
