using MySql.Data.MySqlClient;
using Pizza_Shu.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Shu
{
    public partial class MenuPrincipal : Form
    {
        cadastrarUsuario cad;
        consultarUsuario con;
        atualizarUsuario atu;
        excluirUsuario   exc;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }//menu

        private void buttonCAD_Click(object sender, EventArgs e)
        {
            cad = new cadastrarUsuario();
            this.Hide();
            cad.ShowDialog();
            this.Close();
        }//botão cadastrar

        private void buttonCON_Click(object sender, EventArgs e)
        {
            con = new consultarUsuario();
            this.Hide();
            con.ShowDialog();
            this.Close();
        }//botão consultar

        private void buttonATU_Click(object sender, EventArgs e)
        {
            atu = new atualizarUsuario();
            this.Hide();
            atu.ShowDialog();
            this.Close();
        }//botão atualizar

        private void buttonEXC_Click(object sender, EventArgs e)
        {
            exc = new excluirUsuario();
            this.Hide();
            exc.ShowDialog();
            this.Close();
        }//botão excluir

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }//botão sair

        private void label2_Click(object sender, EventArgs e)
        {

        }//
    }//fim da classe
}//fim do projeto
