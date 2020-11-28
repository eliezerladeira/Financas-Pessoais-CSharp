namespace GUI
{
    partial class frmTransaction
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
            this.rdbTransferencia = new System.Windows.Forms.RadioButton();
            this.rdbReceita = new System.Windows.Forms.RadioButton();
            this.rdbDespesa = new System.Windows.Forms.RadioButton();
            this.lblSequencia = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblConta1 = new System.Windows.Forms.Label();
            this.cmbConta1 = new System.Windows.Forms.ComboBox();
            this.cmbConta2 = new System.Windows.Forms.ComboBox();
            this.lblConta2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.chkConsolidada = new System.Windows.Forms.CheckBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblRepetir = new System.Windows.Forms.Label();
            this.panRepetirTransacao = new System.Windows.Forms.Panel();
            this.rdbAvancado = new System.Windows.Forms.RadioButton();
            this.rdbParcelamento = new System.Windows.Forms.RadioButton();
            this.rdbSemRepeticao = new System.Windows.Forms.RadioButton();
            this.panParcelamento = new System.Windows.Forms.Panel();
            this.txtParcela2 = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtParcela1 = new System.Windows.Forms.TextBox();
            this.lblParcelaFim = new System.Windows.Forms.Label();
            this.lblParcelaInicio = new System.Windows.Forms.Label();
            this.panAvancado = new System.Windows.Forms.Panel();
            this.lblTotalAvancado = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblRepetirCada = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.chkIndefinido = new System.Windows.Forms.CheckBox();
            this.lblParcelaInicioAvancado = new System.Windows.Forms.Label();
            this.txtParcela1Avancado = new System.Windows.Forms.TextBox();
            this.txtParcelaFimAvancado = new System.Windows.Forms.TextBox();
            this.lblParcelaFimAvancado = new System.Windows.Forms.Label();
            this.lblNrOcorrencias = new System.Windows.Forms.Label();
            this.txtOcorrencias = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panRepetirTransacao.SuspendLayout();
            this.panParcelamento.SuspendLayout();
            this.panAvancado.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbTransferencia
            // 
            this.rdbTransferencia.AutoSize = true;
            this.rdbTransferencia.Enabled = false;
            this.rdbTransferencia.Location = new System.Drawing.Point(185, 26);
            this.rdbTransferencia.Name = "rdbTransferencia";
            this.rdbTransferencia.Size = new System.Drawing.Size(90, 17);
            this.rdbTransferencia.TabIndex = 5;
            this.rdbTransferencia.Text = "Transferência";
            this.rdbTransferencia.UseVisualStyleBackColor = true;
            // 
            // rdbReceita
            // 
            this.rdbReceita.AutoSize = true;
            this.rdbReceita.Enabled = false;
            this.rdbReceita.Location = new System.Drawing.Point(106, 26);
            this.rdbReceita.Name = "rdbReceita";
            this.rdbReceita.Size = new System.Drawing.Size(62, 17);
            this.rdbReceita.TabIndex = 4;
            this.rdbReceita.Text = "Receita";
            this.rdbReceita.UseVisualStyleBackColor = true;
            // 
            // rdbDespesa
            // 
            this.rdbDespesa.AutoSize = true;
            this.rdbDespesa.Checked = true;
            this.rdbDespesa.Enabled = false;
            this.rdbDespesa.Location = new System.Drawing.Point(20, 26);
            this.rdbDespesa.Name = "rdbDespesa";
            this.rdbDespesa.Size = new System.Drawing.Size(67, 17);
            this.rdbDespesa.TabIndex = 3;
            this.rdbDespesa.TabStop = true;
            this.rdbDespesa.Text = "Despesa";
            this.rdbDespesa.UseVisualStyleBackColor = true;
            // 
            // lblSequencia
            // 
            this.lblSequencia.AutoSize = true;
            this.lblSequencia.Location = new System.Drawing.Point(972, 28);
            this.lblSequencia.Name = "lblSequencia";
            this.lblSequencia.Size = new System.Drawing.Size(35, 13);
            this.lblSequencia.TabIndex = 6;
            this.lblSequencia.Text = "label1";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(16, 56);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 13);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Data";
            // 
            // dtpData
            // 
            this.dtpData.Enabled = false;
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(19, 72);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(95, 20);
            this.dtpData.TabIndex = 8;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(122, 56);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(64, 13);
            this.lblDescricao.TabIndex = 9;
            this.lblDescricao.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(124, 72);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(400, 20);
            this.txtDescricao.TabIndex = 10;
            // 
            // lblConta1
            // 
            this.lblConta1.AutoSize = true;
            this.lblConta1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta1.Location = new System.Drawing.Point(532, 56);
            this.lblConta1.Name = "lblConta1";
            this.lblConta1.Size = new System.Drawing.Size(61, 13);
            this.lblConta1.TabIndex = 11;
            this.lblConta1.Text = "Categoria";
            // 
            // cmbConta1
            // 
            this.cmbConta1.Enabled = false;
            this.cmbConta1.FormattingEnabled = true;
            this.cmbConta1.Location = new System.Drawing.Point(534, 72);
            this.cmbConta1.Name = "cmbConta1";
            this.cmbConta1.Size = new System.Drawing.Size(121, 21);
            this.cmbConta1.TabIndex = 12;
            // 
            // cmbConta2
            // 
            this.cmbConta2.Enabled = false;
            this.cmbConta2.FormattingEnabled = true;
            this.cmbConta2.Location = new System.Drawing.Point(665, 72);
            this.cmbConta2.Name = "cmbConta2";
            this.cmbConta2.Size = new System.Drawing.Size(121, 21);
            this.cmbConta2.TabIndex = 14;
            // 
            // lblConta2
            // 
            this.lblConta2.AutoSize = true;
            this.lblConta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConta2.Location = new System.Drawing.Point(662, 56);
            this.lblConta2.Name = "lblConta2";
            this.lblConta2.Size = new System.Drawing.Size(40, 13);
            this.lblConta2.TabIndex = 13;
            this.lblConta2.Text = "Conta";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(796, 72);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 16;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(794, 56);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(64, 13);
            this.lblValor.TabIndex = 15;
            this.lblValor.Text = "Valor (R$)";
            // 
            // chkConsolidada
            // 
            this.chkConsolidada.AutoSize = true;
            this.chkConsolidada.Enabled = false;
            this.chkConsolidada.Location = new System.Drawing.Point(923, 74);
            this.chkConsolidada.Name = "chkConsolidada";
            this.chkConsolidada.Size = new System.Drawing.Size(84, 17);
            this.chkConsolidada.TabIndex = 17;
            this.chkConsolidada.Text = "Consolidada";
            this.chkConsolidada.UseVisualStyleBackColor = true;
            // 
            // txtNota
            // 
            this.txtNota.Enabled = false;
            this.txtNota.Location = new System.Drawing.Point(534, 128);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(473, 113);
            this.txtNota.TabIndex = 19;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.Location = new System.Drawing.Point(532, 112);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(34, 13);
            this.lblNota.TabIndex = 18;
            this.lblNota.Text = "Nota";
            // 
            // lblRepetir
            // 
            this.lblRepetir.AutoSize = true;
            this.lblRepetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepetir.Location = new System.Drawing.Point(17, 112);
            this.lblRepetir.Name = "lblRepetir";
            this.lblRepetir.Size = new System.Drawing.Size(112, 13);
            this.lblRepetir.TabIndex = 20;
            this.lblRepetir.Text = "Repetir Transação";
            // 
            // panRepetirTransacao
            // 
            this.panRepetirTransacao.Controls.Add(this.rdbAvancado);
            this.panRepetirTransacao.Controls.Add(this.rdbParcelamento);
            this.panRepetirTransacao.Controls.Add(this.rdbSemRepeticao);
            this.panRepetirTransacao.Location = new System.Drawing.Point(5, 128);
            this.panRepetirTransacao.Name = "panRepetirTransacao";
            this.panRepetirTransacao.Size = new System.Drawing.Size(519, 37);
            this.panRepetirTransacao.TabIndex = 21;
            // 
            // rdbAvancado
            // 
            this.rdbAvancado.AutoSize = true;
            this.rdbAvancado.Enabled = false;
            this.rdbAvancado.Location = new System.Drawing.Point(231, 12);
            this.rdbAvancado.Name = "rdbAvancado";
            this.rdbAvancado.Size = new System.Drawing.Size(74, 17);
            this.rdbAvancado.TabIndex = 8;
            this.rdbAvancado.Text = "Avançado";
            this.rdbAvancado.UseVisualStyleBackColor = true;
            // 
            // rdbParcelamento
            // 
            this.rdbParcelamento.AutoSize = true;
            this.rdbParcelamento.Enabled = false;
            this.rdbParcelamento.Location = new System.Drawing.Point(128, 12);
            this.rdbParcelamento.Name = "rdbParcelamento";
            this.rdbParcelamento.Size = new System.Drawing.Size(90, 17);
            this.rdbParcelamento.TabIndex = 7;
            this.rdbParcelamento.Text = "Parcelamento";
            this.rdbParcelamento.UseVisualStyleBackColor = true;
            // 
            // rdbSemRepeticao
            // 
            this.rdbSemRepeticao.AutoSize = true;
            this.rdbSemRepeticao.Checked = true;
            this.rdbSemRepeticao.Enabled = false;
            this.rdbSemRepeticao.Location = new System.Drawing.Point(15, 12);
            this.rdbSemRepeticao.Name = "rdbSemRepeticao";
            this.rdbSemRepeticao.Size = new System.Drawing.Size(98, 17);
            this.rdbSemRepeticao.TabIndex = 6;
            this.rdbSemRepeticao.TabStop = true;
            this.rdbSemRepeticao.Text = "Sem Repetição";
            this.rdbSemRepeticao.UseVisualStyleBackColor = true;
            // 
            // panParcelamento
            // 
            this.panParcelamento.Controls.Add(this.txtParcela2);
            this.panParcelamento.Controls.Add(this.lblTotal);
            this.panParcelamento.Controls.Add(this.txtParcela1);
            this.panParcelamento.Controls.Add(this.lblParcelaFim);
            this.panParcelamento.Controls.Add(this.lblParcelaInicio);
            this.panParcelamento.Location = new System.Drawing.Point(5, 166);
            this.panParcelamento.Name = "panParcelamento";
            this.panParcelamento.Size = new System.Drawing.Size(516, 92);
            this.panParcelamento.TabIndex = 29;
            this.panParcelamento.Visible = false;
            // 
            // txtParcela2
            // 
            this.txtParcela2.Location = new System.Drawing.Point(183, 11);
            this.txtParcela2.Name = "txtParcela2";
            this.txtParcela2.Size = new System.Drawing.Size(45, 20);
            this.txtParcela2.TabIndex = 33;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(13, 45);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(79, 13);
            this.lblTotal.TabIndex = 32;
            this.lblTotal.Text = "Totalizando R$";
            // 
            // txtParcela1
            // 
            this.txtParcela1.Location = new System.Drawing.Point(107, 11);
            this.txtParcela1.Name = "txtParcela1";
            this.txtParcela1.Size = new System.Drawing.Size(45, 20);
            this.txtParcela1.TabIndex = 31;
            // 
            // lblParcelaFim
            // 
            this.lblParcelaFim.AutoSize = true;
            this.lblParcelaFim.Location = new System.Drawing.Point(158, 14);
            this.lblParcelaFim.Name = "lblParcelaFim";
            this.lblParcelaFim.Size = new System.Drawing.Size(19, 13);
            this.lblParcelaFim.TabIndex = 30;
            this.lblParcelaFim.Text = "de";
            // 
            // lblParcelaInicio
            // 
            this.lblParcelaInicio.AutoSize = true;
            this.lblParcelaInicio.Location = new System.Drawing.Point(13, 14);
            this.lblParcelaInicio.Name = "lblParcelaInicio";
            this.lblParcelaInicio.Size = new System.Drawing.Size(88, 13);
            this.lblParcelaInicio.TabIndex = 29;
            this.lblParcelaInicio.Text = "Iniciar na parcela";
            // 
            // panAvancado
            // 
            this.panAvancado.Controls.Add(this.txtOcorrencias);
            this.panAvancado.Controls.Add(this.lblNrOcorrencias);
            this.panAvancado.Controls.Add(this.lblParcelaFimAvancado);
            this.panAvancado.Controls.Add(this.txtParcelaFimAvancado);
            this.panAvancado.Controls.Add(this.txtParcela1Avancado);
            this.panAvancado.Controls.Add(this.lblParcelaInicioAvancado);
            this.panAvancado.Controls.Add(this.chkIndefinido);
            this.panAvancado.Controls.Add(this.cmbPeriodo);
            this.panAvancado.Controls.Add(this.lblTotalAvancado);
            this.panAvancado.Controls.Add(this.txtNumero);
            this.panAvancado.Controls.Add(this.lblRepetirCada);
            this.panAvancado.Location = new System.Drawing.Point(5, 166);
            this.panAvancado.Name = "panAvancado";
            this.panAvancado.Size = new System.Drawing.Size(516, 151);
            this.panAvancado.TabIndex = 34;
            this.panAvancado.Visible = false;
            // 
            // lblTotalAvancado
            // 
            this.lblTotalAvancado.AutoSize = true;
            this.lblTotalAvancado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAvancado.Location = new System.Drawing.Point(13, 112);
            this.lblTotalAvancado.Name = "lblTotalAvancado";
            this.lblTotalAvancado.Size = new System.Drawing.Size(93, 13);
            this.lblTotalAvancado.TabIndex = 32;
            this.lblTotalAvancado.Text = "Totalizando R$";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(113, 10);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(45, 20);
            this.txtNumero.TabIndex = 31;
            // 
            // lblRepetirCada
            // 
            this.lblRepetirCada.AutoSize = true;
            this.lblRepetirCada.Location = new System.Drawing.Point(13, 14);
            this.lblRepetirCada.Name = "lblRepetirCada";
            this.lblRepetirCada.Size = new System.Drawing.Size(77, 13);
            this.lblRepetirCada.TabIndex = 29;
            this.lblRepetirCada.Text = "Repetir a cada";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Items.AddRange(new object[] {
            "dia",
            "semana",
            "mês",
            "ano"});
            this.cmbPeriodo.Location = new System.Drawing.Point(170, 9);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(64, 21);
            this.cmbPeriodo.TabIndex = 33;
            // 
            // chkIndefinido
            // 
            this.chkIndefinido.AutoSize = true;
            this.chkIndefinido.Enabled = false;
            this.chkIndefinido.Location = new System.Drawing.Point(260, 13);
            this.chkIndefinido.Name = "chkIndefinido";
            this.chkIndefinido.Size = new System.Drawing.Size(137, 17);
            this.chkIndefinido.TabIndex = 34;
            this.chkIndefinido.Text = "Repetir indefinidamente";
            this.chkIndefinido.UseVisualStyleBackColor = true;
            // 
            // lblParcelaInicioAvancado
            // 
            this.lblParcelaInicioAvancado.AutoSize = true;
            this.lblParcelaInicioAvancado.Location = new System.Drawing.Point(13, 45);
            this.lblParcelaInicioAvancado.Name = "lblParcelaInicioAvancado";
            this.lblParcelaInicioAvancado.Size = new System.Drawing.Size(88, 13);
            this.lblParcelaInicioAvancado.TabIndex = 35;
            this.lblParcelaInicioAvancado.Text = "Iniciar na parcela";
            // 
            // txtParcela1Avancado
            // 
            this.txtParcela1Avancado.Location = new System.Drawing.Point(113, 42);
            this.txtParcela1Avancado.Name = "txtParcela1Avancado";
            this.txtParcela1Avancado.Size = new System.Drawing.Size(45, 20);
            this.txtParcela1Avancado.TabIndex = 36;
            // 
            // txtParcelaFimAvancado
            // 
            this.txtParcelaFimAvancado.Location = new System.Drawing.Point(189, 42);
            this.txtParcelaFimAvancado.Name = "txtParcelaFimAvancado";
            this.txtParcelaFimAvancado.Size = new System.Drawing.Size(45, 20);
            this.txtParcelaFimAvancado.TabIndex = 37;
            // 
            // lblParcelaFimAvancado
            // 
            this.lblParcelaFimAvancado.AutoSize = true;
            this.lblParcelaFimAvancado.Location = new System.Drawing.Point(164, 45);
            this.lblParcelaFimAvancado.Name = "lblParcelaFimAvancado";
            this.lblParcelaFimAvancado.Size = new System.Drawing.Size(19, 13);
            this.lblParcelaFimAvancado.TabIndex = 38;
            this.lblParcelaFimAvancado.Text = "de";
            // 
            // lblNrOcorrencias
            // 
            this.lblNrOcorrencias.AutoSize = true;
            this.lblNrOcorrencias.Location = new System.Drawing.Point(13, 77);
            this.lblNrOcorrencias.Name = "lblNrOcorrencias";
            this.lblNrOcorrencias.Size = new System.Drawing.Size(94, 13);
            this.lblNrOcorrencias.TabIndex = 39;
            this.lblNrOcorrencias.Text = "Nr. de ocorrências";
            // 
            // txtOcorrencias
            // 
            this.txtOcorrencias.Location = new System.Drawing.Point(113, 74);
            this.txtOcorrencias.Name = "txtOcorrencias";
            this.txtOcorrencias.Size = new System.Drawing.Size(45, 20);
            this.txtOcorrencias.TabIndex = 40;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::GUI.Properties.Resources.Delete_80_icon_icons_com_57340;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(876, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 60);
            this.btnCancelar.TabIndex = 39;
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
            this.btnExcluir.Location = new System.Drawing.Point(810, 257);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(60, 60);
            this.btnExcluir.TabIndex = 38;
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
            this.btnAlterar.Location = new System.Drawing.Point(744, 257);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(60, 60);
            this.btnAlterar.TabIndex = 37;
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
            this.btnIncluir.Location = new System.Drawing.Point(678, 257);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(60, 60);
            this.btnIncluir.TabIndex = 36;
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
            this.btnSair.Location = new System.Drawing.Point(942, 261);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 55);
            this.btnSair.TabIndex = 35;
            this.btnSair.Text = "Fechar";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // frmTransacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 326);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panAvancado);
            this.Controls.Add(this.panParcelamento);
            this.Controls.Add(this.panRepetirTransacao);
            this.Controls.Add(this.lblRepetir);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.chkConsolidada);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.cmbConta2);
            this.Controls.Add(this.lblConta2);
            this.Controls.Add(this.cmbConta1);
            this.Controls.Add(this.lblConta1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblSequencia);
            this.Controls.Add(this.rdbTransferencia);
            this.Controls.Add(this.rdbReceita);
            this.Controls.Add(this.rdbDespesa);
            this.Name = "frmTransacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transações";
            this.panRepetirTransacao.ResumeLayout(false);
            this.panRepetirTransacao.PerformLayout();
            this.panParcelamento.ResumeLayout(false);
            this.panParcelamento.PerformLayout();
            this.panAvancado.ResumeLayout(false);
            this.panAvancado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbTransferencia;
        private System.Windows.Forms.RadioButton rdbReceita;
        private System.Windows.Forms.RadioButton rdbDespesa;
        private System.Windows.Forms.Label lblSequencia;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblConta1;
        private System.Windows.Forms.ComboBox cmbConta1;
        private System.Windows.Forms.ComboBox cmbConta2;
        private System.Windows.Forms.Label lblConta2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.CheckBox chkConsolidada;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblRepetir;
        private System.Windows.Forms.Panel panRepetirTransacao;
        private System.Windows.Forms.RadioButton rdbAvancado;
        private System.Windows.Forms.RadioButton rdbParcelamento;
        private System.Windows.Forms.RadioButton rdbSemRepeticao;
        private System.Windows.Forms.Panel panParcelamento;
        private System.Windows.Forms.TextBox txtParcela2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtParcela1;
        private System.Windows.Forms.Label lblParcelaFim;
        private System.Windows.Forms.Label lblParcelaInicio;
        private System.Windows.Forms.Panel panAvancado;
        private System.Windows.Forms.TextBox txtOcorrencias;
        private System.Windows.Forms.Label lblNrOcorrencias;
        private System.Windows.Forms.Label lblParcelaFimAvancado;
        private System.Windows.Forms.TextBox txtParcelaFimAvancado;
        private System.Windows.Forms.TextBox txtParcela1Avancado;
        private System.Windows.Forms.Label lblParcelaInicioAvancado;
        private System.Windows.Forms.CheckBox chkIndefinido;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Label lblTotalAvancado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblRepetirCada;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
    }
}