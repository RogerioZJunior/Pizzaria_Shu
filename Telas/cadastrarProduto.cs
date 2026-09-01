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
    public partial class cadastrarProduto : Form
    {
        LogDAO Log;
        DAOProduto Produto;
        private int usuarioCodigo;
        public cadastrarProduto(int codigoUsuario)
        {
            InitializeComponent();
            Produto = new DAOProduto();
            Log = new LogDAO();
            usuarioCodigo = codigoUsuario;
        }//fim do construtor

        private void cadastrarProduto_Load(object sender, EventArgs e)
        {

        }//menu

        private void textBoxNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }//textbox nome produto

        private void textBoxDescricaoProduto_TextChanged(object sender, EventArgs e)
        {

        }//textbox descrição produto

        private void textBoxPrecoProduto_TextChanged(object sender, EventArgs e)
        {

        }//textbox preço produto

        private void textBoxQuantidadeProduto_TextChanged(object sender, EventArgs e)
        {

        }//textbox quantidade produto

        private void comboBoxCategoriaProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//combobox categoria produto

        private void buttonCadastrarProduto_Click(object sender, EventArgs e)
        {
            if (textBoxNomeProduto.Text == "" || textBoxPrecoProduto.Text == "" || textBoxQuantidadeProduto.Text == "" || comboBoxCategoriaProduto.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
               
                string nome = textBoxNomeProduto.Text;
                string descricao = textBoxDescricaoProduto.Text;
                decimal preco = decimal.Parse(textBoxPrecoProduto.Text);
                int quantidade = int.Parse(textBoxQuantidadeProduto.Text);
                string categoria = comboBoxCategoriaProduto.Text;
               
             
                // Inserir no banco
                Produto.InserirProduto(
                    nome, descricao, preco, quantidade, categoria);

                // Registrar log
                Log.InserirLog(usuarioCodigo,
                "Cadastrou um novo produto: " + nome);

                // Limpar os campos
                LimparCampos();
            }
        }//botão cadastrar produto

        //Limpar os campos
        public void LimparCampos()
        {
            textBoxNomeProduto.Text = "";
            textBoxDescricaoProduto.Text = "";
            textBoxPrecoProduto.Text = "";
            textBoxQuantidadeProduto.Text = "";
            comboBoxCategoriaProduto.Text = "";
        }//fim do método

        private void buttonCADProdutoVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//botão voltar

    }//fim da classe

}//fim do projeto
