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
using System.Windows.Forms.VisualStyles;

namespace Pizza_Shu.Telas
{
    public partial class cadastrarUsuario : Form
    {
        MenuPrincipal menu;
        DAOusuario Usuario;
        public cadastrarUsuario()
        {
            InitializeComponent();
            Usuario = new DAOusuario();
        }//fim do construtor

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }//textBox nome
        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//textBox telefone

        private void textBoxEndereco_TextChanged(object sender, EventArgs e)
        {

        }//textBox endereço

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }//textBox email

        private void textBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }//textBox senha

        private void checkBoxADM_CheckedChanged(object sender, EventArgs e)
        {

        }//checkBox ADM 

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (textBoxNome.Text == "" || !maskedTextBoxTelefone.MaskCompleted || textBoxEndereco.Text == "" || textBoxEmail.Text == "" || textBoxSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                // Removendo itens desnecessarios 
                maskedTextBoxTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

                string nome = textBoxNome.Text;
                string telefone = maskedTextBoxTelefone.Text;
                string endereco = textBoxEndereco.Text;
                string email = textBoxEmail.Text;
                string senha = textBoxSenha.Text;
                bool tipo = checkBoxADM.Checked; // Checkbox marcada = 1 // Checkbox desmarcada = 0

                if (maskedTextBoxTelefone.Text.Length < 11)
                {
                    MessageBox.Show("Telefone incompleta");
                    return;
                }
                // Inserir no banco
                Usuario.InserirUsuario(
                    nome, telefone, endereco, email, senha, tipo);

                // Limpar os campos
                LimparCampos();
            }
        }//botão cadastrar

         //Limpar os campos
         public void LimparCampos()
         {
            textBoxNome.Text = "";
            maskedTextBoxTelefone.Text = "";
            textBoxEndereco.Text = "";
            textBoxEmail.Text = "";
            textBoxSenha.Text = "";
            checkBoxADM.Text = "";
         }//fim do método

        
        private void buttonCADVoltar_Click(object sender, EventArgs e)
        {
            menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
            this.Hide();
        }//botão voltar

        private void cadastrarUsuario_Load(object sender, EventArgs e)
        {

        }//menu

       
    }//fim da classe

}//fim do projeto
