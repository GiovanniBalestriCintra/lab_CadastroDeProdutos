namespace lab_CadastroDeProdutos
{
    partial class FormCadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarProduto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeDoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericPrecoDeVenda = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericStockInicial = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMargem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericPrecoDeCusto = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateDataDeCadastro = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.checkProdutoAtivo = new System.Windows.Forms.CheckBox();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStockMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoDeVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStockInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoDeCusto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 47);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(87, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro De Produtos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxFornecedor);
            this.groupBox1.Controls.Add(this.comboBoxCategoria);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomeDoProduto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(10, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(706, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Principais";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Eletrônicos",
            "Alimentos",
            "Roupas",
            "Bebidas",
            "Higiene",
            "Outros"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(427, 42);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(134, 23);
            this.comboBoxCategoria.TabIndex = 10;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(231, 91);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(448, 45);
            this.txtDescricao.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(234, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descrição:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fornecedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(424, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(131, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome do Produto:";
            // 
            // txtNomeDoProduto
            // 
            this.txtNomeDoProduto.Location = new System.Drawing.Point(134, 42);
            this.txtNomeDoProduto.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeDoProduto.Name = "txtNomeDoProduto";
            this.txtNomeDoProduto.Size = new System.Drawing.Size(273, 21);
            this.txtNomeDoProduto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(6, 42);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(113, 21);
            this.txtCodigo.TabIndex = 10;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericStockMinimo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numericPrecoDeVenda);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numericStockInicial);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtMargem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numericPrecoDeCusto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(10, 215);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(407, 116);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precificação e Estoque";
            // 
            // numericStockMinimo
            // 
            this.numericStockMinimo.Location = new System.Drawing.Point(291, 77);
            this.numericStockMinimo.Margin = new System.Windows.Forms.Padding(2);
            this.numericStockMinimo.Name = "numericStockMinimo";
            this.numericStockMinimo.Size = new System.Drawing.Size(55, 21);
            this.numericStockMinimo.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(202, 79);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Stock Mínimo:";
            // 
            // numericPrecoDeVenda
            // 
            this.numericPrecoDeVenda.DecimalPlaces = 2;
            this.numericPrecoDeVenda.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numericPrecoDeVenda.Location = new System.Drawing.Point(330, 20);
            this.numericPrecoDeVenda.Margin = new System.Windows.Forms.Padding(2);
            this.numericPrecoDeVenda.Name = "numericPrecoDeVenda";
            this.numericPrecoDeVenda.Size = new System.Drawing.Size(55, 21);
            this.numericPrecoDeVenda.TabIndex = 16;
            this.numericPrecoDeVenda.ValueChanged += new System.EventHandler(this.numericPrecoDeVenda_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(202, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Preço de Venda (R$):";
            // 
            // numericStockInicial
            // 
            this.numericStockInicial.Location = new System.Drawing.Point(85, 79);
            this.numericStockInicial.Margin = new System.Windows.Forms.Padding(2);
            this.numericStockInicial.Name = "numericStockInicial";
            this.numericStockInicial.Size = new System.Drawing.Size(61, 21);
            this.numericStockInicial.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 81);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Stock Inicial:";
            // 
            // txtMargem
            // 
            this.txtMargem.Location = new System.Drawing.Point(102, 47);
            this.txtMargem.Margin = new System.Windows.Forms.Padding(2);
            this.txtMargem.Name = "txtMargem";
            this.txtMargem.Size = new System.Drawing.Size(86, 21);
            this.txtMargem.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Margem (R$):";
            // 
            // numericPrecoDeCusto
            // 
            this.numericPrecoDeCusto.DecimalPlaces = 2;
            this.numericPrecoDeCusto.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numericPrecoDeCusto.Location = new System.Drawing.Point(128, 20);
            this.numericPrecoDeCusto.Margin = new System.Windows.Forms.Padding(2);
            this.numericPrecoDeCusto.Name = "numericPrecoDeCusto";
            this.numericPrecoDeCusto.Size = new System.Drawing.Size(60, 21);
            this.numericPrecoDeCusto.TabIndex = 11;
            this.numericPrecoDeCusto.ValueChanged += new System.EventHandler(this.numericPrecoDeCusto_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(4, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Preço de Custo (R$):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateDataDeCadastro);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.checkProdutoAtivo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox3.Location = new System.Drawing.Point(421, 215);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(295, 116);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Situação / Detalhes";
            // 
            // dateDataDeCadastro
            // 
            this.dateDataDeCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataDeCadastro.Location = new System.Drawing.Point(10, 70);
            this.dateDataDeCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.dateDataDeCadastro.Name = "dateDataDeCadastro";
            this.dateDataDeCadastro.Size = new System.Drawing.Size(121, 21);
            this.dateDataDeCadastro.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(8, 53);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Data de Cadastro:";
            // 
            // checkProdutoAtivo
            // 
            this.checkProdutoAtivo.AutoSize = true;
            this.checkProdutoAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkProdutoAtivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkProdutoAtivo.Location = new System.Drawing.Point(10, 21);
            this.checkProdutoAtivo.Margin = new System.Windows.Forms.Padding(2);
            this.checkProdutoAtivo.Name = "checkProdutoAtivo";
            this.checkProdutoAtivo.Size = new System.Drawing.Size(97, 19);
            this.checkProdutoAtivo.TabIndex = 0;
            this.checkProdutoAtivo.Text = "Produto Ativo";
            this.checkProdutoAtivo.UseVisualStyleBackColor = true;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(440, 10);
            this.buttonNovo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(70, 28);
            this.buttonNovo.TabIndex = 20;
            this.buttonNovo.Text = "➕ Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(514, 10);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(70, 28);
            this.buttonSalvar.TabIndex = 21;
            this.buttonSalvar.Text = "💾 Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(588, 10);
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(66, 28);
            this.buttonLimpar.TabIndex = 22;
            this.buttonLimpar.Text = "🧹 Limpar\n";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(659, 10);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(66, 28);
            this.buttonExcluir.TabIndex = 23;
            this.buttonExcluir.Text = "🗑️ Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.buttonExcluir);
            this.panel2.Controls.Add(this.buttonNovo);
            this.panel2.Controls.Add(this.buttonSalvar);
            this.panel2.Controls.Add(this.buttonLimpar);
            this.panel2.Location = new System.Drawing.Point(-2, 373);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 43);
            this.panel2.TabIndex = 24;
            // 
            // comboBoxFornecedor
            // 
            this.comboBoxFornecedor.FormattingEnabled = true;
            this.comboBoxFornecedor.Items.AddRange(new object[] {
            "Apple",
            "Camil",
            "Nike",
            "Coca Cola",
            "Colgate",
            "Outros"});
            this.comboBoxFornecedor.Location = new System.Drawing.Point(6, 91);
            this.comboBoxFornecedor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(134, 23);
            this.comboBoxFornecedor.TabIndex = 11;
            // 
            // FormCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 415);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCadastrarProduto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormCadastrarProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericStockMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoDeVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStockInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPrecoDeCusto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeDoProduto;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMargem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericPrecoDeCusto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericStockMinimo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericPrecoDeVenda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericStockInicial;
        private System.Windows.Forms.DateTimePicker dateDataDeCadastro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkProdutoAtivo;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxFornecedor;
    }
}

