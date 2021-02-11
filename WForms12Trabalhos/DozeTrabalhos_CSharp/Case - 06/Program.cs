using System;

namespace Case___06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Case");

            int valor;
            string temp;
            char escolha;
            double centimetro, litros, kilometros;

            Console.WriteLine("Informe um valor inteiro para ser convertido :");
            valor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n Pressione uma das opções dadas : " +
                              "\n P-> converte de Polegadas para Centímetros." + 
                              "\n G->converte de Galões para Litros." +
                              "\n M->converte de Milas para Kilômetros");
            temp = Console.ReadLine().ToString().ToUpper();
            escolha = Convert.ToChar(temp);

            switch(escolha)
            {
                case 'P':
                    centimetro = valor / 0.3937;
                    Console.WriteLine("\n\n" + valor + " Polegadas são " + centimetro + " centimentros(cm)");
                    break;
                case 'G':
                    litros = valor * 3.78;
                    Console.WriteLine("\n\n" + valor + " Galões são " + litros + "litros(l)");
                    break;
                case 'M':
                    kilometros = valor * 1.60;                          // 1 Milha é igual a 1.60 Kilometros
                    Console.WriteLine("\n\n" + valor + " Milhas são " + kilometros + " Kilometros (Km) ");
                    break;
                default:
                    Console.WriteLine("Opção Inválida.Informe uma das operações oferecidas : P,G ou M");
                    break;
            }
            Console.ReadKey();
        }
    }
}
