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
    public partial class FormCadastrarProduto : Form
    {
        public FormCadastrarProduto()
        {
            InitializeComponent();
        }

        private void FormCadastrarProduto_Load(object sender, EventArgs e)
        {

        }

        // Método para limpar o formulário
        private void LimparFormulario()
        {
            txtCodigo.Clear();
            txtNomeDoProduto.Clear();
            txtDescricao.Clear();

            comboBoxFornecedor.SelectedIndex = -1;
            comboBoxCategoria.SelectedIndex = -1;

            numericPrecoDeCusto.Value = 0;
            numericPrecoDeVenda.Value = 0;
            numericStockInicial.Value = 0;
            numericStockMinimo.Value = 0;

            txtMargem.Clear();

            checkProdutoAtivo.Checked = false;

            dateDataDeCadastro.Value = DateTime.Today;

            txtCodigo.Focus();
        } // Limpar formulário



        // Método para calcular a margem de lucro
        private void CalcularMargem()
        {
            decimal margem = numericPrecoDeVenda.Value - numericPrecoDeCusto.Value;

            txtMargem.Text = margem.ToString("C2");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void buttonSalvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Informe o código do produto.");
                txtCodigo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNomeDoProduto.Text))
            {
                MessageBox.Show("Informe o nome do produto.");
                txtNomeDoProduto.Focus();
                return;
            }

            if (comboBoxCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria.");
                comboBoxCategoria.Focus();
                return;
            }

            if (numericPrecoDeVenda.Value < numericPrecoDeCusto.Value || numericPrecoDeVenda.Value == 0)
            {
                MessageBox.Show("O preço de venda não pode ser menor que o preço de custo.");
                numericPrecoDeVenda.Focus();
                return;
            }

            if (comboBoxFornecedor.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um fornecedor.");
                comboBoxFornecedor.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descrição do produto.");
                txtDescricao.Focus();
                return;
            }

            if (numericStockInicial.Value < 1)
            {
                MessageBox.Show("O estoque inicial deve ser maior que zero.");
                numericStockInicial.Focus();
                return;
            }

            if (numericStockMinimo.Value < 1)
            {
                MessageBox.Show("O estoque mínimo deve ser maior que zero.");
                numericStockMinimo.Focus();
                return;
            }

            if (dateDataDeCadastro.Value.Date > DateTime.Today)
            {
                MessageBox.Show("A data de cadastro não pode ser futura.");
                dateDataDeCadastro.Focus();
                return;
            }

            if (numericPrecoDeCusto.Value == 0)
            {
                MessageBox.Show("O preço de custo não pode ser zero.");
                numericPrecoDeCusto.Focus();
                return;
            }

            string codigo = txtCodigo.Text;
            string nome = txtNomeDoProduto.Text;
            string categoria = comboBoxCategoria.Text;
            string fornecedor = comboBoxFornecedor.Text;
            string descricao = txtDescricao.Text;

            decimal precoCusto = numericPrecoDeCusto.Value;
            decimal precoVenda = numericPrecoDeVenda.Value;
            decimal margem = precoVenda - precoCusto;

            int estoque = (int)numericStockInicial.Value;
            int estoqueMinimo = (int)numericStockMinimo.Value;

            bool ativo = checkProdutoAtivo.Checked;
            DateTime dataCadastro = dateDataDeCadastro.Value;

            MessageBox.Show($"Produto: {nome}\n" +
                $"Código: {codigo}\n" +
                $"Preço Venda: R$ {precoVenda:N2}\n" +
                $"Categoria: {categoria}\n" +
                $"Fornecedor: {fornecedor}\n" +
                $"Descrição: {descricao}\n" +
                $"Preço Custo: R$ {precoCusto:N2}\n" +
                $"Margem: {margem:C2}\n" +
                $"Estoque Inicial: {estoque}\n" +
                $"Estoque Mínimo: {estoqueMinimo}\n" +
                $"Data de Cadastro: {dataCadastro:dd/MM/yyyy}\n" +
                $"Ativo: {(ativo ? "Sim" : "Não")}",
                "Produto Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                    "Deseja realmente limpar todos os campos?",
                    "Limpar Formulário",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                LimparFormulario();
            }
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                    "Deseja iniciar um novo cadastro? Os dados atuais serão perdidos.",
                    "Novo Cadastro",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                LimparFormulario();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
        "Deseja realmente excluir este produto?",
        "Confirmar Exclusão",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning);

            if (resposta == DialogResult.Yes)
            {
                LimparFormulario();

                MessageBox.Show(
                    "Produto excluído com sucesso!",
                    "Exclusão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void numericPrecoDeCusto_ValueChanged(object sender, EventArgs e)
        {
            CalcularMargem();
        }

        private void numericPrecoDeVenda_ValueChanged(object sender, EventArgs e)
        {
            CalcularMargem();
        }
    }
}
