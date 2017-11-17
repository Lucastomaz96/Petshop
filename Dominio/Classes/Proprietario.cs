using Util;

namespace Dominio.Classes
{
    public class Proprietario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public Endereco End { get; set; }
        public string Telefone { get; set; }

        public Proprietario()
        {

        }

        public Proprietario(int Id, string Nome, string Email, string CPF, Endereco End, string Telefone)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Email = Email;
            this.CPF = CPF;
            this.End = End;
            this.Telefone = Telefone;

        }
        
    }
}