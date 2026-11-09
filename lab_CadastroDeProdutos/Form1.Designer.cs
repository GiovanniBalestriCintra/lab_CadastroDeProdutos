namespace lab_CadastroDeProdutos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textFornecedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNomeDoProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownPrecoDeVenda = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownStockInicial = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.textMargem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownPrecoDeCusto = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDataDeCadastro = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.checkBoxprodutoAtivo = new System.Windows.Forms.CheckBox();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecoDeVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecoDeCusto)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 47);
            this.panel1.TabIndex = 0;
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxCategoria);
            this.groupBox1.Controls.Add(this.textDescricao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textFornecedor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textNomeDoProduto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textCodigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(10, 60);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(134, 23);
            this.comboBoxCategoria.TabIndex = 10;
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(194, 91);
            this.textDescricao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textDescricao.Multiline = true;
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(392, 45);
            this.textDescricao.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(192, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descrição:";
            // 
            // textFornecedor
            // 
            this.textFornecedor.Location = new System.Drawing.Point(6, 91);
            this.textFornecedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textFornecedor.Name = "textFornecedor";
            this.textFornecedor.Size = new System.Drawing.Size(174, 21);
            this.textFornecedor.TabIndex = 7;
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
            // textNomeDoProduto
            // 
            this.textNomeDoProduto.Location = new System.Drawing.Point(134, 42);
            this.textNomeDoProduto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNomeDoProduto.Name = "textNomeDoProduto";
            this.textNomeDoProduto.Size = new System.Drawing.Size(273, 21);
            this.textNomeDoProduto.TabIndex = 2;
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(6, 42);
            this.textCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(113, 21);
            this.textCodigo.TabIndex = 0;
            this.textCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownStockMinimo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numericUpDownPrecoDeVenda);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numericUpDownStockInicial);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textMargem);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numericUpDownPrecoDeCusto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(10, 215);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(407, 116);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precificação e Estoque";
            // 
            // numericUpDownStockMinimo
            // 
            this.numericUpDownStockMinimo.DecimalPlaces = 2;
            this.numericUpDownStockMinimo.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numericUpDownStockMinimo.Location = new System.Drawing.Point(291, 77);
            this.numericUpDownStockMinimo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownStockMinimo.Name = "numericUpDownStockMinimo";
            this.numericUpDownStockMinimo.Size = new System.Drawing.Size(55, 21);
            this.numericUpDownStockMinimo.TabIndex = 18;
            this.numericUpDownStockMinimo.ValueChanged += new System.EventHandler(this.numericUpDownStockMinimo_ValueChanged);
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
            // numericUpDownPrecoDeVenda
            // 
            this.numericUpDownPrecoDeVenda.DecimalPlaces = 2;
            this.numericUpDownPrecoDeVenda.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numericUpDownPrecoDeVenda.Location = new System.Drawing.Point(330, 20);
            this.numericUpDownPrecoDeVenda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownPrecoDeVenda.Name = "numericUpDownPrecoDeVenda";
            this.numericUpDownPrecoDeVenda.Size = new System.Drawing.Size(55, 21);
            this.numericUpDownPrecoDeVenda.TabIndex = 16;
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
            // numericUpDownStockInicial
            // 
            this.numericUpDownStockInicial.DecimalPlaces = 2;
            this.numericUpDownStockInicial.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numericUpDownStockInicial.Location = new System.Drawing.Point(108, 80);
            this.numericUpDownStockInicial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownStockInicial.Name = "numericUpDownStockInicial";
            this.numericUpDownStockInicial.Size = new System.Drawing.Size(61, 21);
            this.numericUpDownStockInicial.TabIndex = 14;
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
            // textMargem
            // 
            this.textMargem.Location = new System.Drawing.Point(94, 48);
            this.textMargem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textMargem.Name = "textMargem";
            this.textMargem.Size = new System.Drawing.Size(86, 21);
            this.textMargem.TabIndex = 10;
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
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // numericUpDownPrecoDeCusto
            // 
            this.numericUpDownPrecoDeCusto.DecimalPlaces = 2;
            this.numericUpDownPrecoDeCusto.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numericUpDownPrecoDeCusto.Location = new System.Drawing.Point(120, 20);
            this.numericUpDownPrecoDeCusto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDownPrecoDeCusto.Name = "numericUpDownPrecoDeCusto";
            this.numericUpDownPrecoDeCusto.Size = new System.Drawing.Size(60, 21);
            this.numericUpDownPrecoDeCusto.TabIndex = 11;
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
            this.groupBox3.Controls.Add(this.dateTimePickerDataDeCadastro);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.checkBoxprodutoAtivo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox3.Location = new System.Drawing.Point(421, 215);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(295, 116);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Situação / Detalhes";
            // 
            // dateTimePickerDataDeCadastro
            // 
            this.dateTimePickerDataDeCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataDeCadastro.Location = new System.Drawing.Point(10, 70);
            this.dateTimePickerDataDeCadastro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerDataDeCadastro.Name = "dateTimePickerDataDeCadastro";
            this.dateTimePickerDataDeCadastro.Size = new System.Drawing.Size(121, 21);
            this.dateTimePickerDataDeCadastro.TabIndex = 20;
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
            // checkBoxprodutoAtivo
            // 
            this.checkBoxprodutoAtivo.AutoSize = true;
            this.checkBoxprodutoAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxprodutoAtivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxprodutoAtivo.Location = new System.Drawing.Point(10, 21);
            this.checkBoxprodutoAtivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxprodutoAtivo.Name = "checkBoxprodutoAtivo";
            this.checkBoxprodutoAtivo.Size = new System.Drawing.Size(97, 19);
            this.checkBoxprodutoAtivo.TabIndex = 0;
            this.checkBoxprodutoAtivo.Text = "Produto Ativo";
            this.checkBoxprodutoAtivo.UseVisualStyleBackColor = true;
            this.checkBoxprodutoAtivo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(440, 10);
            this.buttonNovo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(70, 28);
            this.buttonNovo.TabIndex = 20;
            this.buttonNovo.Text = "➕ Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(514, 10);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.buttonLimpar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(66, 28);
            this.buttonLimpar.TabIndex = 22;
            this.buttonLimpar.Text = "🧹 Limpar\n";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(659, 10);
            this.buttonExcluir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(66, 28);
            this.buttonExcluir.TabIndex = 23;
            this.buttonExcluir.Text = "🗑️ Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.buttonExcluir);
            this.panel2.Controls.Add(this.buttonNovo);
            this.panel2.Controls.Add(this.buttonSalvar);
            this.panel2.Controls.Add(this.buttonLimpar);
            this.panel2.Location = new System.Drawing.Point(-2, 373);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 43);
            this.panel2.TabIndex = 24;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 454);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecoDeVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecoDeCusto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNomeDoProduto;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textFornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textMargem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecoDeCusto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownStockMinimo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownPrecoDeVenda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownStockInicial;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataDeCadastro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBoxprodutoAtivo;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

