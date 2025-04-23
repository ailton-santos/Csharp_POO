using System;

class Program
{
    static void Main() {
        Console.WriteLine("Verificador de Maior Idade");
        
        Console.Write("Digite a sua idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("A pessoa é maior de idade.");
        }
        else 
        {
           Console.WriteLine("A pessoa não é maior de idade.") ;
        }
        Console.ReadLine();
    }
}

using System;

class Program
{
    static void Main() {
        Console.WriteLine("Verificador de Maior Idade");
        
        Console.Write("Digite a sua idade: ");
        float idade = float.Parse(Console.ReadLine());

        if (idade >= 18.0f)
        {
            Console.WriteLine("A pessoa é maior de idade.");
        }
        else 
        {
           Console.WriteLine("A pessoa não é maior de idade.") ;
        }
        Console.ReadLine();
    }
}

