using System;

class Program
{
    static void Main() {
        float soma = 0;
        float numero = -1;
        
        Console.WriteLine("Digite números para somar. Digite 0 para encerrar");
        
        while (numero != 0){
            Console.Write("Digite um número: ");
            numero = float.Parse(Console.ReadLine());
        
            soma = soma + numero;
        }
        Console.WriteLine("\nA soma total é: " + soma);
        Console.WriteLine("Fim do Programa.");
    }
}