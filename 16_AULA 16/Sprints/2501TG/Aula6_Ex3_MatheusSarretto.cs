using System;

class Program
{
    static void Main() {
        int [] numeros = new int[255];
        string input;
        int soma = 0;
        int i = 0;
        
        Console.WriteLine("Digite 'sair' para Parar." );
        for (i = 0; i < 255; i++) {
            Console.Write($"Digite o número {i + 1}: ");
            input = Console.ReadLine();
            if (input.ToLower() != "sair"){
                numeros[i] = int.Parse(input);
                soma += numeros[i];
            }
            else break;
        }
        if (i == 255) {
            Console.WriteLine("Número máximo de entradas atigindo.");
        }
        
        Console.WriteLine("\nNúmeros Digitados: ");
        for (int j = 0; j < i; j++){
            Console.WriteLine(numeros[j]);
        }
        Console.WriteLine($"\nSoma dos Números: {soma}");
    }
}