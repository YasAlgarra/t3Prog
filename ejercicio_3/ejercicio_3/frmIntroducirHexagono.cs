using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ejercicio_3
{
    public partial class frmIntroducirHexagono : Form
    {

        ListaFiguras lista;
        public frmIntroducirHexagono(ListaFiguras lista)
        {
            InitializeComponent();
            this.lista = lista;
        }

        //método para obtener hexágono

        public void obtenerHexagonos(out int posX, out int posY, out string color, out int lado)
        {
            posX = int.Parse(txtPosicionX.Text);
            posY = int.Parse(txtPosicionY.Text);
            color = txtColor.Text;
            lado = int.Parse(txtLado.Text);

        }

        private void btnAgregarHexagono_Click(object sender, EventArgs e)
        {
            int posX, posY, lado;
            string color;

            //obtener hexágono
            obtenerHexagonos(out posX, out posY,out color, out lado);

            //crear objeto
            Hexagono hexagono = new Hexagono(posX, posY, color, lado);

            //añadimos figura
            lista.AnyadirFigura(hexagono);

            MessageBox.Show($"Hexágono añadido: {hexagono}");
        }
    }
}
