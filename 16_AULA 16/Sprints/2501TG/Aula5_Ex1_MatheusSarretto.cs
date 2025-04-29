using System;

class Program
{
    static void Main() {
        List<string> nomes = new List<string>();
        string nome = "";
        
        Console.WriteLine("Digite os nomes. Para encerrar, digite 'sair' ");
        
        while(nome.ToLower() != "sair"){
            Console.Write("Digite um nome: ");
            nome = Console.ReadLine();
            
            if (nome.ToLower() != "sair"){
                nomes.Add(nome);
            }
        }
        Console.WriteLine("\nNomes Cadastrados: ");
        foreach (string n in nomes){
            Console.WriteLine("-" + n);
        }
        Console.WriteLine("Fim do Programa.");
        
    }
}