using Pizza_Shu.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Shu.Telas
{
    public partial class atualizarProduto : Form
    {
        LogDAO                Log;
        DAOProduto        Produto;
        private int usuarioCodigo;
        public atualizarProduto(int codigoUsuario)
        {
            InitializeComponent();
            Produto = new DAOProduto();
            Log = new LogDAO();
            usuarioCodigo = codigoUsuario;
        }//fim do construtor

        private void atualizarProduto_Load(object sender, EventArgs e)
        {

        }//menu

        private void textBoxCodigoProduto_TextChanged(object sender, EventArgs e)
        {

        }//textBox codigo produto

        private void textBoxATUNome_TextChanged(object sender, EventArgs e)
        {

        }//textBox nome produto

        private void textBoxATUDescricao_TextChanged(object sender, EventArgs e)
        {

        }//text box descrição produto

        private void textBoxATUPreco_TextChanged(object sender, EventArgs e)
        {

        }//textBox preço produto

        private void textBoxATUQuantidade_TextChanged(object sender, EventArgs e)
        {

        }//textBox codigo produto

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//comboBox categoria

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCodigoProduto.Text))
            {
                MessageBox.Show("Preencha o Código");
                textBoxCodigoProduto.Focus();
                return;
            }

            if (!int.TryParse(textBoxCodigoProduto.Text, out int codigo))
            {
                MessageBox.Show("Código inválido");
                textBoxCodigoProduto.Focus();
                return;
            }

            try
            {
                DAOProduto dao = new DAOProduto();
                DataTable tabela = dao.BuscarProduto(codigo);

                if (tabela.Rows.Count > 0)
                {
                    DataRow linha = tabela.Rows[0];

                    textBoxATUNome.Text = linha["nome"].ToString();
                    textBoxATUDescricao.Text = linha["descricao"].ToString();
                    textBoxATUPreco.Text = linha["preco"].ToString();
                    textBoxATUQuantidade.Text = linha["quantidade"].ToString();
                    comboBox1.Text = linha["categoria"].ToString();
                }
                else
                {
                    MessageBox.Show("Produto não encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar: " + ex.Message);
            }
        }//botão procurar

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxCodigoProduto.Text, out int codigo))
            {
                MessageBox.Show("Código inválido!");
                return;
            }

            string resultado = Produto.AtualizarProduto(
                codigo,
                textBoxATUNome.Text,
                textBoxATUDescricao.Text,
                decimal.Parse(textBoxATUPreco.Text),
                Convert.ToInt32(textBoxATUQuantidade.Text),
                comboBox1.Text
            );

            MessageBox.Show(resultado);

            if (resultado == "Produto atualizado com sucesso!")
            {
                Log.InserirLog(
                    usuarioCodigo,
                    "Atualizou o Produto código: " + codigo
                );
            }

            textBoxCodigoProduto.Clear();
            textBoxATUNome.Clear();
            textBoxATUDescricao.Clear();
            textBoxATUPreco.Clear();
            textBoxATUQuantidade.Clear();
            comboBox1.SelectedIndex = -1;
        }//botão atualizar

        private void buttonATUVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//botão voltar

    }//fim da classe
}//fim do projeto
