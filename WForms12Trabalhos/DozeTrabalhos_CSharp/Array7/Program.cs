using System;

namespace Array7
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int temp;
            try
            {
                Console.WriteLine("Informe Quantos Números Serão Utilizados :");
                numero = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[numero];

                for(int i =0; i < numero; i++)
                {
                    Console.Write("Informe o n." + "Valor.");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                for(int i =0; i < numero; i++)
                {
                    for(int j =0; j < numero - 1; j++)
                    {
                        if(array[j] > array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("Ordenando em Ordem Ascendente :");

                for(int i =0; i < numero; i++)
                {
                    Console.WriteLine(array[i]);
                }
                Console.ReadKey();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}
