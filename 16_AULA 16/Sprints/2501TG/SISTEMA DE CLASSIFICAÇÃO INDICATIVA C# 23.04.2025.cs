using System;

class Program
{
    static void Main() {
        Console.WriteLine("[SISTEMA DE CLASSIFICAÇÃO INDICATIVA] ");
        Console.WriteLine("Digite sua idade para listar os filmes disponíveis: ");
        int idade = Convert.ToInt32(Console.ReadLine()); // int que define a idade e le a resposta da linha 7

        // mostrar filmes disponiveis
        Console.Write("Filmes disponíveis pra sua idade: ");

        if (idade < 10) { // livre
            Console.WriteLine();
            Console.WriteLine("- Procurando Nemo");
            Console.WriteLine("- Toy Story");
            Console.WriteLine("- Moana");
        }
        if (idade < 12 && idade >= 10) { // 10 anos
            Console.WriteLine();
            Console.WriteLine("- Harry Potter e a Pedra Filosofal");
            Console.WriteLine("- Os Incríveis");
            Console.WriteLine("- As Crônicas de Nárnia");
        }
        if (idade < 14 && idade >= 12) { // 12 anos
            Console.WriteLine();
            Console.WriteLine("- Homem-Aranha: Sem Volta Para Casa");
            Console.WriteLine("- Jogos Vorazes");
            Console.WriteLine("- Maze Runner");
        }
        if (idade < 16 && idade >= 14) { // 14 anos
            Console.WriteLine();
            Console.WriteLine("- Shrek 2");
            Console.WriteLine("- O Rei Leão");
            Console.WriteLine("- Kung Fu Panda");
        }
        if (idade < 18 && idade >= 16) { // 16 anos
            Console.WriteLine();
            Console.WriteLine("- O Poderoso Chefão");
            Console.WriteLine("- Clube da Luta");
            Console.WriteLine("- Pulp Fiction");
        }
        if (idade >= 18) { // 18+ anos
            Console.WriteLine();
            Console.WriteLine("- A Lista de Schindler");
            Console.WriteLine("- Cidadão Kane");
            Console.WriteLine("- O Grande Lebowski");
        }
        
    }
}