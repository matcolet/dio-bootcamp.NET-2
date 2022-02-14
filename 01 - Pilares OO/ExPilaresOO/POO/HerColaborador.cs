namespace ExPilaresOO.POO
{
    public class HerColaborador : AbsPessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome +" "+ SobreNome}, tenho {Idade} anos e ganho R$: {Salario} reais");
        }
    }
}