
namespace ListaClass
{
    public class Aluno
    {
        public string Nome {get; set;}
        public int Matricula {get; set;}
        public string Endereco {get; set;}
        public string Telefone {get; set;}

        public Aluno( int matricula, string nome, string endereco, string telefone)
        {
            Matricula = matricula;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }
    }
}