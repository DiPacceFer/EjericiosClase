using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer01Guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";

            Console.WriteLine("Ingrese 5 numeros: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());
            int valorMax = 0;
            int valorMin = 0;
            float promedio;

            if(num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
            {
                valorMax = num1;
            }
            else if(num2 >= num1 && num2 > num3 && num2 > num4 && num2 > num5)
            {
                valorMax = num2;
            }
            else if(num3 >= num1 && num3 >= num2 && num3 > num4 && num3 > num5)
            {
                valorMax = num3;
            }
            else if(num4 >= num1 && num4 >= num2 && num4 >= num3 && num4 > num5)
            {
                valorMax = num4;
            }
            else if(num5 >= num1 && num5 >= num2 && num5 >= num3 && num5 >= num4)
            {
                valorMax = num5;
            }
            if (num1 < num2 && num1 < num3 && num1 < num4 && num1 < num5)
            {
                valorMin = num1;
            }
            else if (num2 <= num1 && num2 < num3 && num2 < num4 && num2 < num5)
            {
                valorMin = num2;
            }
            else if (num3 <= num1 && num3 <= num2 && num3 < num4 && num3 < num5)
            {
                valorMin = num3;
            }
            else if (num4 <= num1 && num4 <= num2 && num4 <= num3 && num4 < num5)
            {
                valorMin = num4;
            }
            else if (num5 <= num1 && num5 <= num2 && num5 <= num3 && num5 <= num4)
            {
                valorMin = num5;
            }
            promedio = (float)(num1 + num2 + num3 + num4 + num5) / 5;

            Console.WriteLine("El valor maximo es {0}, el valor minimo es {1} y el promedio es {2}", valorMax, valorMin, promedio);

            Console.ReadKey();
        }
    }
}
