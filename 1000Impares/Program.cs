using System;

namespace _1000Impares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fala bonitão!");
            Console.WriteLine("Digite um número entre 1 e 1000");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 1 && numero <= 1000)
            {
                Console.WriteLine($"Impares até {numero}");
                for (int i = 1; i <= numero; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("O número tem que estar entre 1 e 1000");
            }
        }
    }
}
