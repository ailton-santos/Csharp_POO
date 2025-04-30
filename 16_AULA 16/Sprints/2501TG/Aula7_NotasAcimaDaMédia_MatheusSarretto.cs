using System;

class Program
{
    static void Main() {
        float [] numeros = new float[10];
        float soma = 0;
        int quant = 0;
        
        for (int i = 0; i < 10; i++) {
            Console.Write($"Digite o número {i + 1}: ");
            numeros[i] = float.Parse(Console.ReadLine());
            soma += numeros[i];
        }
        
        Console.WriteLine("\nNúmeros digitados: ");
        for (int i = 0; i < 10; i++){
            Console.WriteLine(numeros[i]);
        }
        
        float media = soma/10;
        Console.WriteLine("\nMédia das notas: " + media);
        
        Console.WriteLine("\nNúmeros acima da média: ");
        for (int i = 0; i < 10; i++){
            if (numeros[i] > media){
                Console.WriteLine(numeros[i]);
                quant++;
            }
        }
        
        Console.WriteLine("\nQuantidade de notas acima de média: " + quant);
    }
}