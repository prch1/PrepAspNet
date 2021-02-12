using System;

namespace PalavrasArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = "000xxx999111";
            char[] arr;

            arr = str.ToCharArray(3,3);

            //for(int i = 0; i < str.Length; i ++)
            //{
            //    Console.WriteLine(str[i]);
            //}
            foreach(char c in arr)
            {
                Console.WriteLine(c);
            }

            Console.ReadKey();
        }
    }
}
