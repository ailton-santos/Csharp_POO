using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Classificação Recomendada para você");
        Console.WriteLine();
        Console.WriteLine();

        Console.Write("Qual sua idade? --> ");
        string entrada = Console.ReadLine();

        try
        {
            float idade = float.Parse(entrada);

            if (idade >= 18)
            {
                Console.WriteLine("Pode assisistir de todas as classificações.");
                Console.WriteLine("Não recomendado para menores de 18 anos.");
            } else if (idade >= 16)
            {
                Console.WriteLine("Pode assistir das classificações de 16, 14, 12, 10 e L.");
                Console.WriteLine("Não recomendado para menores de 16 anos.");
            } else if (idade >= 14)
            {
                Console.WriteLine("Pode assistir das classificações de 14, 12, 10 e L.");
                Console.WriteLine("Não recomendado para menores de 14 anos.");
            } else if (idade >= 12)
            {
                Console.WriteLine("Pode assistir das classificações de 12, 10 e L.");
                Console.WriteLine("Não recomendado para menores de 12 anos.");
            } else if (idade >= 10)
            {
                Console.WriteLine("Pode assistir das classificações de 10 e L.");
                Console.WriteLine("Não recomendado para menores de 10 anos.");
            } else
            {
                Console.WriteLine("Classificação livre, qualquer um pode assistir.");
            }
        } catch
        {
                Console.WriteLine("Por favor digite uma idade válida");
        }




    }
}