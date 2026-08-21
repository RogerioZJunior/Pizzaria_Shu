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
using MySql.Data.MySqlClient;

namespace Pizza_Shu.Telas
{
    public partial class consultarUsuario : Form
    {
        MenuPrincipal menu;
        DAOusuario Usuario;
        public consultarUsuario()
        {
            InitializeComponent();
            Usuario = new DAOusuario();
            CarregarUsuario();
        }//fim do construtor

        public void CarregarUsuario()
        {
            DataTable tabela = Usuario.ConsultarUsuario();

            dataGridView1.DataSource = tabela;

            // Ajustes visuais
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }//carregar usuários

        private void consultarUsuario_Load(object sender, EventArgs e)
        {

        }//menu

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//data grid view

        private void buttonCONVoltar_Click(object sender, EventArgs e)
        {
            menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
            this.Hide();
        }//botão voltar
    }//fim da classe
}//fim do projeto
