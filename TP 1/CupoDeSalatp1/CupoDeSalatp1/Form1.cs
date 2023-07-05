using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CupoDeSalatp1
{
    public partial class FCupoSala : Form
    {
        public FCupoSala()
        {
            InitializeComponent();
        }
        int cupo, cantidad_sala;
        double ocupacion;


        private void tcantidadpersonas_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void bingreso_Click(object sender, EventArgs e)
        {
            cantidad_sala = Convert.ToInt32(Tcantidadpersonas.Text);

            Tcantidadpersonas.Text = (++cantidad_sala).ToString();
    
        }

        private void bsalida_Click(object sender, EventArgs e)
        {
            cantidad_sala = Convert.ToInt32(Tcantidadpersonas.Text);

            Tcantidadpersonas.Text = (--cantidad_sala).ToString();
        }

        private void tcupototal_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bPorcentajeocupacion_Click(object sender, EventArgs e)
        {
            cupo = Convert.ToInt32(Tcupototal.Text);
            cantidad_sala = Convert.ToInt32(Tcantidadpersonas.Text);

            ocupacion = (cantidad_sala * 100) / cupo;

            MessageBox.Show("El porcentaje de ocupación de la sala es de " + ocupacion + "%");
        }
    }
}
