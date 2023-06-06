using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            EscolhaMenu();
        }

        public static void EscolhaMenu()
        {
            int opção; //placeholder só pra mostrar que funciona
            try
            {
                do
                {
                    Console.WriteLine("Digite número do menu bla bla bla");
                    opção = int.Parse(Console.ReadLine());
                    if (opção < 0 || opção > 3)
                    {
                        Console.WriteLine("Opção inválida, digite 1, 2 ou 3.\n");
                    }
                } while (opção < 0 || opção > 3);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Opção inválida, digite 1, 2 ou 3.\n");
                EscolhaMenu();
            }
        }
    }
}
