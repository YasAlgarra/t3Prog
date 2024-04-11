using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_3
{
    public partial class frmIntroducirCuadrado : Form
    {
        public ListaFiguras lista;
        public frmIntroducirCuadrado(ListaFiguras lista)
        {
            InitializeComponent();
            this.lista = lista;
        }

        //subprograma para obtener datos del cuadrado
        void obtenerCuadrado(out int posX, out int posY, out string color, out int lado)
        {
            posX = int.Parse(txtPosicionX.Text);
            posY = int.Parse(txtPosicionY.Text);
            color = txtColor.Text;
            lado = int.Parse(txtLado.Text);

        }

        private void btnAgregarCuadrado_Click(object sender, EventArgs e)
        {
            int posX, posY, lado;
            string color;

            //para obtener datos del círculo
            obtenerCuadrado(out posX, out posY, out color, out lado);


            //nuevo objeto
            Cuadrado cuadrado = new Cuadrado(posX, posY, color, lado);

            //añadir a la lista de FIGURAS
            lista.AnyadirFigura(cuadrado);

            MessageBox.Show($"Cuadrado añadido: {cuadrado}");

        }
    }
}
