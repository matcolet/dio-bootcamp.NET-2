using System.Collections.Generic;

namespace ColecaoLINQ.Colecao
{
    public class Lista
    {
        public void imprimirLista(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine("Indice {0}, elemento: {1} ", i, lista[i]);
            }

            // foreach (var item in estados)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}