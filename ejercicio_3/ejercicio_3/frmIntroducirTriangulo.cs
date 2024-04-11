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
    public partial class frmIntroducirTriangulo : Form

    {

        public ListaFiguras lista;
        public frmIntroducirTriangulo(ListaFiguras lista)
        {
            InitializeComponent();

            this.lista = lista;
        }

        //subprograma para obtener datos del triángulo
        void obtenerTriangulo(out int posX, out int posY, out string color, out double lado, out int baseT, out int altura)
        {
            posX = int.Parse(txtPosicionX.Text);
            posY = int.Parse(txtPosicionY.Text);
            color = txtColor.Text;
            lado = int.Parse (txtLado.Text);
            baseT = int.Parse (txtBase.Text);
            altura = int.Parse(txtAltura.Text);


        }

        private void btnAgregarTriangulo_Click(object sender, EventArgs e)
        {
            int posX, posY, baseT, altura;
            double lado;
            string color;

            //obtener datos triángulo
            obtenerTriangulo(out posX, out posY,out color, out lado,out baseT, out altura);

            //crear nuevo objeto
            Triangulo triangulo = new Triangulo(posX, posY, color, lado, baseT, altura);

            //añadimos a la lista figuras
            lista.AnyadirFigura(triangulo);

            MessageBox.Show($"Triángulo añadido: {triangulo}");

        }
    }
}
