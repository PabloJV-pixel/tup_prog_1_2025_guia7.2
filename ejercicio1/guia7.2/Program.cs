using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace guia7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la condición de promoción: ");
            string condicion = Console.ReadLine();

            Console.WriteLine("Ingrese la nota del primer parcial: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del segundo parcial: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la nota del tercer parcial: ");
            double nota3 = Convert.ToDouble(Console.ReadLine());    

            double promedio = (nota1 + nota2 + nota3) / 3.0;

            if (condicion.ToLower() == "promocion" && promedio >= 7 && nota1 >= 6 && nota2 >= 6 && nota3 >= 6)
            {
                Console.WriteLine("Promociona");
            }
            else
            {
                Console.WriteLine("Rinde Final");
            }

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }

    }
    
}
