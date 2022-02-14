namespace ExPilaresOO.POO
{
    public abstract class Conta
    {
        protected double saldo;
        public abstract void Creditar(double valor);
        public abstract void Sacar(double valor);

        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo é R$ " + saldo);
        }
    }
}