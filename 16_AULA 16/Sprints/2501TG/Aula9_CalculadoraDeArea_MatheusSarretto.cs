using System;

class Program{
    static void Main(){
        
        
        while (true){
            MostrarMenu();
            float base1, altura, area;
		
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("\n=== Calcular Quadrado ===");
                    Console.Write("Comprimento do Lado: ");
                    base1 = LerFloat();
                    area = CalcularQuadrado(base1);
                    Console.WriteLine($"A área do quadrado é {area}");
                    break;

                case "2":
                    Console.WriteLine("\n=== Calcular Retângulo ===");
                    Console.Write("Comprimento da Base: ");
                    base1 = LerFloat();
                    Console.Write("Comprimento da Altura: ");
                    altura = LerFloat();
                    area = CalcularRetangulo(base1, altura);
                    Console.WriteLine($"A área do retângulo é {area}");
                    break;

                case "3":
                    Console.WriteLine("\n=== Calcular Triângulo ===");
                    Console.Write("Comprimento da Base: ");
                    base1 = LerFloat();
                    Console.Write("Comprimento da Altura: ");
                    altura = LerFloat();
                    area = CalcularTriangulo(base1, altura);
                    Console.WriteLine($"A área do triângulo é {area}");
                    break;

                case "4":
                    Console.WriteLine("\n=== Calcular Círculo ===");
                    Console.Write("Comprimento do Raio: ");
                    base1 = LerFloat();
                    area = CalcularCirculo(base1);
                    Console.WriteLine($"A área do círculo é {area}");
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

    // ----- Funções de Cálculo -----
    static float CalcularQuadrado(float lado) {
        return lado * lado;
    }
    
    static float CalcularRetangulo(float base1, float altura) {
        return base1 * altura;
    }
    
    static float CalcularTriangulo(float base1, float altura) {
        return (base1 * altura)/2;
    }
    
    static float CalcularCirculo(float raio) {
        float pi = 3.14f;
        return (raio * raio) * pi;
    }
    
    // ----- Função para exibir o menu -----
    static void MostrarMenu()
    {
        Console.WriteLine("\n=== Calculadora de Área ===");
        Console.WriteLine("[1] Área do Quadrado");
        Console.WriteLine("[2] Área do Retângulo");
        Console.WriteLine("[3] Área do Triângulo");
        Console.WriteLine("[4] Área do Círculo");
        Console.WriteLine("[0] Sair");
    }

    // ----- Função para ler float com validação -----
    static float LerFloat()
    {
        while (true)
        {
            try
            {
                return float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("⚠️ Entrada inválida. Digite um número válido: ");
            }
        }
    }
}
