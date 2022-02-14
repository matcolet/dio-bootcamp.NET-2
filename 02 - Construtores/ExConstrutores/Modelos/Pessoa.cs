namespace ExConstrutores.Modelos
{
    public class Pessoa
    {

        private readonly string nome; 
        private readonly string sobreNome;

        // 
        // Resumo: 
        // Um construtor não possui um retorno 
        // Um construtor padrão é sempre definido quando não declaramos nenhum para sua classe 
        // Uma classe pode ter mais de um construtor 
        //
        // public Pessoa()
        // {   
        //     nome = string.Empty; 
        //     sobreNome = string.Empty; 

        // } 
        public Pessoa(string nome, string sobreNome)
        {
            this.nome = nome; 
            this.sobreNome = sobreNome; 
            System.Console.WriteLine("Construtor classe Pessoa");
        }

        public void Apresentar(){
            System.Console.WriteLine($" olá meu nome é {nome} e meu sobrenome é {sobreNome}");
        }

    }

}