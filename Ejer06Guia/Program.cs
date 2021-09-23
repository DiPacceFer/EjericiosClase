using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer06Guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 6";
            int AñoInicio = 0;
            int AñoFin = 0;
            int AñoBisiesto = 0;

            Console.WriteLine("Ingrese un año de comienzo: ");
            AñoInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un año final: ");
            AñoFin = int.Parse(Console.ReadLine());
            Console.WriteLine("Los años bisiestos entre los años {0} y {1} son: ", AñoInicio, AñoFin);
            for(int i=AñoInicio;i<=AñoFin;i++)
            {
                if(i % 4 == 0 && (i % 100 != 0 || i % 400 == 0))
                {
                    Console.WriteLine("{0}", i);
                }
            }



            Console.ReadKey();
        }
    }
}
