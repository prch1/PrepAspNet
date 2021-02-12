using System;

namespace ArraySpli
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "You-win-venceu";

            string[] str = s.Split('-');

            foreach(string c in str)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
