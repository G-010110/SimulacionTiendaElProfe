using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulacionTiendaElProfe.Vistas
{
    public partial class ProductoVista : UserControl
    {
        public ProductoVista()
        {
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1;
            }

        private void holaaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}