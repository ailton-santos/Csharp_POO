    // lista de compras em que a pessoa coloca aquantidade de itens, 
    //depois o nome de cada item e depois o programa exibe a lista
    using System;

    class Program
    {
        static void Main() 
        {
            Console.WriteLine("[SISTEMA DE LISTA DE COMPRAS BOLADONA]");
            // for para a quantidade de itens
            Console.Write("Digite a quantidade de itens: ");
            double quantidadeitens = Convert.ToDouble(Console.ReadLine());
            string listadeitens = "";
            for (int i = 1; i <= quantidadeitens; i++)
            {
                Console.Write($"Digite o nome do {i}° item: ");
                string nomeitem = Console.ReadLine();
                Console.WriteLine($"Item {i}: {nomeitem}");
                listadeitens += $"{nomeitem}\n";
            }
            Console.WriteLine("Lista de compras concluída!");
            Console.WriteLine($"Sua lista é:\n{listadeitens}");


        }    
    }