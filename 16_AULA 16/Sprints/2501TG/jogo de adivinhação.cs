using System;

class Program
{
    static void Main()
    {
        int vida = 3;
        Random random = new Random();
        int lucky = random.Next(1, 101);

        Console.WriteLine("Estou pensando em um número de 1 a 100, consegue adivinhar em 3 tentativas?");
        Console.WriteLine();

        Console.WriteLine($"Tentativas: {vida}");
        Console.Write("Resposta: ");
        string entry = Console.ReadLine();

        try
        {
            while (entry != null && vida > 0)
            {
               if (int.Parse(entry) != lucky)
               {
                        vida--;
                        Console.WriteLine("Errou! Tente novamente!");
                        Console.WriteLine($"Tentativas: {vida}");
                        Console.Write("Resposta: ");
                        entry = Console.ReadLine();
                    if (vida == 0)
                    {
                    Console.WriteLine("Errou! As suas vidas acabaram D:");
                    }
                }else
                {
                    Console.WriteLine("Errou! As suas vidas acabaram D:");
                }
            }
        }catch
        {
            Console.WriteLine("ERRO: Digite um valor valido");
        }

        if (int.Parse(entry) == lucky)
        {
            Console.WriteLine("Parabens! Você acertou!");

        }else if (vida <= 0)
        {
            Console.WriteLine("Errou! As suas vidas acabaram D:");
        }

    }
}