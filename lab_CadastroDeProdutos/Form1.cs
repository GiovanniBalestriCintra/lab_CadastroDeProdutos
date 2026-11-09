using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace lab_CadastroDeProdutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            string codigo = textCodigo.Text;
            string nome = textNomeDoProduto.Text;
            string categoria = comboBoxCategoria.Text;
            string fornecedor = textFornecedor.Text;
            string descricao = textDescricao.Text;

            decimal precoCusto = numericUpDownPrecoDeCusto.Value;
            decimal precoVenda = numericUpDownPrecoDeVenda.Value;
            decimal margem = decimal.Parse(textMargem.Text);
            decimal estoque = numericUpDownStockInicial.Value;
            decimal estoqueMinimo = numericUpDownStockMinimo.Value;

            bool ativo = checkBoxprodutoAtivo.Checked;
            DateTime dataCadastro = dateTimePickerDataDeCadastro.Value;

            MessageBox.Show(
                $"Produto: {nome}\n" +
                $"Preço Venda: R$ {precoVenda:N2}",
                "Produto Salvo"
            );
        }

        private void numericUpDownStockMinimo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
