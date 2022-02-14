namespace ExPilaresOO.POO
{
    public class ContaCorrente : Conta
    {
        private double extrato; 
        public override void Creditar(double valor)
        {
            base.saldo += valor;
            System.Console.WriteLine($"Valor creditado de R$ {valor}");
        }

        public override void Sacar(double valor)
        {
            extrato = base.saldo - valor; 
            if (extrato > 0)
            {
                base.saldo -= valor;
                 System.Console.WriteLine($"Saque realizado no valor de R$ {valor}");
            }
            else
            {
                System.Console.WriteLine($"Saldo insuficiente para o saque de R$ {valor}");
            }
        }

    }
}