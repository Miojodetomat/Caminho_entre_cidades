﻿namespace _22136_22143_Proj1ED
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbMapa = new System.Windows.Forms.PictureBox();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tsOpcoes = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProcurar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.stRegistro = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dlgSalvar = new System.Windows.Forms.SaveFileDialog();
            this.dgvCaminhos = new System.Windows.Forms.DataGridView();
            this.caminho1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminho2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminho3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminho4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminho5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminho6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminho7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminho8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcCaminhosCidades = new System.Windows.Forms.TabControl();
            this.tpCidades = new System.Windows.Forms.TabPage();
            this.tpCaminhos = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.txtOrigem = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.nudDistancia = new System.Windows.Forms.NumericUpDown();
            this.nudTempo = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.tsOpcoes.SuspendLayout();
            this.stRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tcCaminhosCidades.SuspendLayout();
            this.tpCidades.SuspendLayout();
            this.tpCaminhos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMapa
            // 
            this.pbMapa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMapa.Image = global::_22136_22143_Proj2.Properties.Resources.mapaEspanhaPortugal;
            this.pbMapa.InitialImage = null;
            this.pbMapa.Location = new System.Drawing.Point(359, 58);
            this.pbMapa.Margin = new System.Windows.Forms.Padding(4);
            this.pbMapa.Name = "pbMapa";
            this.pbMapa.Size = new System.Drawing.Size(625, 493);
            this.pbMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMapa.TabIndex = 0;
            this.pbMapa.TabStop = false;
            this.pbMapa.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMapa_Paint);
            this.pbMapa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMapa_MouseClick);
            // 
            // nudY
            // 
            this.nudY.DecimalPlaces = 6;
            this.nudY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.nudY.Location = new System.Drawing.Point(143, 136);
            this.nudY.Margin = new System.Windows.Forms.Padding(4);
            this.nudY.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(169, 26);
            this.nudY.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Coordenada Y:";
            // 
            // nudX
            // 
            this.nudX.DecimalPlaces = 6;
            this.nudX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.nudX.Location = new System.Drawing.Point(143, 98);
            this.nudX.Margin = new System.Windows.Forms.Padding(4);
            this.nudX.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(169, 26);
            this.nudX.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Coordenada X:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(143, 48);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 15;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(169, 26);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da cidade:";
            // 
            // tsOpcoes
            // 
            this.tsOpcoes.BackColor = System.Drawing.Color.LightGray;
            this.tsOpcoes.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsOpcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnProcurar,
            this.toolStripSeparator2,
            this.btnNovo,
            this.btnCancelar,
            this.btnEditar,
            this.btnSalvar,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.btnExcluir,
            this.toolStripSeparator5,
            this.btnSair});
            this.tsOpcoes.Location = new System.Drawing.Point(0, 0);
            this.tsOpcoes.Name = "tsOpcoes";
            this.tsOpcoes.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tsOpcoes.Size = new System.Drawing.Size(997, 54);
            this.tsOpcoes.TabIndex = 2;
            this.tsOpcoes.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(56, 51);
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(40, 51);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 51);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(42, 51);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 54);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 54);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(46, 51);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 54);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(36, 51);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // stRegistro
            // 
            this.stRegistro.BackColor = System.Drawing.Color.LightGray;
            this.stRegistro.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stRegistro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stRegistro.Location = new System.Drawing.Point(0, 666);
            this.stRegistro.Name = "stRegistro";
            this.stRegistro.Size = new System.Drawing.Size(997, 22);
            this.stRegistro.TabIndex = 4;
            this.stRegistro.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Registro:";
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "openFileDialog1";
            // 
            // dgvCaminhos
            // 
            this.dgvCaminhos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaminhos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caminho1,
            this.caminho2,
            this.caminho3,
            this.caminho4,
            this.caminho5,
            this.caminho6,
            this.caminho7,
            this.caminho8});
            this.dgvCaminhos.Location = new System.Drawing.Point(12, 557);
            this.dgvCaminhos.Name = "dgvCaminhos";
            this.dgvCaminhos.RowHeadersWidth = 51;
            this.dgvCaminhos.Size = new System.Drawing.Size(972, 102);
            this.dgvCaminhos.TabIndex = 6;
            this.dgvCaminhos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaminhos_CellClick);
            this.dgvCaminhos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaminhos_CellContentClick);
            // 
            // caminho1
            // 
            this.caminho1.HeaderText = "1a";
            this.caminho1.MinimumWidth = 6;
            this.caminho1.Name = "caminho1";
            this.caminho1.Width = 125;
            // 
            // caminho2
            // 
            this.caminho2.HeaderText = "2a";
            this.caminho2.MinimumWidth = 6;
            this.caminho2.Name = "caminho2";
            this.caminho2.Width = 125;
            // 
            // caminho3
            // 
            this.caminho3.HeaderText = "3a";
            this.caminho3.MinimumWidth = 6;
            this.caminho3.Name = "caminho3";
            this.caminho3.Width = 125;
            // 
            // caminho4
            // 
            this.caminho4.HeaderText = "4a";
            this.caminho4.MinimumWidth = 6;
            this.caminho4.Name = "caminho4";
            this.caminho4.Width = 125;
            // 
            // caminho5
            // 
            this.caminho5.HeaderText = "5a";
            this.caminho5.MinimumWidth = 6;
            this.caminho5.Name = "caminho5";
            this.caminho5.Width = 125;
            // 
            // caminho6
            // 
            this.caminho6.HeaderText = "6a";
            this.caminho6.MinimumWidth = 6;
            this.caminho6.Name = "caminho6";
            this.caminho6.Width = 125;
            // 
            // caminho7
            // 
            this.caminho7.HeaderText = "7a";
            this.caminho7.MinimumWidth = 6;
            this.caminho7.Name = "caminho7";
            this.caminho7.Width = 125;
            // 
            // caminho8
            // 
            this.caminho8.HeaderText = "8a";
            this.caminho8.MinimumWidth = 6;
            this.caminho8.Name = "caminho8";
            this.caminho8.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.txtOrigem);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtDestino);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nudDistancia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nudTempo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 214);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caminhos";
            // 
            // tcCaminhosCidades
            // 
            this.tcCaminhosCidades.Controls.Add(this.tpCidades);
            this.tcCaminhosCidades.Controls.Add(this.tpCaminhos);
            this.tcCaminhosCidades.Location = new System.Drawing.Point(12, 71);
            this.tcCaminhosCidades.Name = "tcCaminhosCidades";
            this.tcCaminhosCidades.SelectedIndex = 0;
            this.tcCaminhosCidades.Size = new System.Drawing.Size(340, 259);
            this.tcCaminhosCidades.TabIndex = 11;
            // 
            // tpCidades
            // 
            this.tpCidades.Controls.Add(this.label2);
            this.tpCidades.Controls.Add(this.txtNome);
            this.tpCidades.Controls.Add(this.nudY);
            this.tpCidades.Controls.Add(this.label3);
            this.tpCidades.Controls.Add(this.label4);
            this.tpCidades.Controls.Add(this.nudX);
            this.tpCidades.Location = new System.Drawing.Point(4, 29);
            this.tpCidades.Name = "tpCidades";
            this.tpCidades.Padding = new System.Windows.Forms.Padding(3);
            this.tpCidades.Size = new System.Drawing.Size(332, 226);
            this.tpCidades.TabIndex = 0;
            this.tpCidades.Text = "Cidades";
            this.tpCidades.UseVisualStyleBackColor = true;
            // 
            // tpCaminhos
            // 
            this.tpCaminhos.Controls.Add(this.groupBox1);
            this.tpCaminhos.Location = new System.Drawing.Point(4, 29);
            this.tpCaminhos.Name = "tpCaminhos";
            this.tpCaminhos.Padding = new System.Windows.Forms.Padding(3);
            this.tpCaminhos.Size = new System.Drawing.Size(332, 226);
            this.tpCaminhos.TabIndex = 1;
            this.tpCaminhos.Text = "Caminhos";
            this.tpCaminhos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Caminhos entre cidades:";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 51);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtOrigem
            // 
            this.txtOrigem.Location = new System.Drawing.Point(114, 34);
            this.txtOrigem.Name = "txtOrigem";
            this.txtOrigem.Size = new System.Drawing.Size(200, 26);
            this.txtOrigem.TabIndex = 0;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(114, 78);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(200, 26);
            this.txtDestino.TabIndex = 1;
            // 
            // nudDistancia
            // 
            this.nudDistancia.Location = new System.Drawing.Point(114, 125);
            this.nudDistancia.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDistancia.Name = "nudDistancia";
            this.nudDistancia.Size = new System.Drawing.Size(159, 26);
            this.nudDistancia.TabIndex = 2;
            // 
            // nudTempo
            // 
            this.nudTempo.Location = new System.Drawing.Point(114, 169);
            this.nudTempo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudTempo.Name = "nudTempo";
            this.nudTempo.Size = new System.Drawing.Size(159, 26);
            this.nudTempo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Km";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Origem:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Destino:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Distancia:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tempo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 688);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tcCaminhosCidades);
            this.Controls.Add(this.dgvCaminhos);
            this.Controls.Add(this.stRegistro);
            this.Controls.Add(this.tsOpcoes);
            this.Controls.Add(this.pbMapa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Rede de Trens entre Cidades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.tsOpcoes.ResumeLayout(false);
            this.tsOpcoes.PerformLayout();
            this.stRegistro.ResumeLayout(false);
            this.stRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tcCaminhosCidades.ResumeLayout(false);
            this.tpCidades.ResumeLayout(false);
            this.tpCidades.PerformLayout();
            this.tpCaminhos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMapa;
        private System.Windows.Forms.ToolStrip tsOpcoes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnProcurar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip stRegistro;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.SaveFileDialog dlgSalvar;
        private System.Windows.Forms.DataGridView dgvCaminhos;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho1;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho2;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho3;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho4;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho5;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho6;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho7;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tcCaminhosCidades;
        private System.Windows.Forms.TabPage tpCidades;
        private System.Windows.Forms.TabPage tpCaminhos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.TextBox txtOrigem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudDistancia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudTempo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

