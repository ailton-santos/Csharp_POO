using System;

class Program
{
    static void Main() {
        Random rand = new Random();
        int resposta = rand.Next(1, 10);
        int numero = -1;
        string input = "";
        Console.WriteLine("Adivinhe o Número entre 1 e 10");

         while (numero != resposta) {
            Console.Write("Digite um número: ");
            input = Console.ReadLine();
            if (int.TryParse(input, out numero)){
                if (numero != resposta){
                    Console.WriteLine("Errou. Tente outra vez.");
                }
            }
            else {
                Console.WriteLine("Insira um valor númerico válido.");
                numero = -1;
            }
        }
        Console.WriteLine("\nParabéns, você acertou! Número: " + numero);
        Console.WriteLine("Fim do Programa.");
    }
}