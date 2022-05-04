namespace bibliotecaApi.Controllers
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
    }
}
