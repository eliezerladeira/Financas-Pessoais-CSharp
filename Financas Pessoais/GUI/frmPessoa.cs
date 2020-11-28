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
    public partial class frmPessoa : Form
    {
        public frmPessoa()
        {
            InitializeComponent();
        }

        private void chkCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCliente.Checked)
            {
                chkFornecedor.Checked = false;
                chkAmbos.Checked = false;
            }
        }

        private void chkFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFornecedor.Checked)
            {
                chkCliente.Checked = false;
                chkAmbos.Checked = false;
            }
        }

        private void chkAmbos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAmbos.Checked)
            {
                chkCliente.Checked = false;
                chkFornecedor.Checked = false;
            }
        }
    }
}