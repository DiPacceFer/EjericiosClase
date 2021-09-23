using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Pesos
    {
        double cantidad;
        static double cotizRespectoDolar;

        public Pesos()
        {
            Pesos.cotizRespectoDolar = 66;
        }
        public Pesos(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar((p.cantidad / Pesos.GetCotizacion()));
        }
        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dolar)p);
        }
        public static implicit operator Pesos(double p)
        {
            return new Pesos(p);
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            return p == (Pesos)e;
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.cantidad == p2.cantidad;
        }
        public static bool operator ==(Pesos p, Dolar d)
        {
            return d == (Dolar)p;
        }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(d == (Dolar)p);
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            return p.cantidad = +((Pesos)e).cantidad;
        }
        public static Pesos operator +(Dolar d, Pesos p)
        {
            return p.cantidad = +((Pesos)d).cantidad;
        }
        public static Pesos operator -(Pesos p, Euro e)
        {
            return p.cantidad = -((Pesos)e).cantidad;
        }
        public static Pesos operator -(Dolar d, Pesos p)
        {
            return p.cantidad = -((Pesos)d).cantidad;
        }
    }
}
