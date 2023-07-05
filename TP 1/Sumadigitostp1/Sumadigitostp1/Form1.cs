using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumadigitostp1
{
    public partial class FSuma : Form
    {
        public FSuma()
        {
            InitializeComponent();
        }
        int num, suma;
        int digito1, digito2;

        private void bSuma_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(tnumero.Text);

            digito1 = num % 10;
            num = num / 10;
            digito2 = num % 10;

            suma = digito1 + digito2;

            MessageBox.Show("La suma de los digitos del número ingreado es " + suma + " ");



        }
    }
}
