using System;
using Pizza_Shu.DAOs;
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
    public partial class excluirProduto : Form
    {
        LogDAO Log;
        DAOProduto Produto;
        private int usuarioCodigo;
        public excluirProduto(int codigoUsuario)
        {
            InitializeComponent();
            Produto = new DAOProduto();
            Log = new LogDAO();
            usuarioCodigo = codigoUsuario;
        }//fim do construtor

        private void excluirProduto_Load(object sender, EventArgs e)
        {

        }//menu

        private void textBoxEXCCodigo_TextChanged(object sender, EventArgs e)
        {

        }//textBox codigo

        private void buttonEXCExcluir_Click(object sender, EventArgs e)
        {
            if (textBoxEXCCodigo.Text == "")
            {
                MessageBox.Show("Digite um código");
                return;
            }

            int codigo;

            if (!int.TryParse(textBoxEXCCodigo.Text, out codigo))
            {
                MessageBox.Show("Código inválido");
                return;
            }

            DataTable tabela = Produto.BuscarProduto(codigo);

            if (tabela.Rows.Count > 0)
            {
                string nome = tabela.Rows[0]["nome"].ToString();
                string descricao = tabela.Rows[0]["descricao"].ToString();
                string preco = tabela.Rows[0]["preco"].ToString();
                string quantidade = tabela.Rows[0]["quantidade"].ToString();
                string categoria = tabela.Rows[0]["categoria"].ToString();

                DialogResult resposta = MessageBox.Show(
                    "Produto encontrado:\n\n" +
                    "Nome: " + nome + "\n" +
                    "Descrição: " + descricao + "\n" +
                    "Preço: " + preco + "\n" +
                    "quantidade: " + quantidade + "\n" +
                    "Categoria: " + categoria + "\n" +
                    "Deseja excluir este Produto?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    string resultado = Produto.DeletarProduto(codigo);

                    MessageBox.Show(resultado);

                    textBoxEXCCodigo.Clear();

                    Log.InserirLog(
                    usuarioCodigo,
                    "Excluiu Produto: " + codigo
                    );
                }
            }
            else
            {
                MessageBox.Show("Produto Não Encontrado");
            }
        }//botão excluir

        private void buttonEXCVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//botão voltar

    }//fim da classe
}//fim do projeto
