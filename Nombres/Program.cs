using System;

namespace Nombres
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = new string[10];
            for (int i = 0; i < Nombres.Length; i++)
            {
                Console.Write($"Escriba el Nombre {(i + 1)}:");
                Nombres[i] = Console.ReadLine();
            }
            Console.WriteLine("la lista de nombres es");
            for (int i = 0; i < Nombres.Length; i++)
            {
                Console.WriteLine(Nombres[i]);
            }
            Console.ReadLine();
        }
    }
}
