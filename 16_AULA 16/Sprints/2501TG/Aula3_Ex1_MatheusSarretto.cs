using System;

class Program
{
    static void Main() {
        Console.Write("Verificador de Idade\n");
        
        Console.Write("Digite a sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());
        
        if (idade >= 18){
            Console.Write("A pessoa é maior de idade.");
        }
        else {
            Console.Write("A pessoa é menor de idade.");
        }
        Console.ReadLine();
        
    }
}