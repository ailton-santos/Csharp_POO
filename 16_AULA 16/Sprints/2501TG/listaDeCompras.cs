using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Olá! Seja bem vindo ao sistema de compras.");
        Console.Write("Digite quantos itens deseja comprar: ");
        int quantidade;

        if (int.TryParse(Console.ReadLine(), out quantidade))
        {
            string[] nome = new string[quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o {i + 1} item: ");
                nome[i] = Console.ReadLine();
            }
            Console.WriteLine("Esses foram os itens escolhidos: ");
            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine(nome[i]);
            }

        }
        else
        {
            Console.WriteLine("Digite um numero valido.");
            Main();
        }

    }
}

