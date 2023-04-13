Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

TestaArrayInt();

void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 20;
    idades[2] = 40;
    idades[3] = 11;
    idades[4] = 25;

    Console.WriteLine($"Tamanho do Array é igual a: {idades.Length}");

    for ( int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"indice [{i}] = {idade}");
    }
}

