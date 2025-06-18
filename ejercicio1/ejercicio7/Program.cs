using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un año: ");
            int ano = Convert.ToInt32(Console.ReadLine());

            if (ano % 4 == 0)
            {
                if (ano % 100 != 0 || ano % 400 == 0)
                {
                    Console.WriteLine("El año es bisiesto.");
                }
                else
                {
                    Console.WriteLine("El año no es bisiesto.");
                }
            }
            else
            {
                Console.WriteLine("El año no es bisiesto.");
            }
        }
    }
}
