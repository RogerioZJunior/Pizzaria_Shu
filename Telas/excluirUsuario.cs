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
        LogDAO Log;
        DAOusuario Usuario;
        private int usuarioCodigo;
        public excluirUsuario(int codigoUsuario)
        {
            InitializeComponent();
            Usuario = new DAOusuario();
            Log = new LogDAO();
            usuarioCodigo = codigoUsuario;
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

                bool usuarioAtivo = Convert.ToBoolean(
                    tabela.Rows[0]["ativo"]
                );

                string situacao = usuarioAtivo
                    ? "ATIVO"
                    : "DESATIVADO";

                string pergunta;

                if (usuarioAtivo)
                {
                    pergunta =
                        "Deseja DESATIVAR este Usuário?\n\n" +
                        "Os eventos e pedidos deste usuário serão cancelados.";
                }
                else
                {
                    pergunta =
                        "Este usuário está DESATIVADO.\n\n" +
                        "Deseja REATIVAR este Usuário?";
                }

                DialogResult resposta = MessageBox.Show(
                    "Usuário encontrado:\n\n" +
                    "Nome: " + nome + "\n" +
                    "Telefone: " + telefone + "\n" +
                    "Endereço: " + endereco + "\n" +
                    "Email: " + email + "\n" +
                    "Senha: " + senha + "\n" +
                    "Tipo de Usuário: " + tipo + "\n" +
                    "Ativo: " + situacao + "\n\n" +
                    pergunta,
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resposta == DialogResult.Yes)
                {
                    string resultado;

                    if (usuarioAtivo)
                    {
                        // DESATIVAR
                        resultado = Usuario.DeletarUsuario(codigo);

                        Log.InserirLog(
                            usuarioCodigo,
                            "Desativou Usuário: " + codigo
                        );
                    }
                    else
                    {
                        // REATIVAR
                        resultado = Usuario.ReativarUsuario(codigo);

                        Log.InserirLog(
                            usuarioCodigo,
                            "Reativou Usuário: " + codigo
                        );
                    }

                    MessageBox.Show(resultado);

                    textBoxEXCCodigo.Clear();
                }
            }
            else
            {
                MessageBox.Show("Usuário Não Encontrado");
            }
        }//botão excluir

        private void buttonEXCVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }// botão voltar
    }//fim da classe
}//fim do projeto
