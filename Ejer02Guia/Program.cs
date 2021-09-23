using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer02Guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 02";

            Console.WriteLine("Ingrese un numero: ");
            Double numero = double.Parse(Console.ReadLine());
            Double cuadrado;
            Double cubo;
            while(numero <= 0)
            {
                Console.WriteLine("Numero invalido, ingrese numero mayor a 0: ");
                numero = int.Parse(Console.ReadLine());
            }
            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("El cuadrado del numero {0} es {1} y el cubo es {2}", numero, cuadrado, cubo);

            Console.ReadKey();
        }
    }
}
