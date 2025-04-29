using System;

class Program
{
    static void Main() {
        int [] numeros = new int[5];
        int soma = 0;
        
        for (int i = 0; i < 5; i++) {
            Console.Write($"Digite o número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
            soma += numeros[i];
        }
        Console.WriteLine("\nNúmeros Digitados: ");
        for (int i = 0; i < 5; i++){
            Console.WriteLine(numeros[i]);
        }
        Console.WriteLine($"\nSoma dos Números: {soma}");
    }
}