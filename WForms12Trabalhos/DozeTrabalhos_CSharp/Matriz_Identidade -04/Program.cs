using System;

namespace Matriz_Identidade__04
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho;

            Console.WriteLine("For - Matriz");

            Console.WriteLine("Informe o Tamanho da Matriz : ");
            tamanho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\nMatriz Identidade");


            for(int i = 0; i < tamanho; i++)
            {
                for(int j =0; j < tamanho; j++)
                {
                    if(i == j)
                    {
                        Console.Write(1);
                    }
                    else
                    {
                        Console.Write(0);
                    }
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
