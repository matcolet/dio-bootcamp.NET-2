namespace ExPilaresOO.POO
{
    public class EncRetangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;

        public void DefinirMedidas(double comprimento, double largura)
        {
            if (comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                valido = true;
            }
            else
            {
                System.Console.WriteLine("Valores inválidos");
            }
        }

        public double ObterAreaRet()
        {
            if (valido)
            {
                return comprimento * largura;
            }
            else
            {
                System.Console.WriteLine("Preencha valores válidos");
                return 0;
            }
        }
    }
}