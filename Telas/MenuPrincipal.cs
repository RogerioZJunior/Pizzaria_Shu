using MySql.Data.MySqlClient;
using Pizza_Shu.DAOs;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pizza_Shu
{
    public partial class MenuPrincipal : Form
    {
        public int UsuarioCodigo { get; set; }//pega o codigo do usuário atual
        LogDAO                Log;
        cadastrarUsuario      cad;
        consultarUsuario      con;
        atualizarUsuario      atu;
        excluirUsuario        exc;
        cadastrarProduto   cadPro;
        consultarProduto   conPro;
        atualizarProduto   atuPro;
        excluirProduto     excPro;
        Pedido             pedido;
        Evento             evento;
        Login               login;
        log                   log;

        public MenuPrincipal(int codigoUsuario)
        {
            InitializeComponent();
            Log = new LogDAO();
            UsuarioCodigo = codigoUsuario;
        }//fim do construtor

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }//menu

        private void buttonCAD_Click(object sender, EventArgs e)
        {
            cadastrarUsuario cad = new cadastrarUsuario(UsuarioCodigo);
            this.Hide();
            cad.ShowDialog();
            this.Show();
        }//botão cadastrar

        private void buttonCON_Click(object sender, EventArgs e)
        {
            consultarUsuario con = new consultarUsuario(UsuarioCodigo);
            this.Hide();
            con.ShowDialog();
            this.Show();
        }//botão consultar

        private void buttonATU_Click(object sender, EventArgs e)
        {
            atualizarUsuario tela = new atualizarUsuario(UsuarioCodigo);
            this.Hide();
            tela.ShowDialog();
            this.Show();
        }//botão atualizar

        private void buttonEXC_Click(object sender, EventArgs e)
        {
            excluirUsuario exc = new excluirUsuario(UsuarioCodigo);
            this.Hide();
            exc.ShowDialog();
            this.Show();
        }//botão excluir

        private void buttonCADProduto_Click(object sender, EventArgs e)
        {
            cadastrarProduto cadPro = new cadastrarProduto(UsuarioCodigo);
            this.Hide();
            cadPro.ShowDialog();
            this.Show();
        }//botão cadastrar produto

        private void buttonConProduto_Click(object sender, EventArgs e)
        {
            consultarProduto conPro = new consultarProduto(UsuarioCodigo);
            this.Hide();
            conPro.ShowDialog();
            this.Show();
        }//botão consultar produto

        private void buttonATUProduto_Click(object sender, EventArgs e)
        {
            atualizarProduto atuPro = new atualizarProduto(UsuarioCodigo);
            this.Hide();
            atuPro.ShowDialog();
            this.Show();
        }//botão atualizar produto

        private void buttonEXCProduto_Click(object sender, EventArgs e)
        {
            excluirProduto excPro = new excluirProduto(UsuarioCodigo);
            this.Hide();
            excPro.ShowDialog();
            this.Show();
        }//botão excluir produto

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(UsuarioCodigo);
            this.Hide();
            pedido.ShowDialog();
            this.Show();    
        }//botão pedido

        private void buttonEventos_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento(UsuarioCodigo);
            this.Hide();
            evento.ShowDialog();
            this.Show();
        }//botão evento

        private void buttonLogs_Click(object sender, EventArgs e)
        {
            log log = new log(UsuarioCodigo);
            this.Hide();
            log.ShowDialog();
            this.Show();
        }//botão logs
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Log.InserirLog(
            UsuarioCodigo,
            "Fez Logout" 
            );

            this.Close();
        }//botão sair

        private void label2_Click(object sender, EventArgs e)
        {

        }//

    
    }//fim da classe
}//fim do projeto
