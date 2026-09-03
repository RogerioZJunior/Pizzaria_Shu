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
    public partial class consultarProduto : Form
    {
        LogDAO         Log;
        DAOProduto Produto;
        private int usuarioCodigo;
        public consultarProduto(int codigoUsuario)
        {
            InitializeComponent();
            Produto = new DAOProduto();
            Log = new LogDAO();
            usuarioCodigo = codigoUsuario;
            CarregarProduto();
        }//fim do construtor

        public void CarregarProduto()
        {
            DataTable tabela = Produto.ConsultarProduto();

            dataGridView1.DataSource = tabela;

            // Ajustes visuais
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            Log.InserirLog(
                usuarioCodigo,
                "Consultou Produtos "
            );
        }//carregar produtos


        private void consultarProduto_Load(object sender, EventArgs e)
        {

        }//menu

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//data grid view

        private void buttonCONVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//botão voltar

        private void label1_Click(object sender, EventArgs e)
        {

        }//
    }//fim da classe
}//fim do projeto
