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
    public partial class atualizarUsuario : Form
    {
        LogDAO Log; 
        DAOusuario Usuario;
        private int usuarioCodigo;
        public atualizarUsuario(int codigoUsuario)
        {
            InitializeComponent();
            Usuario = new DAOusuario();
            Log = new LogDAO();
            usuarioCodigo = codigoUsuario;
        }//fim do construtor

        private void atualizarUsuario_Load(object sender, EventArgs e)
        {

        }//menu

        private void textBoxATUNome_TextChanged(object sender, EventArgs e)
        {

        }// textbox atualizar nome

        private void maskedTextBoxATUTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }// maskedtextBox atualizar telefone

        private void textBoxATUEndereco_TextChanged(object sender, EventArgs e)
        {

        }// textbox atualizar endereço

        private void textBoxATUEmail_TextChanged(object sender, EventArgs e)
        {

        }// textbox atualizar email

        private void textBoxATUSenha_TextChanged(object sender, EventArgs e)
        {

        }// textbox atualizar senha

        private void checkBoxATUADM_CheckedChanged(object sender, EventArgs e)
        {

        }// checkBox atualizar ADM

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }// textbox código

        private void buttonProcurar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCodigo.Text))
            {
                MessageBox.Show("Preencha o Código");
                textBoxCodigo.Focus();
                return;
            }

            if (!int.TryParse(textBoxCodigo.Text, out int codigo))
            {
                MessageBox.Show("Código inválido");
                textBoxCodigo.Focus();
                return;
            }

            try
            {
                DAOusuario dao = new DAOusuario();
                DataTable tabela = dao.BuscarUsuario(codigo);

                if (tabela.Rows.Count > 0)
                {
                    DataRow linha = tabela.Rows[0];

                    textBoxATUNome.Text           = linha["nome"].ToString();
                    maskedTextBoxATUTelefone.Text = linha["telefone"].ToString();
                    textBoxATUEndereco.Text       = linha["endereco"].ToString();
                    textBoxATUEmail.Text          = linha["email"].ToString();
                    textBoxATUSenha.Text          = linha["senha"].ToString();
                    checkBoxATUADM.Text           = linha["tipo"].ToString();
                }
                else
                {
                    MessageBox.Show("Usuário não encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar: " + ex.Message);
            }
        }// botão proccurar

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxCodigo.Text, out int codigo))
            {
                MessageBox.Show("Código inválido!");
                return;
            }

            string resultado = Usuario.AtualizarUsuario(
                codigo,
                textBoxATUNome.Text,
                maskedTextBoxATUTelefone.Text,
                textBoxATUEndereco.Text,
                textBoxATUEmail.Text,
                textBoxATUSenha.Text,
                checkBoxATUADM.Checked
            );

            MessageBox.Show(resultado);

            if (resultado == "Usuário atualizado com sucesso!")
            {
                Log.InserirLog(
                    usuarioCodigo,
                    "Atualizou o usuário código: " + codigo
                );
            }

            textBoxCodigo.Clear();
            textBoxATUNome.Clear();
            maskedTextBoxATUTelefone.Clear();
            textBoxATUEndereco.Clear();
            textBoxATUEmail.Clear();
            textBoxATUSenha.Clear();
            checkBoxATUADM.Checked = false;

        }//botão atualizar

        private void buttonATUVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//botão voltar
    }//fim da clase
}//fim do projeto
