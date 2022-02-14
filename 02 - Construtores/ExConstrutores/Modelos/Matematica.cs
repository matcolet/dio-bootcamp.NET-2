namespace ExConstrutores.Modelos
{
    public class Matematica
    {
        public int x { get; set; }
        public int y { get; set; }

        public Matematica(int x, int y)
        {
            this.x = x; 
            this.y = y;

            CalculoEvent.EventCalculo += EventHandler; 
        }

        public void Somar()
        {
            CalculoEvent.Somar(x,y); 
        }
        public void EventHandler()
        {
            System.Console.WriteLine("Metodo Executado");
        }
    }
}