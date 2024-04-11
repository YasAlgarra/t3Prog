using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    public class Triangulo : Figura
    {

        private double mLados;

        private int _Base, _Altura;

        public double Lados
        {

            get { return mLados; }
            set { mLados = value; }

        }

        public int Base
        {

            get { return _Base; }
            set { _Base = value; }

        }

        public int Altura
        {

            get { return _Altura; }
            set { _Altura = value; }

        }

        public Triangulo (int x, int y, string color, double lados, int baseT, int altura) : base(x, y, color)
        {
            mLados = lados;
            _Base = baseT;
            _Altura = altura;
        }


        public override double Area()
        {
            return Base * Altura / 2;

        }

        public override double Perimetro()
        {
            return mLados * 3;
        }

        public override string ToString()
        {
            string texto = base.ToString();

            texto += $"\nLado: {mLados}";

            return texto;
        }

       

    }
}
