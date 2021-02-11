using System;

namespace DoWhile_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do While ");

            char ch;
            int i = 10;

            do
            {
                Console.Write(i);
                Console.Write("  ");
                ch = (char)i;
                Console.WriteLine(ch);
                i++;

            } while (i <= 255);

            Console.ReadKey();
        }
    }
}
