using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer05Guia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 05";

            int PosibleCentro = 1;
            int Numero;
            int SumaAnteriores;
            int SumaPosteriores;

            Console.Write("Ingrese un numero: ");
            Numero = int.Parse(Console.ReadLine());

            while (PosibleCentro < Numero)
            {

                PosibleCentro++;
                SumaAnteriores = 0;
                SumaPosteriores = 0;

                for (int i = 1; i < PosibleCentro; i++)
                {
                    SumaAnteriores = SumaAnteriores + i;
                }
                for (int j = PosibleCentro + 1; j <= SumaAnteriores; j++)
                {
                    if ((SumaPosteriores == SumaAnteriores) || (SumaPosteriores > SumaAnteriores))
                    {
                        break;
                    }
                    SumaPosteriores = SumaPosteriores + j;
                }
                if (SumaAnteriores == SumaPosteriores)
                {
                    Console.WriteLine("Los centros numericos hasta el numero {0} son: {1}", Numero, PosibleCentro);
                }
            }
            Console.ReadLine();
        }
    }
}
