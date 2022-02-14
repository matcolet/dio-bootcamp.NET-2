namespace ExPilaresOO.POO
{
    public class AbsPessoa
    {
        public string? Nome { get; set; }
        public string? SobreNome { get; set; }
        public int Idade { get; set; }
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome +" "+ SobreNome} e tenho {Idade} anos");
        }
    }
}