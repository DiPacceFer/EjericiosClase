using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer04Guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 4";
            Int32 contador = 0;
            Int32 i = 2;
            Console.WriteLine("Los primeros cuatro numeros perfectos son: ");
            do
            {
                Int32 divisor = 0;
                Int32 suma = 0;
                for(int j=i-1; j>0; j--)
                {
                    if(i % j == 0)
                    {
                        divisor = j;
                        suma += divisor;
                    }
                }
                if(suma== i)
                {
                    contador++;
                    Console.WriteLine("{0}", i);
                }
                i++;
                suma = 0;

            } while (contador < 4);
            Console.ReadKey();
        }
    }
}
