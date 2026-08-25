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

namespace Pizza_Shu.Telas
{
    public partial class Evento : Form
    {
        MenuPrincipal menu;
        DAOusuario Usuario;
        public Evento()
        {
            InitializeComponent();
            Usuario = new DAOusuario();
            CarregarEvento();
        }//fim do construtor

        public void CarregarEvento()
        {
            DataTable tabela = Usuario.ConsultarEvento();

            dataGridView1.DataSource = tabela;

            // Ajustes visuais
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }//carregar evento

        private void Evento_Load(object sender, EventArgs e)
        {

        }//menu

        private void buttonEVEVoltar_Click(object sender, EventArgs e)
        {
             menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
            this.Hide();
        }//botão menu
    }//fim da classe
}//fim do projeto
