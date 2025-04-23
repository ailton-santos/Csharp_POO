using System;

class Program
{
    static void Main() {
        Console.Write("Classificação Indicativa: ");
        string classe = Console.ReadLine();
        
        if (classe == "L") {
            Console.WriteLine("Livre: Não expõe crianças a conteúdo potencialmente prejudiciais.");
        }
        else {
        if (classe == "10"){
            Console.WriteLine("Não recomendado para menores de 10 anos: Conteúdo violento ou linguagem inapropriada para crianças, ainda que em menor intensidade.");
        }
        else {
        if (classe == "12"){
            Console.WriteLine("Não recomendado para menores de 12 anos: As cenas podem conter agressão física, consumo de drogas e insinuação sexual.");
        }
        else {
        if (classe == "14"){
            Console.WriteLine("Não recomendado para menores de 14 anos: Conteúdos mais violentos e/ou de linguagem sexual mais acentuda.");
        }
        else {
        if (classe == "16"){
            Console.WriteLine("Não recomendado para menores de 16 anos: Conteúdos mais violentos ou com conteúdo sexual mais intenso, com cenas de tortura, suicídio, estupro ou nudez total.");
        }
        else {
        if (classe == "18"){
            Console.WriteLine("Não recomendado para menores de 18 anos: Conteúdos violentos e sexuais extremos.Cenas de sexo, incesto ou atos repetidos de tortura, mutilação ou abuso sexual.");
        }
        else {
            Console.WriteLine("Erro: Por favor, insira uma classificação válida.");
        }}}}}}
        
        Console.ReadLine();
    }
}