using System;

class Program {
    static void Main() {
        string[] usuarios = new string [5];
        int cont = 0;
        string buscar = "";
        
        while (true) {
            MostrarMenu();

            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    if (cont != 5){
                        CadastrarNomes(usuarios, cont);
                        cont++;
                    }
                    else {
                        Console.WriteLine("Limite de cadastros atingido.");
                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine("\n=== Menu de Busca ===");
                    Console.Write("Digite o nome do usuário: ");
                    buscar = Console.ReadLine();
                    if (BuscarNome(usuarios, buscar, cont)) {
                        Console.WriteLine($"Usuário {buscar} encontrado.");
                    }
                    else {
                        Console.WriteLine($"Usuário {buscar} não encontrado.");
                    }
                    break;

                case "0":
                    Console.WriteLine("Encerrando o programa...");
                    return;

                default:
                    Console.WriteLine("⚠️ Opção inválida. Tente novamente.\n");
                    break;
            }
        }
    }

    static void CadastrarNomes(string[] usuarios, int cont) {
        Console.Clear();
        Console.WriteLine("\n=== Menu de Cadastro ===");
        Console.Write("Digite o nome do usuário: ");
        usuarios[cont] = Console.ReadLine();
        Console.WriteLine($"{usuarios[cont]} cadastrado com sucesso;");
        return;
    }
    
    static bool BuscarNome(string[] nomes, string busca, int cont){
        for (int j = 0; j < cont; j++){
            if (busca.ToLower() == nomes[j].ToLower()){
                return true;
            }
        }
        return false;
    }

    static void MostrarMenu() {
        Console.Clear();
        Console.WriteLine("\n=== Menu Principal ===");
        Console.WriteLine("[1] Cadastrar Usuário");
        Console.WriteLine("[2] Buscar Usuário");
        Console.WriteLine("[0] Sair");
    }

}
