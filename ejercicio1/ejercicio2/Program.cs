using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número:");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                if (numero == 0)
                {
                    Console.WriteLine("CERO");
                }
                else
                {
                    Console.WriteLine("POSITIVO");
                }
            }

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
