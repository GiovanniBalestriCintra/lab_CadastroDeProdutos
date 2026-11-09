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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.textNomeDoProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textFornecedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownPrecoDeCusto = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.textMargem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownStockInicial = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownPrecoDeVenda = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxprodutoAtivo = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePickerDataDeCadastro = new System.Windows.Forms.DateTimePicker();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecoDeCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecoDeVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockMinimo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 58);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 36);
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
            this.groupBox1.Location = new System.Drawing.Point(13, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Principais";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(8, 52);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(149, 24);
            this.textCodigo.TabIndex = 0;
            this.textCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textNomeDoProduto
            // 
            this.textNomeDoProduto.Location = new System.Drawing.Point(178, 52);
            this.textNomeDoProduto.Name = "textNomeDoProduto";
            this.textNomeDoProduto.Size = new System.Drawing.Size(363, 24);
            this.textNomeDoProduto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(175, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome do Produto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(566, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(8, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fornecedor:";
            // 
            // textFornecedor
            // 
            this.textFornecedor.Location = new System.Drawing.Point(8, 112);
            this.textFornecedor.Name = "textFornecedor";
            this.textFornecedor.Size = new System.Drawing.Size(230, 24);
            this.textFornecedor.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(256, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Descrição:";
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(259, 112);
            this.textDescricao.Multiline = true;
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(521, 55);
            this.textDescricao.TabIndex = 9;
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
            this.groupBox2.Location = new System.Drawing.Point(13, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 143);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precificação e Estoque";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(5, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Preço de Custo (R$):";
            // 
            // numericUpDownPrecoDeCusto
            // 
            this.numericUpDownPrecoDeCusto.DecimalPlaces = 2;
            this.numericUpDownPrecoDeCusto.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numericUpDownPrecoDeCusto.Location = new System.Drawing.Point(160, 24);
            this.numericUpDownPrecoDeCusto.Name = "numericUpDownPrecoDeCusto";
            this.numericUpDownPrecoDeCusto.Size = new System.Drawing.Size(57, 24);
            this.numericUpDownPrecoDeCusto.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(8, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Margem (R$):";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textMargem
            // 
            this.textMargem.Location = new System.Drawing.Point(126, 59);
            this.textMargem.Name = "textMargem";
            this.textMargem.Size = new System.Drawing.Size(105, 24);
            this.textMargem.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(8, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Stock Inicial:";
            // 
            // numericUpDownStockInicial
            // 
            this.numericUpDownStockInicial.DecimalPlaces = 2;
            this.numericUpDownStockInicial.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numericUpDownStockInicial.Location = new System.Drawing.Point(144, 98);
            this.numericUpDownStockInicial.Name = "numericUpDownStockInicial";
            this.numericUpDownStockInicial.Size = new System.Drawing.Size(73, 24);
            this.numericUpDownStockInicial.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(240, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 18);
            this.label10.TabIndex = 15;
            this.label10.Text = "Preço de Venda (R$):";
            // 
            // numericUpDownPrecoDeVenda
            // 
            this.numericUpDownPrecoDeVenda.DecimalPlaces = 2;
            this.numericUpDownPrecoDeVenda.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numericUpDownPrecoDeVenda.Location = new System.Drawing.Point(396, 24);
            this.numericUpDownPrecoDeVenda.Name = "numericUpDownPrecoDeVenda";
            this.numericUpDownPrecoDeVenda.Size = new System.Drawing.Size(73, 24);
            this.numericUpDownPrecoDeVenda.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(256, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Stock Mínimo:";
            // 
            // numericUpDownStockMinimo
            // 
            this.numericUpDownStockMinimo.DecimalPlaces = 2;
            this.numericUpDownStockMinimo.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numericUpDownStockMinimo.Location = new System.Drawing.Point(387, 100);
            this.numericUpDownStockMinimo.Name = "numericUpDownStockMinimo";
            this.numericUpDownStockMinimo.Size = new System.Drawing.Size(73, 24);
            this.numericUpDownStockMinimo.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePickerDataDeCadastro);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.checkBoxprodutoAtivo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox3.Location = new System.Drawing.Point(511, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 143);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Situação / Detalhes";
            // 
            // checkBoxprodutoAtivo
            // 
            this.checkBoxprodutoAtivo.AutoSize = true;
            this.checkBoxprodutoAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxprodutoAtivo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxprodutoAtivo.Location = new System.Drawing.Point(13, 26);
            this.checkBoxprodutoAtivo.Name = "checkBoxprodutoAtivo";
            this.checkBoxprodutoAtivo.Size = new System.Drawing.Size(119, 22);
            this.checkBoxprodutoAtivo.TabIndex = 0;
            this.checkBoxprodutoAtivo.Text = "Produto Ativo";
            this.checkBoxprodutoAtivo.UseVisualStyleBackColor = true;
            this.checkBoxprodutoAtivo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(10, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 18);
            this.label12.TabIndex = 19;
            this.label12.Text = "Data de Cadastro:";
            // 
            // dateTimePickerDataDeCadastro
            // 
            this.dateTimePickerDataDeCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataDeCadastro.Location = new System.Drawing.Point(13, 86);
            this.dateTimePickerDataDeCadastro.Name = "dateTimePickerDataDeCadastro";
            this.dateTimePickerDataDeCadastro.Size = new System.Drawing.Size(160, 24);
            this.dateTimePickerDataDeCadastro.TabIndex = 20;
            // 
            // buttonNovo
            // 
            this.buttonNovo.Location = new System.Drawing.Point(441, 15);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(93, 35);
            this.buttonNovo.TabIndex = 20;
            this.buttonNovo.Text = "➕ Novo";
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(540, 15);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(93, 35);
            this.buttonSalvar.TabIndex = 21;
            this.buttonSalvar.Text = "💾 Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(639, 15);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(88, 35);
            this.buttonLimpar.TabIndex = 22;
            this.buttonLimpar.Text = "🧹 Limpar\n";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(733, 15);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(88, 35);
            this.buttonExcluir.TabIndex = 23;
            this.buttonExcluir.Text = "🗑️ Excluir";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.button4_Click);
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
            this.comboBoxCategoria.Location = new System.Drawing.Point(569, 52);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(178, 26);
            this.comboBoxCategoria.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.buttonExcluir);
            this.panel2.Controls.Add(this.buttonNovo);
            this.panel2.Controls.Add(this.buttonSalvar);
            this.panel2.Controls.Add(this.buttonLimpar);
            this.panel2.Location = new System.Drawing.Point(-2, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 53);
            this.panel2.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecoDeCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrecoDeVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStockMinimo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
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
    }
}

