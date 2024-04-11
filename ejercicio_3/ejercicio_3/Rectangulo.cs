using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    public class Rectangulo : Figura
    {

        private int _Base, _Altura;

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

        public Rectangulo(int x, int y, string color, int baseR, int altura) : base(x, y, color)
        {
            _Base = baseR;
            _Altura = altura;
        }

        public override double Area()
        {
            return Base * Altura;

        }

        public override double Perimetro()
        {
            return 2 * Altura + 2 * Base;
        }

        public override string ToString()
        {
            string texto = base.ToString();


            return texto;
        }

    }
}
