using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperasYPinturas
{
    public class Tempera
    {
        ConsoleColor color;
        string marca;
        int cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.cantidad = cantidad;
            this.marca = marca;
            this.color = color;
        }
        public int GetCantidad()
        {
            return this.cantidad;
        }
        public void SetCantidad(int numero)
        {
            this.cantidad = numero;
        }
        string Mostrar()
        {
            StringBuilder tempera = new StringBuilder();
            tempera.AppendFormat("Tempera marca:{0}\n color: {1}\n cantidad: {2}", this.marca, this.color, this.cantidad);
            return tempera.ToString();
        }
        public static string Mostrar(Tempera tempera)
        {
            return tempera.Mostrar();
        }
        public static bool operator ==(Tempera temp1, Tempera temp2)
        {
            if(((object)temp1)==null && (object)temp2 == null)
            {
                return true;
            }
            else
            {
                if(((object)temp1)!= null && (object)temp2 != null)
                {
                    if (temp1.marca == temp2.marca && temp1.color == temp2.color)
                    {
                        return true;
                    }
                    else
                        return false;

                }
                return false;
            }
        }
        public static bool operator !=(Tempera temp1, Tempera temp2)
        {
            return !(temp1 == temp2);
        }
        public static implicit operator int(Tempera temp1)
        {
            return temp1.GetCantidad();
        }
        public static Tempera operator +(Tempera temp1, Tempera temp2)
        {
            if (temp1 == temp2)
            {
                temp1.cantidad += temp2;
            }
            return temp1;
        }
        public static Tempera operator +(Tempera temp1, int cantidad)
        {
            temp1 += cantidad;
            return temp1;
        }
    }
}
