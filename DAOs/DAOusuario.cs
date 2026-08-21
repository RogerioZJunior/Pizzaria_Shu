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
    internal class DAOusuario
    {
        // Criando o acesso com o motor da conexão
        private conexaoBD banco = new conexaoBD();

        // Inserir 
        public void InserirUsuario(string nome, string telefone, string endereco, string email, string senha, bool tipo)
        {
            try
            { // Tentando fazer a conexao

                // Guardando uma conexão com o MySQL
                using (MySqlConnection conexao = banco.AbrirConexao())
                {
                    string sql = @"INSERT INTO usuario
                    (nome, telefone, endereco, email, senha, tipo)
                    VALUES
                    (@nome, @telefone, @endereco, @email, @senha, @tipo)";

                    MySqlCommand comando = new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@telefone", telefone);
                    comando.Parameters.AddWithValue("@endereco", endereco);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@senha", senha);
                    comando.Parameters.AddWithValue("@tipo", tipo);

                    comando.ExecuteNonQuery(); //Executando o comando de fato

                    MessageBox.Show("Usuário cadastrado com sucesso!");

                }
            }
            catch (MySqlException erro)// Capitura apenas erros na biblioteca MySQ  L
            {
                //Verifica se o cadastro já foi realizado 
                if (erro.Number == 1062)
                {
                    MessageBox.Show("Usuário já cadastrada!");
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
        public DataTable ConsultarUsuario()
        {
            DataTable tabela = new DataTable();

            try
            {
                using (MySqlConnection conexao = banco.AbrirConexao())
                {
                    string sql = @"SELECT codigo, nome, telefone,
                                   endereco, email, senha, tipo
                                   FROM usuario";

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
        public DataTable BuscarUsuario(int codigo)
        {
            DataTable tabela = new DataTable();

            try
            {
                using (MySqlConnection conexao = banco.AbrirConexao())
                {
                    string sql = @"SELECT * FROM usuario
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
        }//fim buscar

        // Atualizar
        public string AtualizarUsuario(
            int codigo,
            string nome,
            string telefone,
            string endereco,
            string email,
            string senha,
            bool tipo)

        {
            try
            {
                using (MySqlConnection conexao = banco.AbrirConexao())
                {

                    string sql = @"UPDATE usuario
                    SET   nome = @nome,                     
                          telefone = @telefone,
                          endereco = @endereco,
                          email = @email,
                          senha = @senha,  
                          tipo = @tipo                         
                    WHERE codigo = @codigo";

                    MySqlCommand comando =
                        new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@codigo", codigo);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@telefone", telefone);
                    comando.Parameters.AddWithValue("@endereco", endereco);
                    comando.Parameters.AddWithValue("@email", email);
                    comando.Parameters.AddWithValue("@senha", senha);
                    comando.Parameters.AddWithValue("@tipo", tipo);

                    int linhasAfetadas =
                        comando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        return "Usuário atualizado com sucesso!";
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
        }//fim atualizar


        // DELETAR
        public string DeletarUsuario(int codigo)
        {
            try
            {
                using (MySqlConnection conexao = banco.AbrirConexao())
                {
                    string sql = @"DELETE FROM usuario
                                   WHERE codigo = @codigo";

                    MySqlCommand comando =
                        new MySqlCommand(sql, conexao);

                    comando.Parameters.AddWithValue("@codigo", codigo);

                    int linhasAfetadas =
                        comando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        return "Usuário excluído com sucesso!";
                    }
                    else
                    {
                        return "Usuário não encontrado.";
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
