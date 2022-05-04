namespace bibliotecaApi
{
    public class Avaliacao : Usuario
    {
        public int IdAvaliacao { get; set; }
        public int Valor { get; set; }
        public int IdUsuario { get; set; }
        public int IdLivro { get; set; }
        
        public Avaliacao()
        {
            this.Id = 0;
            this.Valor = 0;
            this.IdLivro = 0;
            this.IdUsuario = 0;
        }
        
        public Avaliacao(int id, int valor, int idlivro, int idusuario)
        {
            this.Id = id;
            this.Valor = valor;
            this.IdLivro = idlivro;
            this.IdUsuario = idusuario;
        }
    }
}
