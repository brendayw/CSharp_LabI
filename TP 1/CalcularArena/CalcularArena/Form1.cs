using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularArena
{
    public partial class FCalcularArena : Form
    {
        public FCalcularArena()
        {
            InitializeComponent();
        }

        double ancho, alto, revoque, arena;

        private void BCalcular_Click(object sender, EventArgs e)
        {
            ancho = Convert.ToDouble(TAncho.Text);
            alto = Convert.ToDouble(TAlto.Text);
            revoque = Convert.ToDouble(TRevoque.Text);

            arena = (ancho * alto) * revoque;

            MessageBox.Show("La cantidad de arena necesaria es " + arena + " metros cubicos");

        }
    }
}
