using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FraseTP4
{
    public partial class FFrase : Form
    {
        public FFrase()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("Desea salir?", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question); //mensaje, titulo, botones

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
            else
            {

            }

        }

        private void bEliminarEspacios_Click(object sender, EventArgs e)
        {
            // string = fraseActualizada = "";
            // int i = 0;
            //tFrase.Text.Trim 
            // si el que estoy ahora no es un espacio, 
            /*while (i < frase.Length)
            {
                if (
                    )
            }*/

            string frase = tFrase.Text;
           
            if (frase == "")
            {
                MessageBox.Show("Por favor, ingrese una frase", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tFrase.Focus();
            }
            else
            {
                string eliminar = tFrase.Text.Trim();
                for  (int i = 0; i < eliminar.Length; i++)
                {
                    eliminar = eliminar.Replace("   "," ").Trim();
                }

                
                MessageBox.Show($"{eliminar}", "Frase sin espacios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /*            do
            {condicion   } while (frase != "")            */
        }

        private void bPasarOracion_Click(object sender, EventArgs e)
        {
            string frase;

            frase = Convert.ToString(tFrase.Text);

            MessageBox.Show(frase.Replace(" ", ""));
        }

        private void bReemplazar_Click(object sender, EventArgs e)
        {
            string frase, letra, por;

            frase = Convert.ToString(tFrase.Text);
            letra = Convert.ToString(tReemplazarLetra.Text);
            por = Convert.ToString(tReemplazarPor.Text);

            if (letra == "" || por == "")
            {
                MessageBox.Show("Por favor, ingrese la letra que quiere reemplazar y un caracter por la cual reemplazarla");
                tReemplazarLetra.Focus();
            }
            else
            {
                MessageBox.Show(frase.Replace(letra, por));
            }
            

        }

        private void bVocales_Click(object sender, EventArgs e)
        {
            int contador = 0, i;
            string frase = Convert.ToString(tFrase.Text);

            for (i = 0; i <(frase.Length); i++)
            {
                if (frase[i]=='a'|| frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
                {
                    contador++;
                }
                
            }
          /*Console.WriteLine("Cantidad de Vocales: " + contador);*/
         /* Console.ReadLine();*/

            LCantVocales.Text = "Cantidad de Vocales: " + contador.ToString();
        }

        private void bPalabras_Click(object sender, EventArgs e)
        {
            int contador = 1, i = 0;
            string frase = Convert.ToString(tFrase.Text);

            while (i < frase.Length)
            {
                if (frase[i] == ' ')
                {
                    contador = contador + 1;

                }
                i = i + 1;
            }

            LCantPalabras.Text = "Cantidad de palabras: " + contador.ToString();

        }

        private void tFrase_TextChanged(object sender, EventArgs e)
        {
            

        }

    }
}
