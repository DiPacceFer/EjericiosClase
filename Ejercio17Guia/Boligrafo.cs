using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafo
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        void SetTinta(short tinta)
        {
            if(tinta > 0)
            {   
                if((this.tinta + tinta) <= cantidadTintaMaxima)
                {
                    this.tinta += tinta;
                }
                else
                {
                    this.tinta = cantidadTintaMaxima;
                }
            }
            else
            {
                if((this.tinta + tinta) >= 0)
                {
                    this.tinta += tinta;
                }
                else
                {
                    this.tinta = 0;
                }
            }

        }
        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            int resto = this.tinta;
            this.SetTinta(gasto);
            dibujo = "";
            if (gasto < 0)
            {
                for (int i = resto; i > this.tinta; i--)
                {
                    dibujo = dibujo + "*";
                }
                if ((resto+gasto) < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
