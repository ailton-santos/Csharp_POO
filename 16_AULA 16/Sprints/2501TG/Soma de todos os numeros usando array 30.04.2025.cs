using System;

class Program
{
    static void Main() {
        int[] numeros = new int[10];
        int soma = 0;

        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < numeros.Length; i++) 
        {
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            soma += numeros[i];
        }
            Console.WriteLine("\nNúmeros digitados:");
            foreach (int numero in numeros) 
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine($"\nSoma Total: {soma}");
    }
}