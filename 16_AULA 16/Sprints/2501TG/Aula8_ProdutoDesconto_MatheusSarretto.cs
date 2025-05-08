using System;

public class Program {
    public static void Main() {
        string produto;
        float precoOriginal;
        float precoFinal;
        float desconto;

        do {
            Console.Write("\nDigite o nome do produto (ou 'sair'): ");
            produto = Console.ReadLine();
            if (produto.ToLower() == "sair"){
                break;
            }
            
            Console.Write("\nDigite o Preço: R$");
            precoOriginal = float.Parse(Console.ReadLine());
            
            Console.Write("\nDigite o Desconto (%): ");
            desconto = float.Parse(Console.ReadLine());
            
            precoFinal = CalcularDesconto(precoOriginal, desconto);
            
            Console.WriteLine($"\nProduto: {produto}");
            Console.WriteLine($"Preço original: R${precoOriginal}");
            Console.WriteLine($"Desconto: {desconto}%");
            Console.WriteLine($"Preço Final: R${precoFinal}");
            Console.WriteLine();
            
        } while (true);
    }

    static float CalcularDesconto(float preco, float desconto){
        float total = preco - (preco*desconto)/100;
        return total;
    }
}