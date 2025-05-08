using System;

public class Program {
    public static void Main() {
        int numero;

        do {
            Console.Write("Digite um número inteiro (ou 0 para sair): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out numero)){
                if (numero == 0) {
                    break;
                }
                if (VerificarPrimo(numero)) {
                    Console.WriteLine($"{numero} é primo.");
                }
                else {
                    Console.WriteLine($"{numero} não é primo.");
                }
            }
            else {
                Console.WriteLine("Erro: Por favor, digite um número inteiro.");
            }
            Console.WriteLine();
        } while (true);
    }

    static bool VerificarPrimo(int n) {
        if (n <= 1) {
            return false;
        }
        if (n <= 3) {
            return true;
        }
        if (n % 2 == 0 || n % 3 == 0) {
            return false;
        }
        for (int i = 5; i * i <= n; i = i + 6) {
            if (n % i == 0 || n % (i + 2) == 0) {
                return false;
            }
        }
        return true;
    }
}