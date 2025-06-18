using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el nombre del Jugador 1: ");
            string jugador1 = Console.ReadLine();
            Console.Write("Ingrese el nombre del Jugador 2: ");
            string jugador2 = Console.ReadLine();

            int setsGanadosJ1 = 0;
            int setsGanadosJ2 = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Set {i}:");
                Console.Write($"Puntos de {jugador1}: ");
                int puntosJ1 = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Puntos de {jugador2}: ");
                int puntosJ2 = Convert.ToInt32(Console.ReadLine());

       
                if (puntosJ1 > puntosJ2)
                {
                    setsGanadosJ1++;
                }
                else if (puntosJ2 > puntosJ1)
                {
                    setsGanadosJ2++;
                }
        
            }
            Console.WriteLine();
            if (setsGanadosJ1 > setsGanadosJ2)
            {
                Console.WriteLine($"Ganador {jugador1}");
            }
            else if (setsGanadosJ2 > setsGanadosJ1)
            {
                Console.WriteLine($"Ganador {jugador2}");
            }
            else
            {
                Console.WriteLine("Empate en sets");
            }
        }
    }
}
