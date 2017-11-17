namespace Util
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }

        public Endereco(){}

        public Endereco(string logradouro, int numero, string bairro)
        {
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Bairro = bairro;
        }
    }
}