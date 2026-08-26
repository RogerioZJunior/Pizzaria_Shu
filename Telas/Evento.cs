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


        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {

        }//texbox codigo

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }//comboBox atualizar

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
                DataTable tabela = dao.BuscarEvento(codigo);

                if (tabela.Rows.Count > 0)
                {
                    DataRow linha = tabela.Rows[0];

                    comboBox1.Text = linha["statuss"].ToString();

                }
                else
                {
                    MessageBox.Show("Evento não encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar: " + ex.Message);
            }
        }//botão selecioanar

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxCodigo.Text, out int codigo))
            {
                MessageBox.Show("Código inválido!");
                return;
            }

            string resultado = Usuario.AtualizarEvento(
                codigo,
                 comboBox1.Text
            );

            CarregarEvento();

            MessageBox.Show(resultado);

            textBoxCodigo.Clear();
        }// botão atualizar

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
