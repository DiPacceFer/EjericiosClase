using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Punto
    {
        //atributos
        int x;
        int y;
        //metodos
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        //constructor
        public Punto(int x, int y)
        {
            Punto.x = this.GetX();
            Punto.y = this.GetY();
        }
    }
    class Rectangulo
    {
        //atributos
        float area;
        float perimetro;
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;
        //Metodos
        public float Area()
        {

            return;
        }
        public float Perimetro()
        {

        }
        //constructor
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(Math.Abs(vertice1.GetX()), Math.Abs(vertice2.GetY()));
            this.vertice4 = new Punto(Math.Abs(vertice2.GetX()), Math.Abs(vertice1.GetY()));
        }
        public Punto GetVertice1()
        {
            return this.vertice1;
        }
        public Punto GetVertice2()
        {
            return this.vertice2;
        }
        public Punto GetVertice3()
        {
            return this.vertice3;
        }
        public Punto GetVertice4()
        {
            return this.vertice4;
        }
    }
}
