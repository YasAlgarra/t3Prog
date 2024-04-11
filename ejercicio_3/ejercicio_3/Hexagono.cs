using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    public class Hexagono : Figura
    {
        private int mLado;

        public int Lado
        {

            get { return mLado; }
            set { mLado = value; }

        }

        public Hexagono (int x, int y, string color, int lado) : base(x, y, color)
        {
            mLado = lado;
        }

        public override double Perimetro()
        {
            return mLado * 6;
        }

        public override double Area()
        {
            return (3 * Math.Sqrt(3) * Lado * Lado) / 2;

        }

        public override string ToString()
        {
            string texto = base.ToString();

            texto += $"\nLado: {mLado}";

            return texto;
        }

    }
}
