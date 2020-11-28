using BLL;
using DAL;
using Modelo;
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
    public partial class frmCategory : Form
    {
        public String operacao;

        public frmCategory()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtSequencia.Clear();
            txtDescricao.Clear();
        }

        public void alteraBotoes(int op)
        {
            btnIncluir.Enabled = false;
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = false;

            if (op == 1)
            {
                btnIncluir.Enabled = true;
            }
            if (op == 2)
            {
                btnSalvar.Enabled = true;
                btnCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        public void alteraCampos(String op)
        {
            chkAtiva.Enabled = Convert.ToBoolean(op);
            txtDescricao.Enabled = Convert.ToBoolean(op);
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            this.operacao = "Inserir";
            this.alteraBotoes(2);
            this.alteraCampos("True");
            txtDescricao.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
            this.alteraCampos("False");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCategoria modelo = new ModeloCategoria();
                modelo.Descricao = txtDescricao.Text;
                modelo.Data = dtpData.Value;

                if (chkAtiva.Checked)
                    modelo.Ativa = "S";
                else
                    modelo.Ativa = "N";

                DALConexao cx = new DALConexao(DadosConexao.StringConexao);
                BLLCategoria bll = new BLLCategoria(cx);

                if (this.operacao == "Inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Categoria '" + txtDescricao.Text + "' cadastrada com sucesso! Código: " + modelo.Categoria.ToString());
                }
                else
                {
                    modelo.Categoria = Convert.ToInt32(txtSequencia.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Categoria '" + txtDescricao.Text + "' alterada com sucesso!");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
                this.alteraCampos("False");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "Alterar";
            this.alteraBotoes(2);
            this.alteraCampos("False");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir a categoria '" + txtDescricao.Text + "'?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosConexao.StringConexao);
                    BLLCategoria bll = new BLLCategoria(cx);
                    bll.Excluir(Convert.ToInt32(txtSequencia.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                    this.alteraCampos("False");
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro. \n O registro está sendo utilizado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}