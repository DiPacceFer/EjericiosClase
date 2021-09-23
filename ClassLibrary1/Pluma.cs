using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Pluma
    {
        string marca;
        Tinta tinta;
        int cantidad;

        //constructor
        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 1;
        }
        public Pluma(string marca) : this()
        {
            this.marca = marca;
        }
        public Pluma(string marca, int cantidad):this(marca)
        {
            this.cantidad = cantidad;
        }

        string Mostrar()
        {
            return "Marca: " + this.marca + "\nCantidad" + this.cantidad.ToString() + "\nTinta: " + (string)this.tinta + "\n";
        }
        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            return pluma.tinta == tinta;
        }
        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }
        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta)
            {
                pluma.cantidad++;
            }
            return pluma;
        }
        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta)
            {
                pluma.cantidad--;
            }
            return pluma;
        }
        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }
    }
}
