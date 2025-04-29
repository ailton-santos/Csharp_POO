using System;

class Program
{
    static void Main() {
       List <string> nomes = new List<string>();
       string nome = "";
       Console.WriteLine("Digite os nomes. Para encerrar, digite 'sair'. ");
       
       while (nome.ToLower() != "sair")
       {
           Console.Write("Digite um nome: ");
           nome = Console.ReadLine();
           
           if (nome.ToLower() != "sair")
           {
               nomes.Add(nome);
           }
       }
       Console.WriteLine("\nNomes cadastrados: ");
       foreach (string nomeCadastrado in nomes) // a diferenca entre for e foreach eh que o foreach so precisa de um parametro, e nao precisa de contador
       {
           Console.WriteLine("- " + nomeCadastrado);
       }
       Console.WriteLine("\nFim do Programa");
    }
}