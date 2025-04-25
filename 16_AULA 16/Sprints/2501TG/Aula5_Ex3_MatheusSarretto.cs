using System;

class Program
{
    static void Main() {
        float soma = 0;
        float numero = -1;
        string input = "";
        Console.WriteLine("Caixa Registradora");
        Console.WriteLine("Digite o valor de cada produto comprado. Digite -1 para encerrar.");
        
         while (numero != 0) {
            Console.Write("Digite o valor do produto: ");
            input = Console.ReadLine();
            if (float.TryParse(input, out numero)){
                soma = soma + numero;
            }
            else {
                Console.WriteLine("Insira um valor númerico válido.");
                numero = -1;
            }
        }
        Console.WriteLine("\nValor total da compra: R$" + soma);
        Console.WriteLine("Fim do Programa.");
    }
}