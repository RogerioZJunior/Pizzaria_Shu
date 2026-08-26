using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pizza_Shu.Telas
{
    public partial class Login : Form
    {
        MenuPrincipal menu;
        DAOusuario Usuario;
        public Login()
        {
            InitializeComponent();
            Usuario = new DAOusuario();
        }//fim do construtor

        private void Login_Load(object sender, EventArgs e)
        {

        }//menu

        private void textBoxLoginEmail_TextChanged(object sender, EventArgs e)
        {

        }//text box email

        private void textBoxLoginSenha_TextChanged(object sender, EventArgs e)
        {

        }//text box senha

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            if (textBoxLoginEmail.Text == "" || textBoxLoginSenha.Text == "")
            {
                MessageBox.Show("Preencha os campos");
            }
            else
            {

                string email = textBoxLoginEmail.Text.Trim();
                string senha = textBoxLoginSenha.Text;

                DataTable tabela = Usuario.Login(email, senha);

                if (tabela.Rows.Count > 0)
                {
                    MessageBox.Show("Login realizado com sucesso!");

                    menu = new MenuPrincipal();
                    this.Hide();
                    menu.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("usuário sem permissão.");
                }
                LimparCampos();
            }
        }//botão entrar

        //Limpar os campos
        public void LimparCampos()
        {
            textBoxLoginEmail.Text = "";
            textBoxLoginSenha.Text = "";
        }//fim do método

        private void buttonLoginSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }//botão sair

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }//logo
    }//fim da classe
}//fim do projeto
