using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3
{
    public class ListaFiguras //no hace falta poner los ":" porque no hereda de nadie
    {
        List<Figura> listaFiguras = new List<Figura>();

        public void AnyadirFigura(Figura figura)
        {
            listaFiguras.Add(figura);
        }

        public string MostrarTodas()
        {
            string resultado = "Todas las figuras:\n\n";
            int contador = 1;

            //haciendo testeos:
            if (listaFiguras.Count == 0)
            {
                resultado += "Aún no hay figuras en la lista";
            }
            else
            {
                foreach (Figura figura in listaFiguras)
                {
                    resultado += $"Figura número {contador}\n";
                    resultado += $"{figura.ToString()}\n\n";

                    contador++;
                }
            }

            return resultado;
        }

        public string MostrarCirculos()
        {
            string resultado = "Listado Círculos:\n\n";
            int contador = 1;

            foreach (Figura figura in listaFiguras)
            {
                if (figura is Circulo)
                {
                    resultado += $"Círculo número {contador}\n";
                    resultado += $"{figura.ToString()}\n";
                    resultado += $"Área: {figura.Area()}\n";
                    resultado += $"Perímetro: {figura.Perimetro()}\n\n";

                    contador++;
                }
                
            }

            return resultado;

        }

        public string MostrarCuadrados()
        {
            string resultado = "Listado Cuadrados:\n\n";

            int contador = 1;

            foreach (Figura figura in listaFiguras)
            {
                if (figura is Cuadrado)
                {
                    resultado += $"Cuadrado número {contador}\n";
                    resultado += $"{figura.ToString()}\n";
                    resultado += $"Área: {figura.Area()}\n";
                    resultado += $"Perímetro: {figura.Perimetro()}\n\n";

                    contador++;
                }

            }

            return resultado;

        }

        public string MostrarTriangulos()
        {
            string resultado = "Listado Triángulos:\n\n";

            int contador = 1;

            foreach (Figura figura in listaFiguras)
            {
                if (figura is Triangulo)
                {
                    resultado += $"Triángulo número {contador}\n";
                    resultado += $"{figura.ToString()}\n";
                    resultado += $"Área: {figura.Area()}\n";
                    resultado += $"Perímetro: {figura.Perimetro()}\n\n";

                    contador++;
                }

            }

            return resultado;

        }

        public string MostrarRectangulos()
        {
            string resultado = "Listado Rectángulos:\n\n";

            int contador = 1;

            foreach (Figura figura in listaFiguras)
            {
                if (figura is Rectangulo)
                {
                    resultado += $"Rectángulo número {contador}\n";
                    resultado += $"{figura.ToString()}\n";
                    resultado += $"Área: {figura.Area()}\n";
                    resultado += $"Perímetro: {figura.Perimetro()}\n\n";

                    contador++;
                }

            }

            return resultado;

        }

        public string MostrarHexagonos()
        {
            string resultado = "Listado Hexágonos:\n\n";

            int contador = 1;

            foreach (Figura figura in listaFiguras)
            {
                if (figura is Hexagono)
                {
                    resultado += $"Hexágono número {contador}\n";
                    resultado += $"{figura.ToString()}\n";
                    resultado += $"Área: {figura.Area()}\n";
                    resultado += $"Perímetro: {figura.Perimetro()}\n\n";

                    contador++;
                }

            }

            return resultado;

        }


        /*//función para mostrar el perímetro de los cuadrados
        public double sumaPerimetrosCuadrados()
        {
            double suma = 0;

            foreach (Figura figura in listaFiguras)
            {
                if (figura.GetType() == typeof(Cuadrado))
                {
                    //IMPORTANTE: hacer el casting a FIGURA para poder acceder al método Perímetro que es una clase perteneciente a CUADRADO pero no a las demás
                    suma += ((Cuadrado)figura).Perimetro();
                }
            }

            return suma;
        }*/

    }
}
