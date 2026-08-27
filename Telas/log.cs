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
    public partial class log : Form
    {
        LogDAO         Log;
        DAOusuario Usuario;

        private int usuarioCodigo;
        public log(int codigoUsuario)
        {
            InitializeComponent();

            Log = new LogDAO();
            Usuario = new DAOusuario();

            usuarioCodigo = codigoUsuario;

            CarregarLog();
        }//fim do construtor

        private void log_Load(object sender, EventArgs e)
        {

        }//menu

        public void CarregarLog()
        {
            DataTable tabela = Log.consultarLog();

            dataGridView1.DataSource = tabela;

            // Ajustes visuais
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }//carregar usuários


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }// data grid view


        private void buttonLogVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }// botão voltar
    }//fim da classe
}//fim do projeto
