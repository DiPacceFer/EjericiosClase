using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerClase01_09
{
    class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public Cosa()
        {
            this.entero = 10;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }
        public Cosa(string a) : this()
        {
            this.cadena = a;
        }
        public Cosa(int b, string a) : this(a)
        {
            this.entero = b;
        }
        public Cosa(DateTime c, int b, string a) : this(b, a)
        {
            this.fecha = c;
        }


        public void EstablecerValor(int a)
        {
            this.entero = a;
        }
        public void EstablecerValor(string a)
        {
            this.cadena = a;
        }
        public void EstablecerValor(DateTime a)
        {
            this.fecha = a;
        }
        private string mostrar()
        {
            return this.entero.ToString() + " " + this.cadena + " " + this.fecha.ToShortDateString();
        }
        public static string mostrar(Cosa a)
        {
            return a.mostrar();
        }
    }
}
