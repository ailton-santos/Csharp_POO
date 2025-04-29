using System;

class Program
{
    static void Main() {
        Console.Write("Calculadora de IMC\n");
        
        Console.Write("Altura (em metros): ");
        double altura = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Peso (em KG): ");
        double peso = Convert.ToDouble(Console.ReadLine());
        
        double imc = peso / (altura*altura);
        
        if (imc < 18.5) {
            Console.WriteLine("Classificação: Baixo Peso.");
        }
        if (18.5 <= imc && imc < 25){
            Console.WriteLine("Classificação: Peso Normal.");
        }
        if (25 <= imc && imc < 30){
            Console.WriteLine("Classificação: Sobrepeso.");
        }
        if (30 <= imc  && imc < 35){
            Console.WriteLine("Classificação: Obesidade grau I.");
        }
        if (35 <= imc && imc < 40){
            Console.WriteLine("Classificação: Obesidade grau II.");
        }
        if (imc >= 40){
            Console.WriteLine("Classificação: Obesidade grau III ou Mórbida.");
        }
        
        Console.ReadLine();
    }
}