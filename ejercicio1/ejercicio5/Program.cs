using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, menor, orden;
            
            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            menor = numero;
            orden = 1;

            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero < menor)
            {
                menor = numero;
                orden = 2;
            }

            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero < menor)
            {
                menor = numero;
                orden = 3;
            }

            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero < menor)
            {
                menor = numero;
                orden = 4;
            }

            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero < menor)
            {
                menor = numero;
                orden = 5;
            }

            Console.WriteLine("El menor valor fue ingresado en la posición: " + orden);
        }
    }
}
