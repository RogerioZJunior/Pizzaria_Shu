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
        LogDAO Log;
        MenuPrincipal menu;
        DAOusuario Usuario;
        private int usuarioCodigo;  
        public Login(int codigoUsuario)
        {
            InitializeComponent();
            Usuario = new DAOusuario();
            Log = new LogDAO();
            usuarioCodigo = codigoUsuario;
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

                    // Pega o código do usuário que fez login
                    int codigoUsuario = Convert.ToInt32(tabela.Rows[0]["codigo"]);

                    // Cria o MenuPrincipal
                    // ERRO ->  menu = new MenuPrincipal();

                    // Passa o código do usuário para o MenuPrincipal
                    menu.UsuarioCodigo = codigoUsuario;

                    this.Hide();
                    menu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuário sem permissão.");
                }

                Log.InserirLog(
                   usuarioCodigo,
                   "Fez Login: " + email
                   );

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
