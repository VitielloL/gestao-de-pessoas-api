namespace GestaoPessoasApi.Models.Pessoa
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Documento { get; private set; }

        public Pessoa(string nome, string documento)
        {
            this.Nome = nome;
            this.Documento = documento;
        }

        public void AtualizarNome (string nome) => this.Nome = nome;
        public void AtualizarDocumento (string documento) => this.Documento = documento;
    }
}
