using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer13Guia
{
    class Conversor
    {
        public static string DecimalBinario(int a)
        {
            int b;
            string binario = "";
            b = a;
            do
            {
                binario = ((b % 2).ToString()) + binario;
                b = b / 2;
                if(b<=1)
                {
                    binario = b + binario;
                }
            } while (b > 1);

            return binario;
        }
        public static int BinarioDecimal(string a)
        {
            int numeroDe = 0;
            double x = 1;
            int tam = a.Length;
            int b = tam;
            int d;
            for(int j=0;j<tam;j++)
            {
                char c;
                x = Math.Pow(2, j);
                c = a[b-1];
                d = (int)(c - '0');
                numeroDe = numeroDe + (int)x * d;
                b--;
            }
            return numeroDe;
        }
    }
}
