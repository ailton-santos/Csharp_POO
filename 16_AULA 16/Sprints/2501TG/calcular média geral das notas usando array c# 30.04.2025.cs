class Program
{
    static void Main() {
        float[] notas = new float[10];
        float soma = 0;

        Console.WriteLine("[DIGITE 10 NOTAS]");
        for (int i = 0; i < notas.Length; i++) 
        {
        while (true) 
        {
        try 
        {
            Console.Write($"Digite a nota número {i + 1}: ");
            notas[i] = float.Parse(Console.ReadLine());
            soma += notas[i];
            break;
        } 
        catch (FormatException) 
        {
            Console.WriteLine("[ERRO] USE APENAS NUMEROS");
        }
        }
        }
        float media = soma / notas.Length;
        Console.WriteLine($"Media Geral: {media}");

        int acimadamedia = 0;
        for (int i = 0; i < notas.Length; i++) 
        {
            if (notas[i] > media) {
                acimadamedia++;
            }
        }

        if (acimadamedia > 0) {
            Console.WriteLine("Notas acima da media:");
            for (int i = 0; i < notas.Length; i++) 
            {
                if (notas[i] > media) 
                {
                    Console.WriteLine($"Nota {i + 1}: {notas[i]}"); 
                }
            }
            Console.WriteLine($"QTD. notas acima da media: {acimadamedia}");
        } 
        else 
        {
            Console.WriteLine("Nenhuma nota acima da media");
        }
    }       
}

