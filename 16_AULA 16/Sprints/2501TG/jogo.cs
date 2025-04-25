using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem vindo ao Jogo! Tente adivinhar o numero que estou pensando de 1 a 10.");
        Random random = new Random();
        int numeroPensado = random.Next(1, 11);
        int numeroTentativa = 0;
        try
        {
        while (numeroTentativa != numeroPensado)
        {
            Console.Write("Digite um numero: ");
            numeroTentativa = int.Parse(Console.ReadLine());
            if (numeroTentativa == numeroPensado)
            {
                Console.WriteLine("Parabens! Voce acertou o numero.");
            }
            else {
                Console.WriteLine("Tente novamente.");
            }
        }
        }
        catch
        {
            Console.WriteLine("Digite um numero.");
            }
    }
        }