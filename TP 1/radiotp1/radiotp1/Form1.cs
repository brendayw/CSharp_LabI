using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiotp1
{
    public partial class fRadio : Form
    {
        public fRadio()
        {
            InitializeComponent();
        }

        double perimetro;
        double radio;
        double area;
        string expresion;
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            radio = Convert.ToDouble(tRadio.Text);
            perimetro = 2 * 3.14 * radio;
            expresion = Convert.ToString(tExpresion.Text);
            MessageBox.Show("El perimetro del circulo es: "+perimetro+" "+expresion+" ");
        }

        private void bArea_Click(object sender, EventArgs e)
        {
            radio = Convert.ToDouble(tRadio.Text);
            area = 3.14 * (radio * radio);
            expresion = Convert.ToString(tExpresion.Text);
            MessageBox.Show("El area del circulo es: "+area+" "+expresion+" ");
        }

        private void tRadio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
