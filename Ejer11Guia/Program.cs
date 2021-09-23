using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer11Guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int num4 = 0;
            int num5 = 0;
            int num6 = 0;
            int num7 = 0;
            int num8 = 0;
            int num9 = 0;
            int num10 = 0;

            Console.WriteLine("Ingrese 10 numeros entre -100 y 100: ");
            num1 = int.Parse(Console.ReadLine());
            while(Validacion.Validar(num1, -100, 100))
            {
                Console.WriteLine("Numero invalido, ingrese numero entre -100 y 100: ");
                num1 = int.Parse(Console.ReadLine());
            }
            num2 = int.Parse(Console.ReadLine());
            while (Validacion.Validar(num2, -100, 100))
            {
                Console.WriteLine("Numero invalido, ingrese numero entre -100 y 100: ");
                num2 = int.Parse(Console.ReadLine());
            }
            num3 = int.Parse(Console.ReadLine());
            while (Validacion.Validar(num3, -100, 100))
            {
                Console.WriteLine("Numero invalido, ingrese numero entre -100 y 100: ");
                num3 = int.Parse(Console.ReadLine());
            }
            num4 = int.Parse(Console.ReadLine());
            while (Validacion.Validar(num4, -100, 100))
            {
                Console.WriteLine("Numero invalido, ingrese numero entre -100 y 100: ");
                num4 = int.Parse(Console.ReadLine());
            }
            num5 = int.Parse(Console.ReadLine());
            while (Validacion.Validar(num5, -100, 100))
            {
                Console.WriteLine("Numero invalido, ingrese numero entre -100 y 100: ");
                num5 = int.Parse(Console.ReadLine());
            }
            num6 = int.Parse(Console.ReadLine());
            while (Validacion.Validar(num6, -100, 100))
            {
                Console.WriteLine("Numero invalido, ingrese numero entre -100 y 100: ");
                num6 = int.Parse(Console.ReadLine());
            }
            num7 = int.Parse(Console.ReadLine());
            while (Validacion.Validar(num7, -100, 100))
            {
                Console.WriteLine("Numero invalido, ingrese numero entre -100 y 100: ");
                num7 = int.Parse(Console.ReadLine());
            }
            num8 = int.Parse(Console.ReadLine());
            while (Validacion.Validar(num8, -100, 100))
            {
                Console.WriteLine("Numero invalido, ingrese numero entre -100 y 100: ");
                num8 = int.Parse(Console.ReadLine());
            }
            num9 = int.Parse(Console.ReadLine());
            while (Validacion.Validar(num9, -100, 100))
            {
                Console.WriteLine("Numero invalido, ingrese numero entre -100 y 100: ");
                num9 = int.Parse(Console.ReadLine());
            }
            num10 = int.Parse(Console.ReadLine());
            while (Validacion.Validar(num10, -100, 100))
            {
                Console.WriteLine("Numero invalido, ingrese numero entre -100 y 100: ");
                num10 = int.Parse(Console.ReadLine());
            }



        }
    }
}
