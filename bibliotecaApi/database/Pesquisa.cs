using MySql.Data.MySqlClient;
using Dapper;

namespace bibliotecaApi.database
{
    public class Pesquisa
    {
        protected string connString()
        {
            string conn = "server=localhost;database=bibliotecaapi;userid=root;password=123456789;";
            return conn;
        }

        //Estrutura basica
        public dynamic GetAllUsers()
        {
            //Captura de execção
            try
            {
                //Conexão bd mysql
                using (MySqlConnection conn = new MySqlConnection(connString()))
                {
                    //Pesquisa de todos os usuarios os usuarios 
                    //Variavel query do tipo dynamic recebe uma lista de usuarios do tipo Usuario 
                    var query = conn.Query<Usuario>("SELECT * FROM usuarios ");
                    return query;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "";
            }
        }
        
        public dynamic GetAllBooks()
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString()))
                {
                    IEnumerable<Livro>? query = conn.Query<Livro>("SELECT * FROM livros");
                    return query;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "";
            }
            
        }

        public dynamic GetAllRatings()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString()))
                {
                    dynamic query = conn.Query<Avaliacao>("SELECT * FROM avaliacoes");
                    return query;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "";
            }
        }

        public dynamic GetUsuario(string nomeusuario)
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString()))
                {
                    dynamic query = conn.Query<Usuario>(
                        "SELECT * FROM usuarios WHERE nome = @nome",
                        new{ nome = nomeusuario } //Tipo anonimo para os parametros
                    );
                    return query;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "";
            }
        }

        public dynamic GetLivro(string titulolivro)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString()))
                {
                    dynamic query = conn.Query<Livro>(
                    "SELECT * FROM livros WHERE titulo = @titulo",
                    new {titulo = titulolivro}
                    );
                    return query;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "";
            }
        }

        public dynamic GetLivroById(int idlivro)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString()))
                {
                    dynamic query = conn.Query<Livro>(
                    "SELECT * FROM livros WHERE id = @id",
                    new { id = idlivro }
                    );
                    return query;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "";
            }
        }

        public dynamic GetAvaliacao(int idusuario)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString()))
                {
                    dynamic query = conn.Query<Avaliacao>(
                    "SELECT * FROM avaliacoes WHERE idusuario = @idusuario",
                    new { idusuario = idusuario }
                    );
                    return query;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "";
            }
        }

        public dynamic GetBookByGenre(string generolivro)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connString()))
                {
                    dynamic query = conn.Query<Livro>(
                    "SELECT * FROM livros WHERE genero = @genero",
                    new { genero = generolivro }
                    );
                    return query;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "";
            }
        }
    }
}
