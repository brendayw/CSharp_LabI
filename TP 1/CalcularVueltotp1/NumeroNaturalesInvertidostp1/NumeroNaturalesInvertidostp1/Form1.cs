using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroNaturalesInvertidostp1
{
    public partial class FNumerosNaturales : Form
    {
        public FNumerosNaturales()
        {
            InitializeComponent();
        }

        double a, b, aux;

        private void binvertir_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(tnumeroA.Text);
            b = Convert.ToDouble(tNumeroB.Text);

            aux = a;
            a = b;
            b = aux;

            MessageBox.Show("Los números invertidos son: \n A = " + a + " \n B = " + b + " ");

        }
    }
}
