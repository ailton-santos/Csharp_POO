using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[6];
        float[] precos = new float[6];
        float soma = 0;

        Console.WriteLine("Mercado Genésio");
        Console.WriteLine();
        Console.WriteLine();

        for(int i=1; i<6; i++)
        {
            Console.Write($"Digite o nome do {i}º produto: ");
            nomes[i] = Console.ReadLine();
            Console.Write($"Qual o preço de {nomes[i]}: ");
            precos[i] = float.Parse(Console.ReadLine());
            Console.WriteLine();
            
            soma += precos[i];
        }

        Console.WriteLine("Lista de todos os produtos:");
        for(int i=1; i<6; i++)
        {
            Console.WriteLine($"Produto:{nomes[i]} -> R${precos[i]}");
        }
            Console.WriteLine($"O preço total da compra é {soma}");
    }
}