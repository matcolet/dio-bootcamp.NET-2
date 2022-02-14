using System;
namespace ColecaoLINQ.Ordena
{
    public class ExArray
    {
        // passando o array por referencia, significa que não preciso retornar
        public void BubbleSortV1(ref int[] array)
        {
            int aux = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        aux = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = aux;
                    }
                }
            }
        }

        public void BubbleSortV2(ref int[] array)
        {

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int aux = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = aux;
                    }
                }
            }
        }


        public void ImprimiArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write(array[i] + " ");
            }
            System.Console.WriteLine();
        }

        public void ImprimiJoin(int[] array)
        {
            var linha = string.Join(" - ", array);
            System.Console.WriteLine(linha);
        }


        public void OrdenarClasseArray(ref int[] array)
        {
            Array.Sort(array);
        }

        public void copiaArray(ref int[] array, ref int[] arrayDest)
        {
            Array.Copy(array, arrayDest, array.Length);
        }

        public bool encontraElemento(int[] array, int valor)
        {
            // elemento é uma variavel | elemento vai varrer o elemento e compara com o valor passado 
            return Array.Exists(array, elemento => elemento == valor);
            //return Array.Exists(array, elemento => elemento >= valor );  
        }

        public bool condicaoProcura(int[] array, int valor)
        {
            return Array.TrueForAll(array, elemento => elemento > valor);

        }

        public int obtenPosicao(int[] array, int valor)
        {
            //return Array.IndexOf(array, valor);
             return Array.FindIndex(array, elemento => elemento == valor);
            // find = retorna sua primeira ocorencia 
            // all = retorna coleção com uma condição
            // index = retorna a posição que o elemento se encontra
            // last e last ind = sua ultima ocorrencia e seu indx
        }

        public void redimensionarArray(ref int[] array, int newTam)
        {
            Array.Resize(ref array, newTam); 
        }

        public string[] convertArrayIntToString( int[] array)
        {
            return Array.ConvertAll(array, elemento => elemento.ToString()); 
        }

    }
}