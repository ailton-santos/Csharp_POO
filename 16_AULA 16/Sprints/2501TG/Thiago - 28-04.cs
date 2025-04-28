//array
/*conceito -> uma caixa numerada, e cada caixa você colocaria dentro do colchete []. sendo um VETOR
é como uma caixa com um rotulo (A por exemplo), A[0] A[1] A[2]
exemplo: A[2], posição 3/indice 2*/

using System;

class Program
{
    static void Main() 
    {
        /*string[] nomes = new string[5]; //definindo um array de 3 nomes
        //NEW serve para criar uma SUB váriavel da vár original, Random random = New.random ou acima como exemplo

        nomes[0] = "Maria";
        nomes[1] = "Pedro";
        nomes[2] = "Joseph";
        nomes[3] = "Thiago";
        nomes[4] = "Fernanda";

        for(int i=0; i < 5; i++)
        {
            Console.WriteLine(nomes[i]);
        }*/

        /*int[] numeros = new int[5];
        int soma = 0;
        
                    Console.WriteLine("Digite todos os 5 numeros que deseja somar.");

        for(int i=0; i < 5; i++) //mostra uma lista 2 mas para inputs do usuário
        {
            Console.Write($"Digite o número {i+1}: ");
            numeros[i] = int.Parse(Console.ReadLine()); //Parse é conversão também, eu achei que era so para o float
            soma += numeros[i];
        }
  
        Console.WriteLine("\nNúmeros digitados:");

        for(int i=0; i < 5; i++) //mostra uma lista de todos, array é bom
        {
            Console.WriteLine(numeros[i]);
        }
        Console.WriteLine($"\nA soma dos números é {soma}.");*/

        /*int soma = 0;
        Console.WriteLine("Soma de números.");
        Console.WriteLine();
        Console.Write("Quantas vezes você quer somar: ");
        int entry = int.Parse(Console.ReadLine());

        for (int i=0; i < entry; i++)
        {
            Console.Write($"Digite um número para somar (LIMITE DE {entry} números): ");
            int quant = int.Parse(Console.ReadLine());
            soma += quant;
        }
        Console.WriteLine($"O valor total é: {soma}");*/
        
        Console.WriteLine("Lista de númeração, por favor digite 10 valores para serem somados.");
        int[] total = new int[10];
        int soma = 0;

        for(int i=0; i < 10; i++)
        {
            Console.Write($"Digite o numero {i+1}: ");
            total[i] = int.Parse(Console.ReadLine());
            soma += total[i];
        }
        Console.WriteLine();
        Console.WriteLine($"A soma total é {soma}.");
        Console.WriteLine("\nNúmeros que você colocou:");
        
        for(int i=0; i < 10; i++)
        {
            Console.WriteLine($"NUM{i+1} - {total[i]}");

        }
    }
}