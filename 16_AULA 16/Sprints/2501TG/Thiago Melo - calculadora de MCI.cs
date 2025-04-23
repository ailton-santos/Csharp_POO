using System;

class Program
{
    static void Main() {
    //titulo
    Console.WriteLine("Calculadora de IMC");
    Console.WriteLine();

    //dados
    Console.Write("Digite seu peso(KG): ");
    float kg = float.Parse(Console.ReadLine());
    Console.Write("Digite sua altura(M): ");
    float m = float.Parse(Console.ReadLine());

    //filtro de erros, pra não quebrar a programação
    try
    {
        float imc = kg/(m*m);

        if (imc < 18.5)
        {
            Console.WriteLine("Você esta abaixo do peso normal.");
            Console.WriteLine("Ta precissando de uma sexta básica amigo?");
        } else if (imc >= 18.5 && imc <= 24.9)
        {
            Console.WriteLine("Seu peso está normal e saudável");
        } if (imc >= 25.0 && imc <= 29.9)
        {
            Console.WriteLine("Você está com seu peso acima do normal");
            Console.WriteLine("Ta precissando perder um pouco.");
        } else if (imc >= 30.0 && imc <= 34.9)
        {
            Console.WriteLine("Você tem obesidade 1");
            Console.WriteLine("Ta com tanta fome assim?");
        } if (imc >= 35.0 && imc <= 39.9)
        {
            Console.WriteLine("Você tem obesidade 2");
            Console.WriteLine("Vai pra academia meu deus!");
        } else if (imc >= 40.0)
        {
            Console.WriteLine("Você tem obesidade 3");
            Console.WriteLine("MVP para principal causa de fome no mundo.");
        }
    } catch //resposta se um erro for encontrado
    {
        Console.WriteLine("Por favor digite um número válido.");
    }



    Console.ReadLine(); //só um extra no final, não é necessario
    }
}