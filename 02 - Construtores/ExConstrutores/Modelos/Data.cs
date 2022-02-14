namespace ExConstrutores.Modelos
{
    public class Data
    {
        private int mes;
        private bool mesValido;

        //propriedade com validação
        public int Mes
        {
            get
            {
                return this.mes;
            }
            set
            {
                this.mes = value;
                if (value > 0 && value < 13)
                {
                    this.mesValido = true;
                }

            }
        }


        public void ApresentarMes()
        {
            if (this.mesValido)
            {
                System.Console.WriteLine($"Mês {this.mes}");
            }
            else
            {
                System.Console.WriteLine($"Mês {this.mes} inválido!");
            }
        }
    }
}