using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sistema de notas: ");
        Console.Write("Digite quantas notas serao digitadas: ");
        int n = 0;
        double soma = 0;
        double media = 0;
        double notas = 0;
        if (int.TryParse(Console.ReadLine(), out n))
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Digite a {i}a nota: ");
                notas = double.Parse(Console.ReadLine());
                soma += notas;
                media = soma / n;
            }
            Console.WriteLine($"A media das notas e: {media}");
            if (media >= 7)
            {
                Console.WriteLine("Aprovado! Muito bom!");
            }
            else if (media >= 5 && media < 7)
            {
                Console.WriteLine("Passou no sufoco!");
            }
            else
            {
                Console.WriteLine("Direto para recuperação!");
            }
        }
        else
        {
            Console.WriteLine("Digite um valor valido!");
            Main();
        }
        Console.ReadLine();
    }
}