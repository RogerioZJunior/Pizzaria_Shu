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
    public partial class excluirUsuario : Form
    {
        MenuPrincipal menu;
        DAOusuario Usuario; 
        public excluirUsuario()
        {
            InitializeComponent();
            Usuario = new DAOusuario();
        }//fim do construtor

        private void excluirUsuario_Load(object sender, EventArgs e)
        {

        }//fim do menu

        private void textBoxEXCCodigo_TextChanged(object sender, EventArgs e)
        {

        }// textbox código

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

            DataTable tabela = Usuario.BuscarUsuario(codigo);

            if (tabela.Rows.Count > 0)
            {
                string nome = tabela.Rows[0]["nome"].ToString();
                string telefone = tabela.Rows[0]["telefone"].ToString();
                string endereco = tabela.Rows[0]["endereco"].ToString();
                string email = tabela.Rows[0]["email"].ToString();
                string senha = tabela.Rows[0]["senha"].ToString();
                string tipo = tabela.Rows[0]["tipo"].ToString();

                DialogResult resposta = MessageBox.Show(
                    "Usuário encontrado:\n\n" +
                    "Nome: " + nome + "\n" +
                    "Telefone: " + telefone + "\n" +
                    "endereço: " + endereco + "\n" +
                    "Email: " + email + "\n" +
                    "senha: " + senha + "\n" +
                    "Tipo de Usuário: " + tipo + "\n\n" +
                    "Deseja excluir este Usuário?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resposta == DialogResult.Yes)
                {
                    string resultado = Usuario.DeletarUsuario(codigo);

                    MessageBox.Show(resultado);

                    textBoxEXCCodigo.Clear();
                }
            }
            else
            {
                MessageBox.Show("Usuário Não Encontrado");
            }
        }// botão excluir

        private void buttonEXCVoltar_Click(object sender, EventArgs e)
        {
            menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
            this.Hide();
        }// botão voltar
    }//fim da classe
}//fim do projeto
