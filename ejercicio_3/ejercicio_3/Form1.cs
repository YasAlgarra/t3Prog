using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Diagnostics;


namespace ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //lista de firguas (no discrimina, de igual que sea círculo, cuadrado...)

        ListaFiguras lista = new ListaFiguras();
        
        private void btnIntroducirCirculo_Click(object sender, EventArgs e)
        {

            try
            {
                // Creamos un objeto del formulario de círculos
                frmIntroducirCirculo fCirculos = new frmIntroducirCirculo(lista);

                // Abrimos el formulario
                fCirculos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al abrir el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIntroducirCuadrado_Click(object sender, EventArgs e)
        {
            try
            {
                // Creamos un objeto del formulario de círculos
                frmIntroducirCuadrado fCuadrados = new frmIntroducirCuadrado(lista);

                // Abrimos el formulario
                fCuadrados.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al abrir el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void button1_Click(object sender, EventArgs e) //autorrelleno
        {
            //crear objetos e introducirlos - círculos y cuadrados

            //lista.AnyadirFigura(//poner aquí objetos);

            Circulo circulo1 = new Circulo(50, 50, "Rojo", 20);
            Circulo circulo2 = new Circulo(150, 100, "Verde", 30);
            Circulo circulo3 = new Circulo(250, 150, "Azul", 40);

            // Crear cuadrados
            Cuadrado cuadrado1 = new Cuadrado(100, 200, "Amarillo", 25);
            Cuadrado cuadrado2 = new Cuadrado(200, 250, "Naranja", 35);
            Cuadrado cuadrado3 = new Cuadrado(300, 300, "Marrón", 45);

            //Crear triángulos
            Triangulo triangulo1 = new Triangulo(30, 50, "Lila", 25, 2, 5);
            Triangulo triangulo2 = new Triangulo(75, 25, "Azul", 35, 4, 6);
            Triangulo triangulo3 = new Triangulo(21, 30, "Negro", 45, 3, 2);

            //Crear rectángulos
            Rectangulo rectangulo1 = new Rectangulo(100, 200, "Amarillo", 2, 5);
            Rectangulo rectangulo2 = new Rectangulo(200, 250, "Naranja", 3, 5);
            Rectangulo rectangulo3 = new Rectangulo(75, 25, "Azul",  4, 6);

            //Crear hexágonos
            Hexagono hexagono1 = new Hexagono(300, 300, "Marrón", 45);
            Hexagono hexagono2 = new Hexagono(150, 100, "Verde", 30);
            Hexagono hexagono3 = new Hexagono(100, 200, "Amarillo", 25);


            // Agregar figuras a la lista
            lista.AnyadirFigura(circulo1);
            lista.AnyadirFigura(circulo2);
            lista.AnyadirFigura(circulo3);
            lista.AnyadirFigura(cuadrado1);
            lista.AnyadirFigura(cuadrado2);
            lista.AnyadirFigura(cuadrado3);
            lista.AnyadirFigura(triangulo1);
            lista.AnyadirFigura(triangulo2);
            lista.AnyadirFigura(triangulo3);
            lista.AnyadirFigura(rectangulo1);
            lista.AnyadirFigura(rectangulo2);
            lista.AnyadirFigura(rectangulo3);
            lista.AnyadirFigura(hexagono1);
            lista.AnyadirFigura(hexagono2);
            lista.AnyadirFigura(hexagono3);

        }

        private void btnMostrarFiguras_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(lista.MostrarTodas());
        }

        private void btnMostrarCirculos_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(lista.MostrarCirculos());
        }

        private void btnMostrarCuadrados_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(lista.MostrarCuadrados());
        }

        private void btnIntroducirTriangulo_Click(object sender, EventArgs e)
        {
            try
            {
                // Creamos un objeto del formulario de círculos
                frmIntroducirTriangulo fTriangulos = new frmIntroducirTriangulo(lista);

                // Abrimos el formulario
                fTriangulos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al abrir el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIntroducirRectangulo_Click(object sender, EventArgs e)
        {
            try
            {
                // Creamos un objeto del formulario de círculos
                frmIntroducirRectangulo fRectangulos = new frmIntroducirRectangulo(lista);

                // Abrimos el formulario
                fRectangulos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al abrir el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIntroducirHexagono_Click(object sender, EventArgs e)
        {
            try
            {
                // Creamos un objeto del formulario de círculos
                frmIntroducirHexagono fHexagonos = new frmIntroducirHexagono(lista);

                // Abrimos el formulario
                fHexagonos.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al abrir el formulario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarTriangulos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lista.MostrarTriangulos());
        }

        private void btnMostrarRectangulos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lista.MostrarRectangulos());
        }

        private void btnMostrarHexagono_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lista.MostrarHexagonos());
        }
    }
}
