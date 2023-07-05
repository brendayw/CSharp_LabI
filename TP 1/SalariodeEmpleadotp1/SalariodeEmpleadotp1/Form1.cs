using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalariodeEmpleadotp1
{
    public partial class FSueldoEmpleado : Form
    {
        public FSueldoEmpleado()
        {
            InitializeComponent();
        }

        private void lnombre_Click(object sender, EventArgs e)
        {

        }

        private void SueldoEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            string nombre;
            int ingreso;
            double tarifa, horas, dias, sueldo, retenciones, antiguedad, agregado;
            double sueldo_final;

            nombre = Convert.ToString(tnombre.Text);
            ingreso = Convert.ToInt32(tingreso.Text);
            tarifa = Convert.ToDouble(ttarifa.Text);
            horas = Convert.ToDouble(thoraspordia.Text);
            dias = Convert.ToDouble(tdiaspormes.Text);

            sueldo = (tarifa * horas) * dias;
            retenciones = (20 * sueldo) / 100;
            antiguedad = (2023 - ingreso); //años de aniguedad
            agregado = (1.5 * sueldo) / 100;
            sueldo_final = sueldo - retenciones + agregado;

            MessageBox.Show("El sueldo del empleado " + nombre + " es " + sueldo_final + " pesos");
        }
    }
}
