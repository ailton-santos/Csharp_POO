using System;

class Program
{
    static void Main() {
        int [] numeros = new int[7];
        
        for (int i = 0; i < 7; i++) {
            Console.Write($"Digite o número {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("\nOrdem Original: ");
        for (int i = 0; i < 7; i++){
            Console.WriteLine(numeros[i]);
        }
        
        Console.WriteLine("\nOrdem Invertida: ");
        for (int i = 6; i >= 0; i--){
            Console.WriteLine(numeros[i]);
        }
    }
}