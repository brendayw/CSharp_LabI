using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorAbsoluto
{
    public partial class fValorAbsoluto : Form
    {
        public fValorAbsoluto()
        {
            InitializeComponent();
        }

        int num, numb, absoluto;
        double num2;
        int redondeo, num_conv;


        private void bRedondeado_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(tDecimales.Text);

            //num_conv = Convert.ToInt32(num2.Text);

            //redondeo = (num2 > num_conv) ? num_conv : num2;
            //lo pense con redondeo

            


        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(tNumero.Text);
            numb = num * (-1);

            absoluto = (num < 0) ? numb : num;

            MessageBox.Show("El valor absoluto de " + num + " es: " + absoluto + " ");
        }
             

        private void tNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
