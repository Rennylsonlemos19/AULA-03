using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_numerosesinais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("digite o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("digite a umas das operações  \n(+ , * , / , - ,):");
            string ope = Console.ReadLine();

            if (ope == "+" )
            { 
                Console.Write("a soma dos dois numeros sera de: " + (n1 + n2));
            }
            else if (ope == "/")
            {
                Console.Write("a divisão dos dois numeros sera de: " + (n1 / n2));

            }
            else if (ope == "*")
            {
                Console.Write("a multiplicação dos dois numeros sera de: " + (n1 * n2));
            }
            else if (ope == "-")
            {
                Console.Write("a subtração dos dois numeros sera de: " + (n1 - n2));
            }
             else
            {
                Console.Write("\nOpção invalida");
            }
            Console.ReadKey();
        }
    }
}
