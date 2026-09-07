using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Pizza_Shu.Telas;
using System.Data;
using System.Windows.Forms;

namespace Pizza_Shu
{
    internal class DAORelatorio
    {
        // Criando o acesso com o motor da conexão
        private conexaoBD banco = new conexaoBD();

        public DataTable RelatorioPedidos()
        {
            DataTable tabela = new DataTable();

            try
            {
                using (MySqlConnection conexao = banco.AbrirConexao())
                {
                    string sql = @"
                    SELECT
                        COUNT(*) AS total_pedidos,

                        SUM(CASE
                            WHEN statuss = 'Entregue' THEN 1
                            ELSE 0
                        END) AS pedidos_entregues,

                        COALESCE(SUM(CASE
                            WHEN statuss = 'Entregue' THEN valor
                            ELSE 0
                        END), 0) AS faturamento,

                        SUM(CASE
                            WHEN statuss = 'Cancelado' THEN 1
                            ELSE 0
                        END) AS pedidos_cancelados

                    FROM pedido";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(sql, conexao);

                    adapter.Fill(tabela);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                    "Erro ao consultar relatório: " + erro.Message);
            }

            return tabela;
        }// relatório pedido

        public DataTable RelatorioEventos()
        {
            DataTable tabela = new DataTable();

            try
            {
                using (MySqlConnection conexao = banco.AbrirConexao())
                {
                    string sql = @"
                    SELECT
                        COUNT(*) AS total_eventos,

                        COALESCE(SUM(
                            CASE
                                WHEN statuss = 'Concluido' THEN 1
                                ELSE 0
                            END
                        ), 0) AS eventos_concluidos,

                        COALESCE(SUM(orcamento), 0) AS orcamento_total,

                        COALESCE(SUM(
                            CASE
                                WHEN statuss = 'Cancelado' THEN 1
                                ELSE 0
                            END
                        ), 0) AS eventos_cancelados

                    FROM evento";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(sql, conexao);

                    adapter.Fill(tabela);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(
                    "Erro ao consultar relatório de eventos: "
                    + erro.Message);
            }

            return tabela;
        }// relatorios de eventos

    }//fim da classe

}//fim do projeto 
