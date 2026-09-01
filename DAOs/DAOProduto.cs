using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Pizza_Shu.Telas;

namespace Pizza_Shu.DAOs
{
    internal class DAOProduto
    {
        // Criando o acesso com o motor da conexão
        private conexaoBD banco = new conexaoBD();

        // Inserir 
        public void InserirProduto(string nome, string descricao, decimal preco, int quantidade, string categoria)
        {
            try
            { // Tentando fazer a conexao

                // Guardando uma conexão com o MySQL
                using (MySqlConnection conexao = banco.AbrirConexao())
                {
                    string sql = @"INSERT INTO produto
                    (nome, descricao, preco, quantidade, categoria)
                    VALUES
                    (@nome, @descricao, @preco, @quantidade, @categoria)";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@descricao", descricao);
                    comando.Parameters.AddWithValue("@preco", preco);
                    comando.Parameters.AddWithValue("@quantidade", quantidade);
                    comando.Parameters.AddWithValue("@categoria", categoria);

                    comando.ExecuteNonQuery(); //Executando o comando de fato

                    MessageBox.Show("Produto cadastrado com sucesso!");

                }
            }
            catch (MySqlException erro)// Capitura apenas erros na biblioteca MySQ  L
            {
                //Verifica se o cadastro já foi realizado 
                if (erro.Number == 1062)
                {
                    MessageBox.Show("produto já cadastrado!");
                }
                else//Se não for um cadastro de uma meta já existente ele mostra qual erro é
                {
                    MessageBox.Show("Erro no banco: " + erro.Message);
                }
            }
            catch (Exception erro)//Se não for um erro do MySQL ele ira mostrar qualquer outro erro
            {
                MessageBox.Show("Erro geral: " + erro.Message);
            }
        }//fim do inserir    


        // Consultar
        public DataTable ConsultarProduto()
        {
            DataTable tabela = new DataTable();

            try
            {
                using (MySqlConnection conexao = banco.AbrirConexao())
                {
                    string sql = @"SELECT codigo, nome, descricao,
                                   preco, quantidade, categoria
                                   FROM produto";

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(sql, conexao);

                    adapter.Fill(tabela);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao consultar: " + erro.Message);
            }

            return tabela;
        }//fim consultar


        // Buscar
        public DataTable BuscarProduto(int codigo)
        {
            DataTable tabela = new DataTable();

            try
            {
                using (MySqlConnection conexao = banco.AbrirConexao())
                {
                    string sql = @"SELECT * FROM produto
                                   WHERE codigo = @codigo";

                    MySqlCommand comando =
                        new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@codigo", codigo);

                    MySqlDataAdapter adapter =
                        new MySqlDataAdapter(comando);

                    adapter.Fill(tabela);
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao buscar: " + erro.Message);
            }

            return tabela;
        }//fim buscar produto


        // Atualizar
        public string AtualizarProduto(
            int    codigo,
            string nome,
            string descricao,
            decimal    preco,
            int    quantidade,
            string categoria)

        {
            try
            {
                using (MySqlConnection conexao = banco.AbrirConexao())
                {

                    string sql = @"UPDATE produto
                    SET   nome       = @nome,                     
                          descricao  = @descricao,
                          preco      = @preco,
                          quantidade = @quantidade,
                          categoria  = @categoria                       
                    WHERE codigo = @codigo";

                    MySqlCommand comando =
                        new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@codigo", codigo);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@descricao", descricao);
                    comando.Parameters.AddWithValue("@preco", preco);
                    comando.Parameters.AddWithValue("@quantidade", quantidade);
                    comando.Parameters.AddWithValue("@categoria", categoria);

                    int linhasAfetadas =
                        comando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        return "Produto atualizado com sucesso!";
                    }
                    else
                    {
                        return "Nenhuma alteração foi feita.";
                    }
                }
            }
            catch (Exception erro)
            {
                return "Erro ao atualizar: " + erro.Message;
            }
        }//fim atualizar Produto

        // DELETAR
        public string DeletarProduto(int codigo)
        {
            try
            {
                using (MySqlConnection conexao = banco.AbrirConexao())
                {
                    string sql = @"DELETE FROM produto
                                   WHERE codigo = @codigo";

                    MySqlCommand comando =
                        new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@codigo", codigo);

                    int linhasAfetadas =
                        comando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        return "Produto excluído com sucesso!";
                    }
                    else
                    {
                        return "Produto não encontrado.";
                    }
                }
            }
            catch (Exception erro)
            {
                return "Erro ao excluir: " + erro.Message;
            }
        }//fim deletar




    }//fim da classe

}//fim do projeto
