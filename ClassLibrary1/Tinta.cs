using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Tinta
    {
        ConsoleColor color;
        ETipoTinta tipo;

        //constructor
        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tipo = ETipoTinta.Comun;
        }
        public Tinta(ConsoleColor color):this()
        {
            this.color = color;
        }
        /*public Tinta(ETipoTinta tipo)
        {
            this.tipo = tipo;
        }*/
        public Tinta(ConsoleColor color, ETipoTinta tipo):this(color) 
        {
            //this.color = color;
            this.tipo = tipo;
        }
        public Tinta(ETipoTinta tipo, ConsoleColor color)
        {
            this.color = color;
            this.tipo = tipo; 
        }
        string Mostrar()
        {
            return "Tinta: " + this.tipo + " Color: " + this.color;
        }
        
        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }
        public static bool operator ==(Tinta tin1, Tinta tin2)
        {
            return tin1.color == tin2.color && tin1.tipo == tin2.tipo;
        }
        public static bool operator !=(Tinta tin1, Tinta tin2)
        {
            return !(tin1 == tin2);
        }
        public static explicit operator string(Tinta tinta)
        {
            return tinta.Mostrar();
        }
    }
    
}
