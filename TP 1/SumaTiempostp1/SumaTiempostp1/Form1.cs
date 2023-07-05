using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaTiempostp1
{
    public partial class FSumarTiempos : Form
    {
        public FSumarTiempos()
        {
            InitializeComponent();
        }

        int hs1, m1, s1;
        int hs2, m2, s2;
        int sumaHoras, sumaMins, sumaSegs;
        int suma;

        private void ttiempo1s_TextChanged(object sender, EventArgs e)
        {

        }

        private void bsuma_Click(object sender, EventArgs e)
        {
            //tiempo 1
            hs1 = Convert.ToInt32(ttiempo1hs.Text);
            m1 = Convert.ToInt32(tTiempo1m.Text);
            s1 = Convert.ToInt32(ttiempo1s.Text);

            //tiempo 2
            hs2 = Convert.ToInt32(ttiempo2hs.Text);
            m2 = Convert.ToInt32(ttiempo2m.Text);
            s2 = Convert.ToInt32(ttiempo2s.Text);

            suma = hs1 * 3600 + m1 * 60 + s1 + hs2 * 3600 + m2 * 60 + s2;

            //sumas por separado
            sumaHoras = suma / 3600;
            sumaMins = (suma % 3600) / 60;
            sumaSegs = (suma % 3600) % 60;


            

            MessageBox.Show("La suma de los 2 tiempos es: " + sumaHoras + " hs " + sumaMins + " mins " + sumaSegs + "");
        }

        private void ttiempo1m_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttiempo2hs_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttiempo2m_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttiempo2s_TextChanged(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ttiempo1hs_TextChanged(object sender, EventArgs e)
        {
            



        }
    }
}
