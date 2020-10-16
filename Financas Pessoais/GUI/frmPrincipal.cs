using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void transaçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTransacao f = new frmTransacao();
            f.ShowDialog();
            f.Dispose();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategorias f = new frmCategorias();
            f.ShowDialog();
            f.Dispose();
        }
    }
}