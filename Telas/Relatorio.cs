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
using Pizza_Shu.DAOs;

namespace Pizza_Shu
{
    public partial class Relatorio : Form
    {
        LogDAO Log;
        DAORelatorio relatorio;
        private int usuarioCodigo;
        public Relatorio(int codigoUsuario)
        {
            InitializeComponent();
            relatorio = new DAORelatorio();
            Log = new LogDAO();
            usuarioCodigo = codigoUsuario;
            CarregarRelatorioPedido();
            CarregarRelatorioEvento();
        }//fim do construtor

        private void CarregarRelatorioPedido()
        {
            DataTable tabela = relatorio.RelatorioPedidos();

            if (tabela.Rows.Count > 0)
            {
                DataRow linha = tabela.Rows[0];

                labelnNumeroTotalPedidos.Text =
                    linha["total_pedidos"].ToString();

                labelNumeroPedidoEntregue.Text =
                    linha["pedidos_entregues"].ToString();

                labelNumeroFaturamento.Text =
                    Convert.ToDecimal(linha["faturamento"]).ToString("C2");

                labelNumeroPedidoCancelado.Text =
                    linha["pedidos_cancelados"].ToString();
            }
        }// carregar relatórios de pedidos

        private void CarregarRelatorioEvento()
        {
            DataTable tabela = relatorio.RelatorioEventos();

            if (tabela.Rows.Count > 0)
            {
                DataRow linha = tabela.Rows[0];

                labelTotalEvento.Text =
                    linha["total_eventos"].ToString();

                labelEventoConcluido.Text =
                    linha["eventos_concluidos"].ToString();

                labelNumeroTotalDeOrcamento.Text =
                    Convert.ToDecimal(linha["orcamento_total"]).ToString("C2");

                labelNumeroEventosCancelado.Text =
                    linha["eventos_cancelados"].ToString();
            }
        }//carregar relatorios eventos

        private void Relatorio_Load(object sender, EventArgs e)
        {
        }//menu

        private void panelTotalPedidos_Paint(object sender, PaintEventArgs e)
        {
        }//painel total pedidos

        private void panelPedidoEntregues_Paint(object sender, PaintEventArgs e)
        {
        }//painel pedidos entregues

        private void panelFaturamento_Paint(object sender, PaintEventArgs e)
        {
        }//painel faturamento

        private void panelPedidosCancelados_Paint(object sender, PaintEventArgs e)
        {
        }//painel pedidos cancelados

        private void labelnNumeroTotalPedidos_Click(object sender, EventArgs e)
        {
        }// label Numero Total de Pedidos

        private void labelNumeroPedidoEntregue_Click(object sender, EventArgs e)
        {
        }// label Numero de Pedidos entregues

        private void labelNumeroFaturamento_Click(object sender, EventArgs e)
        {
        }// label faturamento

        private void labelNumeroPedidoCancelado_Click(object sender, EventArgs e)
        {
        }// label Numero de Pedidos cancelados

        private void panelEventosTotais_Paint(object sender, PaintEventArgs e)
        {
        }//painel total de eventos

        private void panelEventosConcluidos_Paint(object sender, PaintEventArgs e)
        {
        }//painel eventos concluidos

        private void panelEventoCancelado_Paint(object sender, PaintEventArgs e)
        {
        }//painel eventos cancelados

        private void panelOrcamentoTotal_Paint(object sender, PaintEventArgs e)
        {
        }//painel orçamento  total

        private void labelTotalEvento_Click(object sender, EventArgs e)
        {
        }// label total evento

        private void labelEventoConcluido_Click(object sender, EventArgs e)
        {
        }// label eventos concluidos

        private void labelNumeroEventosCancelado_Click(object sender, EventArgs e)
        {
        }// label eventos cancelados

        private void labelNumeroTotalDeOrcamento_Click(object sender, EventArgs e)
        {
        }// label total de orçamento

        private void buttonSairRelatorio_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }//botão voltar

    

    }//fim da classe
}//fim do projeto
