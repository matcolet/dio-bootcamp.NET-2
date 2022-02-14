// See https://aka.ms/new-console-template for more information
using ColecaoLINQ.Colecao;
using ColecaoLINQ.Ordena;
using System.Collections.Generic;

/*----------------------LINQ--------------------------------*/

int[] arrInteir = new int[10]  { 12,1,24,56,32,4,23,4,8,12 };


//Query syntax: 
var paresQue = 
    from num in arrInteir
    where num % 2 == 0
    orderby num
    select num; 

//Method syntax:
var paresMet = arrInteir.Where( x => x % 2 == 0).OrderBy(x => x).ToList(); 

System.Console.WriteLine("Numeros pares Query: " + string.Join("-", paresQue));
System.Console.WriteLine("Numeros pares Method: " + string.Join("-", paresMet));

System.Console.WriteLine(" Valor mínimo array: " + arrInteir.Min()); 
System.Console.WriteLine(" Valor máximo array: " + arrInteir.Max()); 
System.Console.WriteLine(" Valor médio array: " + arrInteir.Average()); 

System.Console.WriteLine(" Somatório valores do array: " + arrInteir.Sum()); 
System.Console.WriteLine($"array sem elementos duplicados: {string.Join("-", arrInteir.Distinct().ToArray())}" ); 


/*----------------------Dicionário--------------------------------*/

// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("RS", "Rio Grande do Sul");
// estados.Add("RJ", "Rio de Janeiro");
// estados.Add("PA", "Pará");
// estados.Add("RR", "Roraima");

// foreach (KeyValuePair<string, string> item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

// string valor = "RR";

// System.Console.WriteLine(estados[valor]);
// estados[valor] = "Roraima - Norte";
// System.Console.WriteLine(estados[valor]);

// System.Console.WriteLine($"Removendo valor {valor}");
// estados.Remove(valor);

// foreach (KeyValuePair<string, string> item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, valor: {item.Value}");
// }

// valor = "RR";

// if (estados.TryGetValue(valor, out string? retorno))
// {
//     System.Console.WriteLine($"Estado {retorno} está no dicionário");
// }
// else
// {
//     System.Console.WriteLine($"Chave: {valor} não está no dicionário");
// }

/*----------------------Coleção Específica--------------------------------*/


// Stack<string> pilha = new Stack<string>(); 

// pilha.Push("Blusa"); 
// pilha.Push("Camisa"); 
// pilha.Push("Calça"); 

// System.Console.WriteLine($"Roupas na pilha: {pilha.Count}");

// while (pilha.Count > 0)
// {
//     System.Console.Write($"Que roupa esta no topo: {pilha.Peek()}  ");
//     System.Console.WriteLine($"usar a {pilha.Pop()}");
// }

// System.Console.WriteLine($"Roupas na pilha: {pilha.Count}");

/*-----------------------------------------------------------*/

// Queue<string> fila = new Queue<string>();

// fila.Enqueue("Mateus");
// fila.Enqueue("João");
// fila.Enqueue("Pedro");
// fila.Enqueue("Maria");

// System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

// while (fila.Count > 0)
// {
//     System.Console.Write($"Chamando: {fila.Peek()} -> ");
//     System.Console.WriteLine($"Atendendo: {fila.Dequeue()}");
// }

// System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

/*----------------------Coleção Genérica--------------------------------*/

// Lista li = new Lista(); 
// List<string> estados = new List<string>();
// string[] estadosArray = new string[2] {"BA", "RR"}; 

// estados.Add("RS"); 
// estados.Add("SC"); 
// estados.Add("PR"); 
// estados.Add("SP"); 

// System.Console.WriteLine($"Quantidade de elementos na Lista {estados.Count}");
// li.imprimirLista(estados); 

// System.Console.WriteLine("Inclindo novos elementos");
// estados.AddRange(estadosArray); 
// li.imprimirLista(estados); 

// System.Console.WriteLine("Removendo Elemento");
// estados.Remove("SC"); 
// li.imprimirLista(estados); 

// System.Console.WriteLine("Adicionando elementos em indice específico");
// estados.Insert(3,"RJ"); 
// li.imprimirLista(estados);

/*----------------------------Classe de Array------------------------------------*/

// https://docs.microsoft.com/pt-br/dotnet/api/system.array?view=net-6.0
// https://en.wikipedia.org/wiki/Comparison_sort
// https://visualgo.net/en/sorting
// ExArray bs = new ExArray(); 
// int[] arrInteir = new int[10]  { 11,1,24,56,32,4,23,6,8,12 };
// int[] arrCopia = new int[15];


// string[] arrayString = bs.convertArrayIntToString(arrInteir); 


/*----------------------------------------------------------------------*/

// System.Console.WriteLine($"Tamanho do meu array {arrCopia.Length}");
// bs.redimensionarArray(ref arrCopia, (arrCopia.Length * 3)); 
// System.Console.WriteLine($"Array redimencionado {arrCopia.Length}");

/*----------------------------------------------------------------------*/

// int valor = 24; 
// System.Console.WriteLine("Valor encontrado na {0}º posição ", bs.obtenPosicao(arrInteir, valor));

/*----------------------------------------------------------------------*/

// int valor = 0; 
// bool maiorQue = bs.condicaoProcura( arrInteir, valor ); 

// if(maiorQue)
// {
//     System.Console.WriteLine("Todos elemento do array são maiores que {0}", valor);
// }
// else 
// {
//     System.Console.WriteLine("Existe um ou mais elemento do array que são menores que {0}", valor);
// }

/*----------------------------------------------------------------------*/

// int valor = 5; 
// bool existe = bs.encontraElemento( arrInteir, valor ); 

// if(existe)
// {
//     System.Console.WriteLine($"Elemento {valor} existe no array ");
// }
// else 
// {
//     System.Console.WriteLine($"Elemento {valor} não encontrado no array ");
// }

/*----------------------------------------------------------------------*/

// System.Console.WriteLine("Array Copia");
// bs.ImprimiArray(arrCopia); 
// bs.copiaArray(ref arrInteir, ref arrCopia ); 
// System.Console.WriteLine("Array Copiado!");
// bs.ImprimiArray(arrCopia); 

/*----------------------------------------------------------------------*/


// System.Console.WriteLine("Array declarado!");
// bs.ImprimiArray(arrInteir); 
// bs.OrdenarClasseArray(ref arrInteir); 

// bs.ImprimiArray(arrInteir); 

/*----------------------Bubble Sort---------------------------------*/


// System.Console.WriteLine("Array declarado!");
// bs.ImprimiJoin(arrInteir); 

// System.Console.WriteLine("Array ordenado na V1!");
// bs.BubbleSortV1(ref arrInteir); 
// bs.ImprimiArray(arrInteir); 

// System.Console.WriteLine("Array ordenado na V2!");
// bs.BubbleSortV2(ref arrInteir); 
// bs.ImprimiArray(arrInteir); 




