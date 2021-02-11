using System;

namespace Piramide_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\\Piramide");

            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }

            for(int i =0; i<=5; i++)
            {
                for(int j =5; j > i;j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}
