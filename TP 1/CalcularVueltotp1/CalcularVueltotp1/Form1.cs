using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularVueltotp1
{
    public partial class FCalcularVuelto : Form
    {
        public FCalcularVuelto()
        {
            InitializeComponent();
        }

        string nombre;
        double valor;
        double monto;
        double vuelto;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bVuelto_Click(object sender, EventArgs e)
        {
            nombre = Convert.ToString(tNombre.Text);
            valor = Convert.ToDouble(tValor.Text);
            monto = Convert.ToDouble(tMonto.Text);

            vuelto = monto - valor;

            MessageBox.Show("El dinero a devolver al cliente " + nombre + " es: " + vuelto + " pesos");


        }
    }
}
