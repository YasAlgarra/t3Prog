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
    public partial class frmIntroducirRectangulo : Form
    {

        public ListaFiguras lista;
        public frmIntroducirRectangulo(ListaFiguras lista)
        {
            InitializeComponent();

            this.lista = lista;
        }

        //método para obtener datos
        void obtenerRectagulos(out int posX, out int posY, out string color, out int baseT, out int altura)
        {
            posX = int.Parse(txtPosicionX.Text);
            posY = int.Parse(txtPosicionY.Text);
            color = txtColor.Text;
            baseT = int.Parse(txtBase.Text);
            altura = int.Parse(txtAltura.Text);

        }

        private void btnAgregarRectangulo_Click(object sender, EventArgs e)
        {
            int posX, posY, baseT, altura;
            string color;

            //obtenemos datos
            obtenerRectagulos(out posX, out posY, out color, out baseT, out altura);

            //creamos objeto
            Rectangulo rectangulo = new Rectangulo(posX, posY, color, baseT, altura);

            //añadimos a la lista
            lista.AnyadirFigura(rectangulo);


            MessageBox.Show($"Rectángulo añadido: {rectangulo}");

        }
    }
}
