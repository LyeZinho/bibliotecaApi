namespace bibliotecaApi
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Descricao { get; set; }
        public int isbn { get; set; }
        public string Editora { get; set; }
        public int Ano { get; set; }
        public string Urlimagem { get; set; }

        public Livro()
        {
            this.Id = 0;
            this.Titulo = "";
            this.Autor = "";
            this.Descricao = "";
            this.isbn = 0;
            this.Editora = "";
            this.Ano = 0;
            this.Urlimagem = "";
        }

        public Livro(int id, string titulo, string autor, string descricao, int isbn, string editora, int ano, string urlimagem)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Descricao = descricao;
            this.isbn = isbn;
            this.Editora = editora;
            this.Ano = ano;
            this.Urlimagem = urlimagem;
        }
    }
}
