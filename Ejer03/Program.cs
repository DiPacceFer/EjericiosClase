using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 3";

            Int32 numeroLimite;
            Int32 contador = 1;

            Console.WriteLine("Ingrese el limite superior para los numeros primos que desee: ");
            numeroLimite = int.Parse(Console.ReadLine());

            Console.WriteLine("Los numeros primos hasta el numero {0} son: ", numeroLimite);
            Console.WriteLine("1");
            if(numeroLimite >1)
            {
                Console.WriteLine("2");
            }
            for(int i = 2; i<= numeroLimite; i++)
            {
                if(i % 2 != 0)
                {
                    for(int j= i-1;j>1;j--)
                    {
                        if(i%j == 0)
                        {
                            contador++;
                        }
                    }
                    if(contador == 1)
                    {
                        Console.WriteLine("{0}", i);
                    }
                }
                contador = 1;
            }

            Console.ReadKey();
        }
    }
}
