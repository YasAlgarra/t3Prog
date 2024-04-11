using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;


namespace ejercicio_3
{
    public abstract class Figura //las clases abstractas permiten declarar métodos abstractos (que no tienen cuerpo) para poder sobreescribirlas en las hijas
    {
        private int mPosicionX, mPosicionY;
        private string mColor;

        public string Color //nos permite obtener y asignar el color
        {
            get { return mColor; }
            set { mColor = value; }
        }

        //constructor de figura
        public Figura(int x, int y, string color)
        {
            mPosicionX = x;
            mPosicionY = y;
            mColor = color;
        }

        public virtual string QuienSoy() // con la palabra "virutal" nos permite sobreescribir el método en sus clases heredadas
        {
            return "Soy una figura";
        }

        public override string ToString()
        {
            string texto;

            texto = $"\nPosición X: {mPosicionX} \nPosición Y: {mPosicionY} \nColor: {mColor}";

            return texto;
        }

        public abstract double Area();

        public virtual string Visualizar()
        {
            string resultado = "";

            resultado += $"\nPosición X:  {mPosicionX}\n";
            resultado += $"\nPosición Y: {mPosicionY}\n";
            resultado += $"\nColor: {mColor}\n";

            return resultado;
        }

        public abstract double Perimetro();


    }
}
