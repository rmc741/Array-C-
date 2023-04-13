Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//TestaArrayInt();
//TesteBuscarPalavras();

void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 20;
    idades[2] = 40;
    idades[3] = 11;
    idades[4] = 25;

    Console.WriteLine($"Tamanho do Array é igual a: {idades.Length}");

    int acumulador = 0;
    for ( int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"indice [{i}] = {idade}");
        acumulador += idade;
    }

    int media = acumulador/ idades.Length;
    Console.WriteLine($"media é igual: {media}");
}

void TesteBuscarPalavras()
{
    string[] arrayDePalavras = new string[5];

    for ( int i = 0;i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digite {i + 1} Palavra: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.WriteLine("Digite a palavra a ser encontrada:");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}");
            break;
        }
    }
}

