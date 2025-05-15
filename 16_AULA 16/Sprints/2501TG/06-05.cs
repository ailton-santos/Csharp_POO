/*Crie um sistema de cadastro simples onde o usuário:
Cadastre o nome de até 10 pessoas (usar array de string);
Após o cadastro, peça um nome para buscar;
Use uma função que percorre o array e:
Diz se o nome foi encontrado ou não;
Mostra o índice (posição) caso encontrado.
Use ToLower() para facilitar a comparação (caso-insensitivo)
Crie funções:
CadastrarNomes()
BuscarNome(string[] nomes, string nomeBuscado)*/


using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[10];
        bool entry = false;
        char userIP= 'a';

        Console.WriteLine("Cadastro de nomes");
        Console.WriteLine();

        login(nomes);

        Console.WriteLine();
        try
        {
            Console.WriteLine("Nomes cadastrados com sucesso! Gostaria de pesquisar um nome?");
            Console.Write("Y / N → ");
            userIP = Convert.ToChar(Console.ReadLine().ToUpper());
        }catch
        {
            Console.WriteLine("Digita direito >:(");
        }

        if(userIP == 'Y')
        {
            entry = true;
        }else
        {
            entry = false;
        }

        while(entry)
        {
        Console.WriteLine("Pesquisa de nomes");
        search("",nomes); /*nem sempre precissa ser colocado um variavel exata para a função
        string por exemplo, sendo uma entrada do usuario pode ser em branco já que a função faz o trabalho*/
        }

        if(entry = false)
        {
            Console.WriteLine("Fim do programa.");
        }else
        {
            Console.WriteLine("Cadastro concluído.");
        }
    }


    static void login(string[] NO)
    {
        for(int i = 0; i < NO.Length; i++)
        {
            Console.Write($"Por favor digite o {i+1}º nome: ");
            NO[i] = Console.ReadLine();

            Console.WriteLine("\nNome cadastrado!");
        }
    }
    static void search(string user, string[] array)
    {
        Console.Write("Digite um nome: ");
        user = Console.ReadLine();

        if(array.Contains(user.ToLower())) //compara o que o usuario digitou se faz parte do array
        {
            Console.WriteLine($"Nome encontrado :D");
        }else
        {
            Console.WriteLine("Nome não encontrado D:");
        }
    }
} 