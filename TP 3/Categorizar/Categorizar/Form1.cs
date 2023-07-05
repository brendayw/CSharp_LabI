using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Categorizar
{
    public partial class FCategorizar : Form
    {
        public FCategorizar()
        {
            InitializeComponent();
        }

        int edad;

        private void FCategorizar_Load(object sender, EventArgs e)
        {
            LCantQuerubin.Text = Convert.ToString();
            LCantBenjamin.Text = Convert.ToString();
            LCantInfantil.Text = Convert.ToString();
            LCantCadete.Text = Convert.ToString();
            LCantJuvenil.Text = Convert.ToString();
            LCantAmateur.Text = Convert.ToString();
            LCantVeteranos.Text = Convert.ToString();
        }
        }

        //NOMBRE
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tNombre_TextChanged(object sender, EventArgs e)
        {

        }
        //FIN NOMBRE

        //APELLIDO
        private void LApellido_Click(object sender, EventArgs e)
        {

        }

        private void tApellido_TextChanged(object sender, EventArgs e)
        {

        }
        //FIN APELLIDO


        //FECHA DE NACIMIENTO
        private void LFechaNac_Click(object sender, EventArgs e)
        {

        }

        private void nudDia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudMes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudAnio_ValueChanged(object sender, EventArgs e)
        {

        }
        //FIN FECHA DE NACIMIENTO
       
        //BOTON DE INGRESAR
        private void bIngresar_Click(object sender, EventArgs e)
        {

        }

        //EMPIEZA CODIGO DE CATEGORIAS
        private void LCategorias_Click(object sender, EventArgs e)
        {

        }

        private void LCantQuerubin_Click(object sender, EventArgs e)
        {
            int contador;
            contador = 0;
            if (edad >= 3 && edad <= 5)
            {
                contador = ++contador;
            }
            LCantQuerubin.Text = Convert.ToString();


        }

        private void label1_Click_1(object sender, EventArgs e) //no cambia el label a LCantBenjamin
        {
            int contador;
            contador = 0;
            if (edad >= 6 && edad <= 8)
            {
                contador = ++contador;
            }
        }

        private void LCantInfantil_Click(object sender, EventArgs e)
        {
            int contador;
            contador = 0;
            if (edad >= 9 && edad <= 12)
            {
                contador = ++contador;
            }

        }

        private void LCantCadete_Click(object sender, EventArgs e)
        {
            int contador;
            contador = 0;
            if (edad >= 13 && edad <= 15)
            {
                contador = ++contador;
            }
        }

        private void LCantJuvenil_Click(object sender, EventArgs e)
        {
            int contador;
            contador = 0;
            if (edad >= 16 && edad <= 18)
            {
                contador = ++contador;
            }
        }

        private void LAmateur_Click(object sender, EventArgs e)
        {
            int contador;
            contador = 0;
            if (edad >= 19 && edad < 30)
            {
                contador = ++contador;
            }
        }

        private void LCantVeteranos_Click(object sender, EventArgs e)
        {
            int contador;
            contador = 0;
            if (edad >=30)
            {
                contador = ++contador;
            }
        }
        //TERMINA CODIGO DE CATEGORIAS

        //BOTON CANCELAR
        private void bCancelar_Click(object sender, EventArgs e)
        {

        }
       


    }
}
