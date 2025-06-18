using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, mayor;

            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            mayor = numero;

            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > mayor)
                mayor = numero;

            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > mayor)
                mayor = numero;

            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > mayor)
                mayor = numero;

            Console.Write("Ingrese un número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero > mayor)
                mayor = numero;

            Console.WriteLine("El mayor valor ingresado es: " + mayor);
        }
    }
}
