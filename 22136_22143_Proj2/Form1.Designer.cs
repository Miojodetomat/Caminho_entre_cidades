namespace _22136_22143_Proj1ED
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
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
            this.btnIncluirCaminho = new System.Windows.Forms.Button();
            this.btnExcluirCaminho = new System.Windows.Forms.Button();
            this.btnAlterarCaminho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.stRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.nudY.Location = new System.Drawing.Point(171, 227);
            this.nudY.Margin = new System.Windows.Forms.Padding(4);
            this.nudY.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(169, 30);
            this.nudY.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
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
            this.nudX.Location = new System.Drawing.Point(171, 181);
            this.nudX.Margin = new System.Windows.Forms.Padding(4);
            this.nudX.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(169, 30);
            this.nudX.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Coordenada X:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(171, 117);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 15;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(169, 30);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da cidade:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.btnProcurar,
            this.toolStripSeparator2,
            this.btnNovo,
            this.btnCancelar,
            this.btnSalvar,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.btnExcluir,
            this.toolStripSeparator5,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(997, 59);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 59);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(68, 56);
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 59);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(49, 56);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(70, 56);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(53, 56);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 59);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 59);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(56, 56);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 59);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(38, 56);
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
            this.stRegistro.Location = new System.Drawing.Point(0, 662);
            this.stRegistro.Name = "stRegistro";
            this.stRegistro.Size = new System.Drawing.Size(997, 26);
            this.stRegistro.TabIndex = 4;
            this.stRegistro.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 20);
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
            this.groupBox1.Controls.Add(this.btnAlterarCaminho);
            this.groupBox1.Controls.Add(this.btnExcluirCaminho);
            this.groupBox1.Controls.Add(this.btnIncluirCaminho);
            this.groupBox1.Location = new System.Drawing.Point(12, 461);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 90);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caminhos";
            // 
            // btnIncluirCaminho
            // 
            this.btnIncluirCaminho.Location = new System.Drawing.Point(225, 38);
            this.btnIncluirCaminho.Name = "btnIncluirCaminho";
            this.btnIncluirCaminho.Size = new System.Drawing.Size(96, 40);
            this.btnIncluirCaminho.TabIndex = 7;
            this.btnIncluirCaminho.Text = "Incluir";
            this.btnIncluirCaminho.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCaminho
            // 
            this.btnExcluirCaminho.Location = new System.Drawing.Point(13, 38);
            this.btnExcluirCaminho.Name = "btnExcluirCaminho";
            this.btnExcluirCaminho.Size = new System.Drawing.Size(96, 40);
            this.btnExcluirCaminho.TabIndex = 8;
            this.btnExcluirCaminho.Text = "Excluir";
            this.btnExcluirCaminho.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCaminho
            // 
            this.btnAlterarCaminho.Location = new System.Drawing.Point(119, 38);
            this.btnAlterarCaminho.Name = "btnAlterarCaminho";
            this.btnAlterarCaminho.Size = new System.Drawing.Size(96, 40);
            this.btnAlterarCaminho.TabIndex = 9;
            this.btnAlterarCaminho.Text = "Alterar";
            this.btnAlterarCaminho.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 688);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCaminhos);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stRegistro);
            this.Controls.Add(this.toolStrip1);
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
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.stRegistro.ResumeLayout(false);
            this.stRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaminhos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMapa;
        private System.Windows.Forms.ToolStrip toolStrip1;
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
        private System.Windows.Forms.Button btnAlterarCaminho;
        private System.Windows.Forms.Button btnExcluirCaminho;
        private System.Windows.Forms.Button btnIncluirCaminho;
    }
}

