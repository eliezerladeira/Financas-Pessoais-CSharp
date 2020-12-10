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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void transaçõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTransaction f = new frmTransaction();
            f.ShowDialog();
            f.Dispose();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory f = new frmCategory();
            f.ShowDialog();
            f.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPessoa f = new frmPessoa();
            f.ShowDialog();
            f.Dispose();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompra f = new frmCompra();
            f.ShowDialog();
            f.Dispose();
        }
    }
}