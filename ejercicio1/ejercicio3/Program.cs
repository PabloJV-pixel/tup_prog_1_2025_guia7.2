using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese nombre del alumno 1: ");
            string nombre1 = Console.ReadLine();
            Console.Write("Ingrese número de libreta del alumno 1: ");
            double libreta1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese nombre del alumno 2: ");
            string nombre2 = Console.ReadLine();
            Console.Write("Ingrese número de libreta del alumno 2: ");
            double libreta2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese nombre del alumno 3: ");
            string nombre3 = Console.ReadLine();
            Console.Write("Ingrese número de libreta del alumno 3: ");
            double libreta3 = Convert.ToDouble(Console.ReadLine());

            if (libreta1 <= libreta2 && libreta1 <= libreta3)
            {
                if (libreta2 <= libreta3)
                {
                    Console.WriteLine($"{nombre1}, {libreta1}");
                    Console.WriteLine($"{nombre2}, {libreta2}");
                    Console.WriteLine($"{nombre3}, {libreta3}");
                }
                else
                {
                    Console.WriteLine($"{nombre1}, {libreta1}");
                    Console.WriteLine($"{nombre3}, {libreta3}");
                    Console.WriteLine($"{nombre2}, {libreta2}");
                }
            }
            else if (libreta2 <= libreta1 && libreta2 <= libreta3)
            {
                if (libreta1 <= libreta3)
                {
                    Console.WriteLine($"{nombre2}, {libreta2}");
                    Console.WriteLine($"{nombre1}, {libreta1}");
                    Console.WriteLine($"{nombre3}, {libreta3}");
                }
                else
                {
                    Console.WriteLine($"{nombre2}, {libreta2}");
                    Console.WriteLine($"{nombre3}, {libreta3}");
                    Console.WriteLine($"{nombre1}, {libreta1}");
                }
            }
            else 
            {
                if (libreta1 <= libreta2)
                {
                    Console.WriteLine($"{nombre3}, {libreta3}");
                    Console.WriteLine($"{nombre1}, {libreta1}");
                    Console.WriteLine($"{nombre2}, {libreta2}");
                }
                else
                {
                    Console.WriteLine($"{nombre3}, {libreta3}");
                    Console.WriteLine($"{nombre2}, {libreta2}");
                    Console.WriteLine($"{nombre1}, {libreta1}");
                }
            }
        }
    }
}