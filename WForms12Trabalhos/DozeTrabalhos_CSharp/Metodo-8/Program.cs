using System;

namespace Metodo_8
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();

            int num1, num2;
            int numeroEscolhido;

            try
            {
                Console.WriteLine("Informe o Primeiro Numero :");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o Segundo Numero :");
                num2 = Convert.ToInt32(Console.ReadLine());

                numeroEscolhido = p.NumeroMaior(num1, num2);
                p.NumeroPrimo(numeroEscolhido);

                Console.ReadKey();


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }

        private int NumeroMaior( int num1, int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        private void NumeroPrimo(int num)
        {
            int i = 2;

            while(i < num)
            {
                if(num % i == 0)
                {
                    Console.WriteLine("\nEste número é um número Composto.");
                    break;
                }
             i++;
            }

            if(i == num)
            {
                Console.WriteLine("Numero Primo");
            }

            if(num ==0 || num ==1)
            {
                Console.WriteLine("Numero Nao Primo");
            }


        }
    }
}
