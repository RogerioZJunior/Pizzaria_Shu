using MySql.Data.MySqlClient;
using Pizza_Shu.Telas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Shu.DAOs
{
    internal class LogDAO
    {
            // Criando o acesso com o motor da conexão
            private conexaoBD banco = new conexaoBD();

            // Inserir log
            public void InserirLog(int usuario_codigo, string acao)
            {
                try
                {
                    // Guardando uma conexão com o MySQL
                    using (MySqlConnection conexao = banco.AbrirConexao())
                    {
                        string sql = @"INSERT INTO log_sistema
                                  (usuario_codigo, acao)
                                  VALUES
                                 (@usuario_codigo, @acao)";

                        MySqlCommand comando = new MySqlCommand(sql, conexao);

                        comando.Parameters.AddWithValue("@usuario_codigo", usuario_codigo);
                        comando.Parameters.AddWithValue("@acao", acao);

                        comando.ExecuteNonQuery();
                    }
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("Erro ao registrar log: " + erro.Message);
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro geral: " + erro.Message);
                }
            }//fim do inserir log

        public DataTable consultarLog()
        {
            DataTable tabela = new DataTable();

            try
            {
                using (MySqlConnection conexao = banco.AbrirConexao())
                {
                    string sql = @"
                    SELECT
                        l.codigo,
                        l.data_hora AS 'Data e Hora',
                        u.nome AS 'Usuário',
                        l.acao AS 'Ação'
                    FROM log_sistema l
                    INNER JOIN usuario u
                        ON l.usuario_codigo = u.codigo
                    ORDER BY l.data_hora DESC";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    MySqlDataAdapter adaptador =
                        new MySqlDataAdapter(comando);

                    adaptador.Fill(tabela);
                }
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Erro ao consultar logs: " + erro.Message);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro geral: " + erro.Message);
            }

            return tabela;
        }//fim do consultar log
    

    }//fim da classe
}//fim do projeto
