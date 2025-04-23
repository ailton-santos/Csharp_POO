using System;

class Program
{
    static void Main() {
        Console.WriteLine("calculadora de IMC");
        Console.Write("Digite seu Peso ");
        string entradapeso = Console.ReadLine(); // variavel para leitura da entrada da idade em string para não dar erro por float
        Console.Write("Digite sua altura (em metros, ex: 1.73) ");
        string entradaaltura = Console.ReadLine();  
        //variaveis
        string AB = "Abaixo do peso";
        string PN = "Com o Peso normal";
        string EP = "Com Excesso de peso";
        string Ob1 = "Com Obesidade Classe 1";
        string Ob2 = "Com Obesidade Classe 2";
        string Ob3 = "Com Obesidade Classe 3";
        // Tentar converter o valor digitado (TRATAMENTO DE ERROS)
        try
        {
            float peso = float.Parse(entradapeso);
            float altura = float.Parse(entradaaltura);

            float IMC = peso / (altura * altura);

            Console.Write("Seu IMC é " + IMC);

            if (IMC < 18.5f)
            {
                Console.WriteLine("Você está " + AB);
            }
            else if (IMC < 25f)
            {
                Console.WriteLine("Você está " + PN);
            }
            else if (IMC < 30f)
            {
                Console.WriteLine("Você está " + EP);
            }
            else if (IMC < 40f)
            {
                Console.WriteLine("Você está " + Ob1);
            }
            else if (IMC < 50f)
            {
                Console.WriteLine("Você está " + Ob2);
            }
            else if (IMC >= 50f)
            {
                Console.WriteLine("Você está " + Ob3);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro por favor digite um número válido.");
        }
    }
}