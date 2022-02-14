namespace ExConstrutores.Modelos
{
    public class Aluno : Pessoa
    {
        // Pessoa tem um construtor implementado, a herança precisa respeitar a classe mãe 
        public Aluno(string nome, string sobrenome, string disciplina ) : base(nome, sobrenome)
        {
            System.Console.WriteLine("Construtor classe Aluno");
        }
    }
}