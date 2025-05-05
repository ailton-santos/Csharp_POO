using System;

class Program
{
    static void Main() {
        string[] produtos = new string [5];
        float[] precos = new float [5];
        float total = 0;
        
        Console.WriteLine("Digite nome e preço de 5 produtos");
        
        for (int i = 0; i < 5; i++){
            Console.Write($"\nDigite o nome do produto {i+1}: ");
            produtos[i] = Console.ReadLine();
            
            Console.Write($"Digite o preço de {produtos[i]}: R$");
            precos[i] = float.Parse(Console.ReadLine());
            
            total = CalcularTotal(total, precos[i]);
        }
        
        ExibirRelatorio(produtos, precos, total);
    }
        
    
    static float CalcularTotal(float total, float preco) {
    return total + preco;
    }
    
    static void ExibirRelatorio(string[] produtos, float[] precos, float total) {
        Console.WriteLine("\n------------------------------");
        Console.WriteLine("Relatório de Compra:\n ");
        for(int i = 0; i < 5; i++){
            Console.WriteLine($"{produtos[i]} --------- R${precos[i]}");
            Console.WriteLine();
        }
        Console.WriteLine($"Total: R${total:N2}");
    }
} 