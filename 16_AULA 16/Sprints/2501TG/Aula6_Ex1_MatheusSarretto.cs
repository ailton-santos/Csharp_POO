using System;

class Program
{
    static void Main() {
        string [] nomes = new string[3];
        
        nomes[0] = "Maria";
        nomes[1] = "João";
        nomes[2] = "Pedro";
        
        for (int i = 0; i < 3; i++ ) {
            Console.WriteLine(nomes[i]);
        }
        
    }
}