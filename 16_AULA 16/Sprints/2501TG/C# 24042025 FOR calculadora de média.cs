// PROGRAMA PARA CALCULAR A MEDIA DE X NOTAS (AUTOMATIZAR, AO FINAL EXECUTAR A MÉDIA)
using System;

class Program
{
    static void Main() 
    {
        Console.WriteLine("[CALCULADORA DE MEDIAS]");
        Console.WriteLine();
        
        // for para as quantidade de notas
        Console.Write("Digite a quantidade de notas: ");
        int quantidadenotas = Convert.ToInt32(Console.ReadLine());
        double soma = 0;
        for (int i = 1; i <= quantidadenotas; i++)
        {
            Console.Write($"\nDigite a {i} nota: ");
            double notas = Convert.ToDouble(Console.ReadLine());
            soma += notas;
            Console.WriteLine();
            }
            double media = soma / quantidadenotas;
            Console.WriteLine($"A media das {quantidadenotas} notas e: {media}");
    }
}