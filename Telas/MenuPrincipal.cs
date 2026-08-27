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
        LogDAO Log;
        cadastrarUsuario  cad;
        consultarUsuario  con;
        atualizarUsuario  atu;
        excluirUsuario    exc;
        Pedido         pedido;
        Evento         evento;
        Login           login;
        log               log;
        private int usuarioCodigo;
        public MenuPrincipal(int codigoUsuario)
        {
            InitializeComponent();
            Log = new LogDAO();
            usuarioCodigo = codigoUsuario;
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
            log = new log();
            this.Hide();
            log.ShowDialog();
            this.Hide();
        }//botão logs
        private void buttonSair_Click(object sender, EventArgs e)
        {
            Login login = new Login(UsuarioCodigo);
            this.Hide();
            login.ShowDialog();

            Log.InserirLog(
                 usuarioCodigo,
                 "Fez Logout " 
                 );

            this.Show();
        }//botão sair

        private void label2_Click(object sender, EventArgs e)
        {

        }//

    }//fim da classe
}//fim do projeto
