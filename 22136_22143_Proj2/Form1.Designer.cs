namespace _22136_22143_Proj2
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
            this.lsbArquivo = new System.Windows.Forms.ListBox();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnInicio = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
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
            this.btnAcharCaminho = new System.Windows.Forms.Button();
            this.nudCusto = new System.Windows.Forms.NumericUpDown();
            this.nudTempo = new System.Windows.Forms.NumericUpDown();
            this.nudDistancia = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.cbOrigem = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.stRegistro = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.dlgSalvar = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PassandoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminho1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminho2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminho3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminho4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminho5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminho6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminho7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caminho8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pbMapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).BeginInit();
            this.stRegistro.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.pbMapa.Size = new System.Drawing.Size(622, 492);
            this.pbMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMapa.TabIndex = 0;
            this.pbMapa.TabStop = false;
            this.pbMapa.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMapa_Paint);
            this.pbMapa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMapa_MouseClick);
            // 
            // lsbArquivo
            // 
            this.lsbArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsbArquivo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbArquivo.FormattingEnabled = true;
            this.lsbArquivo.ItemHeight = 19;
            this.lsbArquivo.Location = new System.Drawing.Point(9, 146);
            this.lsbArquivo.Margin = new System.Windows.Forms.Padding(4);
            this.lsbArquivo.Name = "lsbArquivo";
            this.lsbArquivo.Size = new System.Drawing.Size(313, 270);
            this.lsbArquivo.TabIndex = 8;
            // 
            // nudY
            // 
            this.nudY.DecimalPlaces = 6;
            this.nudY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.nudY.Location = new System.Drawing.Point(153, 112);
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
            this.label4.Location = new System.Drawing.Point(7, 114);
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
            this.nudX.Location = new System.Drawing.Point(153, 66);
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
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Coordenada X:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(153, 16);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 15;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(169, 26);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da cidade:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.btnAnterior,
            this.btnProximo,
            this.btnUltimo,
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
            this.toolStrip1.Size = new System.Drawing.Size(994, 54);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnInicio
            // 
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(40, 51);
            this.btnInicio.Text = "Início";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(54, 51);
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(56, 51);
            this.btnProximo.Text = "Próximo";
            this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(47, 51);
            this.btnUltimo.Text = "Último";
            this.btnUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
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
            // btnAcharCaminho
            // 
            this.btnAcharCaminho.Location = new System.Drawing.Point(12, 189);
            this.btnAcharCaminho.Name = "btnAcharCaminho";
            this.btnAcharCaminho.Size = new System.Drawing.Size(105, 58);
            this.btnAcharCaminho.TabIndex = 12;
            this.btnAcharCaminho.Text = "Achar Caminho";
            this.btnAcharCaminho.UseVisualStyleBackColor = true;
            // 
            // nudCusto
            // 
            this.nudCusto.Location = new System.Drawing.Point(95, 121);
            this.nudCusto.Margin = new System.Windows.Forms.Padding(4);
            this.nudCusto.Name = "nudCusto";
            this.nudCusto.Size = new System.Drawing.Size(75, 26);
            this.nudCusto.TabIndex = 11;
            // 
            // nudTempo
            // 
            this.nudTempo.Location = new System.Drawing.Point(245, 87);
            this.nudTempo.Margin = new System.Windows.Forms.Padding(4);
            this.nudTempo.Name = "nudTempo";
            this.nudTempo.Size = new System.Drawing.Size(75, 26);
            this.nudTempo.TabIndex = 10;
            // 
            // nudDistancia
            // 
            this.nudDistancia.Location = new System.Drawing.Point(95, 87);
            this.nudDistancia.Margin = new System.Windows.Forms.Padding(4);
            this.nudDistancia.Name = "nudDistancia";
            this.nudDistancia.Size = new System.Drawing.Size(75, 26);
            this.nudDistancia.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Custo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tempo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 90);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Distância:";
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(169, 41);
            this.cbDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(151, 28);
            this.cbDestino.TabIndex = 5;
            // 
            // cbOrigem
            // 
            this.cbOrigem.FormattingEnabled = true;
            this.cbOrigem.Location = new System.Drawing.Point(10, 41);
            this.cbOrigem.Margin = new System.Windows.Forms.Padding(4);
            this.cbOrigem.Name = "cbOrigem";
            this.cbOrigem.Size = new System.Drawing.Size(146, 28);
            this.cbOrigem.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Destino:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Origem:";
            // 
            // stRegistro
            // 
            this.stRegistro.BackColor = System.Drawing.Color.LightGray;
            this.stRegistro.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stRegistro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stRegistro.Location = new System.Drawing.Point(0, 665);
            this.stRegistro.Name = "stRegistro";
            this.stRegistro.Size = new System.Drawing.Size(994, 22);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(341, 492);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lsbArquivo);
            this.tabPage1.Controls.Add(this.nudY);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtNome);
            this.tabPage1.Controls.Add(this.nudX);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(333, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cidades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cbOrigem);
            this.tabPage2.Controls.Add(this.btnAcharCaminho);
            this.tabPage2.Controls.Add(this.nudCusto);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.nudTempo);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.nudDistancia);
            this.tabPage2.Controls.Add(this.cbDestino);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(333, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Busca";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.caminho1,
            this.caminho2,
            this.caminho3,
            this.caminho4,
            this.caminho5,
            this.caminho6,
            this.caminho7,
            this.caminho8});
            this.dataGridView1.Location = new System.Drawing.Point(359, 557);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 105);
            this.dataGridView1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 557);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Caminhos encontrados:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(43, 593);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(305, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Km do caminho selecionado: (XXXXX km)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Melhor caminho (yyyyy km)";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PassandoPor});
            this.dataGridView2.Location = new System.Drawing.Point(126, 189);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(194, 264);
            this.dataGridView2.TabIndex = 15;
            // 
            // PassandoPor
            // 
            this.PassandoPor.HeaderText = "Passando Por";
            this.PassandoPor.Name = "PassandoPor";
            // 
            // caminho1
            // 
            this.caminho1.HeaderText = "1a";
            this.caminho1.Name = "caminho1";
            // 
            // caminho2
            // 
            this.caminho2.HeaderText = "2a";
            this.caminho2.Name = "caminho2";
            // 
            // caminho3
            // 
            this.caminho3.HeaderText = "3a";
            this.caminho3.Name = "caminho3";
            // 
            // caminho4
            // 
            this.caminho4.HeaderText = "4a";
            this.caminho4.Name = "caminho4";
            // 
            // caminho5
            // 
            this.caminho5.HeaderText = "5a";
            this.caminho5.Name = "caminho5";
            // 
            // caminho6
            // 
            this.caminho6.HeaderText = "6a";
            this.caminho6.Name = "caminho6";
            // 
            // caminho7
            // 
            this.caminho7.HeaderText = "7a";
            this.caminho7.Name = "caminho7";
            // 
            // caminho8
            // 
            this.caminho8.HeaderText = "8a";
            this.caminho8.Name = "caminho8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 687);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDistancia)).EndInit();
            this.stRegistro.ResumeLayout(false);
            this.stRegistro.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMapa;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnInicio;
        private System.Windows.Forms.ToolStripButton btnProximo;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripButton btnUltimo;
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
        private System.Windows.Forms.ListBox lsbArquivo;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.ComboBox cbOrigem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCusto;
        private System.Windows.Forms.NumericUpDown nudTempo;
        private System.Windows.Forms.NumericUpDown nudDistancia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAcharCaminho;
        private System.Windows.Forms.StatusStrip stRegistro;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.SaveFileDialog dlgSalvar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassandoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho1;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho2;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho3;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho4;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho5;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho6;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho7;
        private System.Windows.Forms.DataGridViewTextBoxColumn caminho8;
    }
}

