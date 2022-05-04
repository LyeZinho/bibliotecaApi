namespace bibliotecaApi
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Usuario()
        {
            this.Id = 0;
            this.Nome = "";
            this.Email = "";
        }

        public Usuario(int id, string nome, string email)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
        }
    }
}
