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
        public Login()
        {
            InitializeComponent();
            Usuario = new DAOusuario();
            Log = new LogDAO();
        }
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
                return;
            }

            string email = textBoxLoginEmail.Text.Trim();
            string senha = textBoxLoginSenha.Text;

            DataTable tabela = Usuario.Login(email, senha);

            if (tabela.Rows.Count > 0)
            {
                int codigoUsuario = Convert.ToInt32(tabela.Rows[0]["codigo"]);

                //MessageBox.Show("Código do usuário: " + codigoUsuario);   

                // Guarda o usuário que acabou de entrar
                usuarioCodigo = codigoUsuario;

                // Registra LOGIN
                Log.InserirLog(
                    codigoUsuario,
                    "Fez Login: " + email
                );

                MessageBox.Show("Login realizado com sucesso!");

                // Passa o código para o MenuPrincipal
                menu = new MenuPrincipal(codigoUsuario);

                this.Hide();

                menu.ShowDialog();

                this.Show();
            }
            else
            {
                MessageBox.Show("Usuário sem permissão.");
            }

            LimparCampos();
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
