// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;


//--------------------------------Ho Ho Ho --------------------------------------//
// int N = int.Parse(Console.ReadLine());

// if (N > 0 && N <= 106)
// {
//     //Exibir "Ho" do papai noel
//     for (int i = 0; i < N; i++)
//     {
//         if (i != (N - 1))
//         {
//             Console.Write("Ho ");                  //Complete o código no espaço em branco
//         }
//         else
//         {
//             Console.WriteLine("Ho!");
//         }
//     }
// }


//--------------------------------X dividido Y--------------------------------------//
// int limit = Int32.Parse(Console.ReadLine());
// for (int i = 0; i < limit; i++)
// {
//     string[] line = Console.ReadLine().Split(" ");
//     double X = double.Parse(line[0]);
//     double Y = double.Parse(line[1]);
//     if (Y == 0)
//     {
//         System.Console.WriteLine("divisao impossivel");

//     }
//     else
//     {
//         double res = X / Y;
//         //res = Math.Round(res, 1);
//         System.Console.WriteLine(res.ToString("F1"));
//     }
// }


//--------------------------------Esfera--------------------------------------//

// double pi, raio, volume;
// pi = 3.14159;

// raio = double.Parse(Console.ReadLine());
// volume = (4.0 / 3) * pi * Math.Pow(raio, 3);

// Console.WriteLine("VOLUME = {0:0.000}", volume);


//--------------------------------Xenlonguinho --------------------------------------//

// int numero = int.Parse(Console.ReadLine());
// for (int i = 0; i < numero; i++)
// {
//     int totalEsfera = int.Parse(Console.ReadLine());

//     if (totalEsfera > 2 && totalEsfera <= 1000)
//     {
//         int contEsfera = 0;

//         for (int j = 1; j <= totalEsfera; j++)
//         {
//             int totalDivisores = 0;

//             for (int k = 1; k <= j; k++)
//             {
//                 if (j % k == 0)
//                 {
//                     totalDivisores++;
//                 }
//             }

//             if (totalDivisores % 2 == 0)
//             {
//                 contEsfera++;
//             }

//         }

//         Console.WriteLine(contEsfera);
//     }
// }

//--------------------------------Pedro Bento e mundo de OZ--------------------------------------//

string strJoia = string.Join("", args);
int qtdJoias = 0; 

List<string> tesouro = new List<string>();

do{

    strJoia = Console.ReadLine();
    
    //removendo qualquer caracter que não seja '(',')'
    strJoia = new string((from c in strJoia
                              where c.Equals('(') || c.Equals(')')
                              select c
                   ).ToArray());


    if (!string.IsNullOrWhiteSpace(strJoia) && strJoia.Length <= 106 )
    {
        tesouro.Add(strJoia);
        qtdJoias++; 
    }
    else
    {
        break;
    }

}while (true);

if(qtdJoias > 0 ){
    IEnumerable<string> tesouroDisc = tesouro.Distinct();
    Console.WriteLine(tesouroDisc.Count());
}