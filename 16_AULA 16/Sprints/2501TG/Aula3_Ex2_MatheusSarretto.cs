using System;

class Program
{
    static void Main() {
        Console.Write("Verificador de Idade\n");
        
        Console.Write("Digite a sua idade: ");
        string entrada = Console.ReadLine();
        
        try{
            float idade = float.Parse(entrada);
            if (idade >= 18.0f){
                Console.Write("A pessoa é maior de idade.");
            }
            else {
                Console.Write("A pessoa é menor de idade.");
            }
        }
        catch (FormatException){
            Console.Write("Erro: Por favor, digite um número válido");
        }
        Console.ReadLine();
    }
}