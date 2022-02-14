namespace ExConstrutores.Modelos
{
    public class CalculoEvent
    {
        public delegate void DelegateCalculo();
        public static event DelegateCalculo ?EventCalculo;

        public static void Somar(int x, int y)
        {
            if (EventCalculo != null)
            {
                System.Console.WriteLine($"Adição: {x + y}");
                EventCalculo(); 
            }
            else
            {
                System.Console.WriteLine("Nenhum evento!");
            }


        }
        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtração: {x + y}");
        }

    }
}