namespace GUI
{
    partial class frmVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbFinanceiro = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.lblObservacao = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblRepetirCada = new System.Windows.Forms.Label();
            this.txtOcorrencias = new System.Windows.Forms.TextBox();
            this.lblNrOcorrencias = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtSequencia = new System.Windows.Forms.TextBox();
            this.lblSequencia = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.cmbContaDestino = new System.Windows.Forms.ComboBox();
            this.lblContaDestino = new System.Windows.Forms.Label();
            this.cmbContaOrigem = new System.Windows.Forms.ComboBox();
            this.lblContaOrigem = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.gpbFinanceiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbFinanceiro
            // 
            this.gpbFinanceiro.Controls.Add(this.textBox2);
            this.gpbFinanceiro.Controls.Add(this.textBox1);
            this.gpbFinanceiro.Controls.Add(this.label2);
            this.gpbFinanceiro.Controls.Add(this.lblCredito);
            this.gpbFinanceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbFinanceiro.Location = new System.Drawing.Point(17, 242);
            this.gpbFinanceiro.Name = "gpbFinanceiro";
            this.gpbFinanceiro.Size = new System.Drawing.Size(505, 76);
            this.gpbFinanceiro.TabIndex = 116;
            this.gpbFinanceiro.TabStop = false;
            this.gpbFinanceiro.Text = "Financeiro";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(97, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 90;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(97, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "A Receber";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredito.Location = new System.Drawing.Point(24, 22);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(45, 13);
            this.lblCredito.TabIndex = 87;
            this.lblCredito.Text = "A Pagar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::GUI.Properties.Resources.Delete_80_icon_icons_com_57340;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(874, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 60);
            this.btnCancelar.TabIndex = 115;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::GUI.Properties.Resources.trash_can_115312;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcluir.Location = new System.Drawing.Point(808, 260);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(60, 60);
            this.btnExcluir.TabIndex = 114;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::GUI.Properties.Resources.twocirclingarrows1_120592_1_;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAlterar.Location = new System.Drawing.Point(742, 260);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(60, 60);
            this.btnAlterar.TabIndex = 113;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.BorderSize = 0;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Image = global::GUI.Properties.Resources.document_add_256_icon_icons_com_75994_1_;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIncluir.Location = new System.Drawing.Point(676, 260);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(60, 60);
            this.btnIncluir.TabIndex = 112;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::GUI.Properties.Resources.logout256_24927_1_;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSair.Location = new System.Drawing.Point(940, 264);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 55);
            this.btnSair.TabIndex = 111;
            this.btnSair.Text = "Fechar";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // txtObservacao
            // 
            this.txtObservacao.Enabled = false;
            this.txtObservacao.Location = new System.Drawing.Point(532, 131);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(473, 113);
            this.txtObservacao.TabIndex = 98;
            // 
            // lblObservacao
            // 
            this.lblObservacao.AutoSize = true;
            this.lblObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacao.Location = new System.Drawing.Point(530, 115);
            this.lblObservacao.Name = "lblObservacao";
            this.lblObservacao.Size = new System.Drawing.Size(34, 13);
            this.lblObservacao.TabIndex = 110;
            this.lblObservacao.Text = "Nota";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.Enabled = false;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Items.AddRange(new object[] {
            "dia",
            "semana",
            "mês",
            "ano"});
            this.cmbPeriodo.Location = new System.Drawing.Point(171, 198);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(64, 21);
            this.cmbPeriodo.TabIndex = 97;
            // 
            // txtNumero
            // 
            this.txtNumero.Enabled = false;
            this.txtNumero.Location = new System.Drawing.Point(114, 199);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(45, 20);
            this.txtNumero.TabIndex = 96;
            // 
            // lblRepetirCada
            // 
            this.lblRepetirCada.AutoSize = true;
            this.lblRepetirCada.Location = new System.Drawing.Point(14, 203);
            this.lblRepetirCada.Name = "lblRepetirCada";
            this.lblRepetirCada.Size = new System.Drawing.Size(77, 13);
            this.lblRepetirCada.TabIndex = 109;
            this.lblRepetirCada.Text = "Repetir a cada";
            // 
            // txtOcorrencias
            // 
            this.txtOcorrencias.Enabled = false;
            this.txtOcorrencias.Location = new System.Drawing.Point(114, 170);
            this.txtOcorrencias.Name = "txtOcorrencias";
            this.txtOcorrencias.Size = new System.Drawing.Size(45, 20);
            this.txtOcorrencias.TabIndex = 95;
            // 
            // lblNrOcorrencias
            // 
            this.lblNrOcorrencias.AutoSize = true;
            this.lblNrOcorrencias.Location = new System.Drawing.Point(14, 173);
            this.lblNrOcorrencias.Name = "lblNrOcorrencias";
            this.lblNrOcorrencias.Size = new System.Drawing.Size(79, 13);
            this.lblNrOcorrencias.TabIndex = 108;
            this.lblNrOcorrencias.Text = "Nr. de parcelas";
            // 
            // txtNota
            // 
            this.txtNota.Enabled = false;
            this.txtNota.Location = new System.Drawing.Point(449, 81);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(168, 20);
            this.txtNota.TabIndex = 90;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(446, 65);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(139, 13);
            this.lblNota.TabIndex = 107;
            this.lblNota.Text = "Nota / Cupom / Pedido";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.Enabled = false;
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(17, 81);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(426, 21);
            this.cmbFornecedor.TabIndex = 89;
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(14, 65);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(71, 13);
            this.lblFornecedor.TabIndex = 106;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtSequencia
            // 
            this.txtSequencia.Enabled = false;
            this.txtSequencia.Location = new System.Drawing.Point(139, 31);
            this.txtSequencia.Name = "txtSequencia";
            this.txtSequencia.Size = new System.Drawing.Size(81, 20);
            this.txtSequencia.TabIndex = 105;
            // 
            // lblSequencia
            // 
            this.lblSequencia.AutoSize = true;
            this.lblSequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSequencia.Location = new System.Drawing.Point(136, 15);
            this.lblSequencia.Name = "lblSequencia";
            this.lblSequencia.Size = new System.Drawing.Size(76, 13);
            this.lblSequencia.TabIndex = 104;
            this.lblSequencia.Text = "Lançamento";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(884, 81);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 93;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(941, 65);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(64, 13);
            this.lblValor.TabIndex = 103;
            this.lblValor.Text = "Valor (R$)";
            // 
            // cmbContaDestino
            // 
            this.cmbContaDestino.Enabled = false;
            this.cmbContaDestino.FormattingEnabled = true;
            this.cmbContaDestino.Location = new System.Drawing.Point(756, 81);
            this.cmbContaDestino.Name = "cmbContaDestino";
            this.cmbContaDestino.Size = new System.Drawing.Size(121, 21);
            this.cmbContaDestino.TabIndex = 92;
            // 
            // lblContaDestino
            // 
            this.lblContaDestino.AutoSize = true;
            this.lblContaDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaDestino.Location = new System.Drawing.Point(753, 65);
            this.lblContaDestino.Name = "lblContaDestino";
            this.lblContaDestino.Size = new System.Drawing.Size(87, 13);
            this.lblContaDestino.TabIndex = 102;
            this.lblContaDestino.Text = "Conta Destino";
            // 
            // cmbContaOrigem
            // 
            this.cmbContaOrigem.Enabled = false;
            this.cmbContaOrigem.FormattingEnabled = true;
            this.cmbContaOrigem.Location = new System.Drawing.Point(625, 81);
            this.cmbContaOrigem.Name = "cmbContaOrigem";
            this.cmbContaOrigem.Size = new System.Drawing.Size(121, 21);
            this.cmbContaOrigem.TabIndex = 91;
            // 
            // lblContaOrigem
            // 
            this.lblContaOrigem.AutoSize = true;
            this.lblContaOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaOrigem.Location = new System.Drawing.Point(623, 65);
            this.lblContaOrigem.Name = "lblContaOrigem";
            this.lblContaOrigem.Size = new System.Drawing.Size(83, 13);
            this.lblContaOrigem.TabIndex = 101;
            this.lblContaOrigem.Text = "Conta Origem";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(17, 131);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(505, 20);
            this.txtDescricao.TabIndex = 94;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(15, 115);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(64, 13);
            this.lblDescricao.TabIndex = 100;
            this.lblDescricao.Text = "Descrição";
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(17, 31);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(95, 20);
            this.dtpData.TabIndex = 88;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(14, 15);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 13);
            this.lblData.TabIndex = 99;
            this.lblData.Text = "Data";
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 335);
            this.Controls.Add(this.gpbFinanceiro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtObservacao);
            this.Controls.Add(this.lblObservacao);
            this.Controls.Add(this.cmbPeriodo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblRepetirCada);
            this.Controls.Add(this.txtOcorrencias);
            this.Controls.Add(this.lblNrOcorrencias);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtSequencia);
            this.Controls.Add(this.lblSequencia);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.cmbContaDestino);
            this.Controls.Add(this.lblContaDestino);
            this.Controls.Add(this.cmbContaOrigem);
            this.Controls.Add(this.lblContaOrigem);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Name = "frmVenda";
            this.Text = "Movimentação de Venda";
            this.gpbFinanceiro.ResumeLayout(false);
            this.gpbFinanceiro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbFinanceiro;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label lblObservacao;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblRepetirCada;
        private System.Windows.Forms.TextBox txtOcorrencias;
        private System.Windows.Forms.Label lblNrOcorrencias;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtSequencia;
        private System.Windows.Forms.Label lblSequencia;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.ComboBox cmbContaDestino;
        private System.Windows.Forms.Label lblContaDestino;
        private System.Windows.Forms.ComboBox cmbContaOrigem;
        private System.Windows.Forms.Label lblContaOrigem;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblData;
    }
}