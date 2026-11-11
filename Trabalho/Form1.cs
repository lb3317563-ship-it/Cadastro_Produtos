using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class Form1 : Form
    {
        private List<string[]> produtos = new List<string[]>();
        private int proximoCodigo = 1;

        public Form1()
        {
            InitializeComponent();

            // Vincula os eventos de mudança de preço para calcular a margem automaticamente (Requisito 4)
            nudPrecoCusto.ValueChanged += numPrecoCusto_ValueChanged;
            nudPrecoVenda.ValueChanged += numPrecoVenda_ValueChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configura campos como ReadOnly (conforme visual cinza do wireframe)
            txtCodigo.ReadOnly = true;
            txtMargem.ReadOnly = true;

            // Popula os ComboBoxes com opções de teste se estiverem vazios
            if (cmbCategoria.Items.Count == 0)
            {
                cmbCategoria.Items.AddRange(new string[] { "Eletrônicos", "Periféricos", "Acessórios", "Hardware" });
            }

            if (cmbFornecedor.Items.Count == 0)
            {
                cmbFornecedor.Items.AddRange(new string[] { "Fornecedor A", "Fornecedor B", "Distribuidora Tech" });
            }

            // Define os valores padrão iniciais (Requisito 6)
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCodigo.Text = "00000";
            txtNome.Clear();
            richTextBox1.Clear();
            txtMargem.Text = "0,00";

            cmbCategoria.SelectedIndex = -1;
            cmbFornecedor.SelectedIndex = -1;

            nudPrecoCusto.Value = 0;
            nudPrecoVenda.Value = 0;
            nudStockInicial.Value = 0;
            nudStockMinimo.Value = 0;

            chkProduto.Checked = true;
            dtpDatacadastro.Value = DateTime.Now;

            // Foca obrigatoriamente no campo Nome (Requisito 6)
            txtNome.Focus();
        }

        private void GerarCodigo()
        {
            txtCodigo.Text = proximoCodigo.ToString("D6");
            proximoCodigo++;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            GerarCodigo(); // Gera código sequencial simulado (Observação da atividade)
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1. Campos Obrigatórios (Requisito 5)
            if (string.IsNullOrWhiteSpace(txtNome.Text)) { ExibirAlerta("O campo 'Nome do Produto' é obrigatório!", txtNome); return; }
            if (cmbCategoria.SelectedIndex == -1) { ExibirAlerta("Selecione uma categoria válida!", cmbCategoria); return; }
            if (cmbFornecedor.SelectedIndex == -1) { ExibirAlerta("Selecione um fornecedor válido!", cmbFornecedor); return; }

            // 2. Validação de Preços (Requisito 5)
            if (nudPrecoVenda.Value <= 0) { ExibirAlerta("O 'Preço de Venda' deve ser maior que zero!", nudPrecoVenda); return; }
            if (nudPrecoVenda.Value < nudPrecoCusto.Value) { ExibirAlerta("O 'Preço de Venda' não pode ser menor que o 'Preço de Custo'!", nudPrecoVenda); return; }

            // 3. Validação de Estoque (Requisito 5)
            if (nudStockInicial.Value < 0) { ExibirAlerta("O 'Estoque Inicial' não pode ser negativo!", nudStockInicial); return; }
            if (nudStockMinimo.Value < 0) { ExibirAlerta("O 'Estoque Mínimo' não pode ser negativo!", nudStockMinimo); return; }

            // Salva simulado e confirma
            MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExibirAlerta(string mensagem, Control campo)
        {
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            campo.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || txtCodigo.Text == "00000")
            {
                MessageBox.Show("Nenhum produto selecionado para exclusão.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Deseja realmente excluir o produto '{txtNome.Text}'?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
        }

        // Cálculo Automático da Margem de Lucro (Requisito 4)
        private void CalcularMargem()
        {
            decimal custo = nudPrecoCusto.Value;
            decimal venda = nudPrecoVenda.Value;
            decimal margem = venda - custo;

            txtMargem.Text = margem.ToString("N2");
        }

        private void numPrecoCusto_ValueChanged(object sender, EventArgs e)
        {
            CalcularMargem();
        }

        private void numPrecoVenda_ValueChanged(object sender, EventArgs e)
        {
            CalcularMargem();
        }

        // Eventos vazios mantidos para evitar quebras
        private void txtCodigo_TextChanged(object sender, EventArgs e) { }
        private void txtNome_TextChanged(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label16_Click(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
        private void groupBox3_Enter(object sender, EventArgs e) { }
    }
}