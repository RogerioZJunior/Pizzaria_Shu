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
    public partial class Pedido : Form
    {
        MenuPrincipal menu;
        DAOusuario Usuario;
        public Pedido()
        {
            InitializeComponent();
            Usuario = new DAOusuario();
            CarregarPedido();
        }//fim do construtor

        private void Pedido_Load(object sender, EventArgs e)
        {

        }//menu

        public void CarregarPedido()
         {
            DataTable tabela = Usuario.ConsultarPedido();

             dataGridView1.DataSource = tabela;

             //Ajustes visuais
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//data grid view
        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }//textbox codigo

        private void buttonSelecionar_Click(object sender, EventArgs e)
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
                DataTable tabela = dao.BuscarPedido(codigo);

                if (tabela.Rows.Count > 0)
                {
                    DataRow linha = tabela.Rows[0];

                    comboBox1.Text = linha["statuss"].ToString();
               
                }
                else
                {
                    MessageBox.Show("Pedido não encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar: " + ex.Message);
            }
        }//botão selecionar

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }// comboBox atualizar

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxCodigo.Text, out int codigo))
            {
                MessageBox.Show("Código inválido!");
                return;
            }

            string resultado = Usuario.AtualizarPedido(
                codigo,
                 comboBox1.Text
            );

            CarregarPedido();

            MessageBox.Show(resultado);

            textBoxCodigo.Clear();
        
        }//botão atualizar

        private void buttonPedidoVoltar_Click(object sender, EventArgs e)
        {
            menu = new MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
            this.Hide();
        }// botão voltar

    }//fim da classe
}//fim do projeto
