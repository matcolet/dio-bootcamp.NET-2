// See https://aka.ms/new-console-template for more information
using Series.Classes;
using Series;

SerieRepositorio repositorio = new SerieRepositorio();

string opcaoUsuario = ObterOpcaoUsuario();

while (opcaoUsuario.ToUpper() != "X")
{
    switch (opcaoUsuario)
    {
        case "1":
            ListarSeries();
            break;
        case "2":
            InserirSerie();
            break;
        case "3":
            AtualizarSerie();
            break;
        case "4":
            ExcluirSerie();
            break;
        case "5":
            VisualizarSerie();
            break;
        case "C":
            Console.Clear();
            break;

    }

    opcaoUsuario = ObterOpcaoUsuario();
}

Console.WriteLine("Obrigado por utilizar nossos serviços.");
Console.ReadLine();



// opcao do usuário 
static string ObterOpcaoUsuario()
{
    Console.WriteLine();
    Console.WriteLine("DIO Séries a seu dispor!!!");
    Console.WriteLine("Informe a opção desejada:");

    Console.WriteLine("1- Listar séries");
    Console.WriteLine("2- Inserir nova série");
    Console.WriteLine("3- Atualizar série");
    Console.WriteLine("4- Excluir série");
    Console.WriteLine("5- Visualizar série");
    Console.WriteLine("C- Limpar Tela");
    Console.WriteLine("X- Sair");
    Console.WriteLine();

    string opcaoUsuario = Console.ReadLine().ToUpper();
    Console.WriteLine();
    return opcaoUsuario;
}

//---------------------------Listar Serie -----------------------------//
void ListarSeries()
{
    Console.WriteLine("Listar séries");

    var lista = repositorio.Lista();

    if (lista.Count == 0)
    {
        Console.WriteLine("Nenhuma série cadastrada.");
        return;
    }

    foreach (var serie in lista)
    {

        var excluido = serie.retornaExcluido();

        Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluído*" : ""));
        //Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo());

    }
}


//---------------------------Inserir -----------------------------//
void InserirSerie()
{
    Console.WriteLine("Inserir nova série");

    // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
    // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
    foreach (int i in Enum.GetValues(typeof(Genero)))
    {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
    }
    Console.Write("Digite o gênero entre as opções acima: ");
    int entradaGenero = int.Parse(Console.ReadLine());

    Console.Write("Digite o Título da Série: ");
    string entradaTitulo = Console.ReadLine();

    Console.Write("Digite o Ano de Início da Série: ");
    int entradaAno = int.Parse(Console.ReadLine());

    Console.Write("Digite a Descrição da Série: ");
    string entradaDescricao = Console.ReadLine();

    Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                genero: (Genero)entradaGenero,
                                titulo: entradaTitulo,
                                ano: entradaAno,
                                descricao: entradaDescricao);

    repositorio.Insere(novaSerie);
}


//---------------------------Atualizar-----------------------------//
void AtualizarSerie()
{
    Console.Write("Digite o id da série: ");
    int indiceSerie = int.Parse(Console.ReadLine());

    // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=netcore-3.1
    // https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=netcore-3.1
    foreach (int i in Enum.GetValues(typeof(Genero)))
    {
        Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
    }
    Console.Write("Digite o gênero entre as opções acima: ");
    int entradaGenero = int.Parse(Console.ReadLine());

    Console.Write("Digite o Título da Série: ");
    string entradaTitulo = Console.ReadLine();

    Console.Write("Digite o Ano de Início da Série: ");
    int entradaAno = int.Parse(Console.ReadLine());

    Console.Write("Digite a Descrição da Série: ");
    string entradaDescricao = Console.ReadLine();

    Serie atualizaSerie = new Serie(id: indiceSerie,
                                genero: (Genero)entradaGenero,
                                titulo: entradaTitulo,
                                ano: entradaAno,
                                descricao: entradaDescricao);

    repositorio.Atualiza(indiceSerie, atualizaSerie);
}

//---------------------------Excluir-----------------------------//
void ExcluirSerie()
{
    Console.Write("Digite o id da série: ");
    int indiceSerie = int.Parse(Console.ReadLine());

    repositorio.Exclui(indiceSerie);
}

//---------------------------Visualizar-----------------------------//
void VisualizarSerie()
{
    Console.Write("Digite o id da série: ");
    int indiceSerie = int.Parse(Console.ReadLine());

    var serie = repositorio.RetornaPorID(indiceSerie);

    Console.WriteLine(serie);
}