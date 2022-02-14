// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.IO;
using ExArquivoPasta.FileHelp;


// definindo o local de trabalho 
var local = "C:\\ExArquivo";
var localPathCombine = Path.Combine(local, "Pasta teste 1");
var localArquivo = Path.Combine(local, "arquivo-teste-stream.txt");
var localArquivoTeste = Path.Combine(local, "arquivo-teste.txt");
var localArquivoTesteCopia = Path.Combine(local, "arquivo-teste-bkp.txt");
var localNovoCaminhoArquivo = Path.Combine(local, "Pasta Teste 2", "arquivo-teste-stream.txt");

// criando objeto 
FileHelp fh = new FileHelp(local);

// Linhas para serem escritas no arquivo
var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3" };
var listaStringCont = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

// Operações utilizando a classe FileHelp
fh.ListarDiretorios(local);
fh.ListarArquivosDiretorios(local);
fh.CriarDiretorio(localPathCombine);
fh.ApagarDiretorio(localPathCombine, true);
fh.CriarArquivoTexto(localArquivo, "Olá! Teste de escrita de arquivo");
fh.CriarArquivoTextoStream(localArquivo, listaString);
fh.AdicionarTextoStream(localArquivo, listaStringCont);
fh.LerArquivoStream(localArquivo);
fh.MoverArquivo(localArquivo, localNovoCaminhoArquivo, false);
fh.CopiarArquivo(localArquivoTeste, localArquivoTesteCopia, false);
fh.DeletarArquivo(localArquivoTesteCopia);