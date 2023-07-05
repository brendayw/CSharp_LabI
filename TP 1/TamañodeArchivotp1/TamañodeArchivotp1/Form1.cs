using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamañodeArchivotp1
{
    public partial class Ftamanio : Form
    {
        public Ftamanio()
        {
            InitializeComponent();
        }

        double tamaño;
        string nombre;
        double gb;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombre = Convert.ToString(tNombre.Text);
            tamaño = Convert.ToDouble(tTamaño.Text);

            gb = (tamaño * 1) / 1024;

            MessageBox.Show("El tamaño de archivo " + nombre + " en gb es: " + gb + " ");
        }
    }
}
