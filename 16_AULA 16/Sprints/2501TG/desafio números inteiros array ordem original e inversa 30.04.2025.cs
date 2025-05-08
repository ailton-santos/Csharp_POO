class Program
{
    static void Main()
    {
        int[] numeros = new int[7]; 

        Console.WriteLine("[DIGITE 7 NUMEROS INTEIROS]");

        for (int i = 0; i < numeros.Length; i++)
        {
            while (true)
            {
                try
                {
                    Console.Write($"Digite o número {i + 1}: ");
                    numeros[i] = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("[ERRO] USE APENAS NUMEROS");
                }
            }
        }
        Console.WriteLine("Números na ordem original:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"{numeros[i]} ");
        }
        Console.WriteLine("\nNúmeros na ordem inversa:");
        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.Write($"{numeros[i]} ");
        }
    } 
}