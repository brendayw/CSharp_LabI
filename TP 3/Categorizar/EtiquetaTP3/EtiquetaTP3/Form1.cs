using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtiquetaTP3
{
    public partial class FEtiqueta : Form
    {
        public FEtiqueta()
        {
            InitializeComponent();
        }

        int nud;
        

        private void FEtiqueta_Load(object sender, EventArgs e)
        {

        }

        private void nudLetra_ValueChanged(object sender, EventArgs e)
        {
            nud = Convert.ToInt32(nudLetra.Value);
            
            if (nud == 1)
            {
                LEtiqueta.Font = new Font("Avocados", LEtiqueta.Font.Size);
                LLetra.Text = "Avocados";

            } else if (nud == 2)
            {
                LEtiqueta.Font = new Font("Inf Free", LEtiqueta.Font.Size);
                LLetra.Text = "Ink Free";
                
            } else if (nud == 3)
            {
                LEtiqueta.Font = new Font("Rockwell", LEtiqueta.Font.Size);
                LLetra.Text = "Rockwell";
            } else if (nud == 4)
            {
                LEtiqueta.Font = new Font("Showcard Gothic", LEtiqueta.Font.Size);
                LLetra.Text = "Showcard Gothic";
                /*LLetra.Font = new Font("Showcard Gothic", LLetra.Font.Size);
                LLetra.Text = "Showcard Gothic";*/ 
                // ese codigo comentado muetras tambien como es el tipo de letra al lado del numero de opcion
            }
        }

        private void tTexto_TextChanged(object sender, EventArgs e)
        {
            LEtiqueta.Text = tTexto.Text;
            tTexto.Text = tTexto.Text.ToUpper();
        }

        private void BTamanioMenos_Click(object sender, EventArgs e)
        {
            if (LEtiqueta.Font.Size >=10)
            {
                LEtiqueta.Font = new Font(LEtiqueta.Font.FontFamily, LEtiqueta.Font.Size - 2);
            } else
            {
                MessageBox.Show("Haz alcanzado el tamaño minimo");
            }
        }

        private void LCambia_Click(object sender, EventArgs e)
        {

        }

        private void BColor_Click(object sender, EventArgs e)
        {
            switch (LEtiqueta.ForeColor.Name)
            {
                case "Black": case "DarkTurquoise":
                    LEtiqueta.ForeColor = Color.OrangeRed;
                    break;
                case "OrangeRed":
                    LEtiqueta.ForeColor = Color.Violet;
                    break;
                case "Violet":
                    LEtiqueta.ForeColor = Color.Gold;
                    break;
                case "Gold":
                    LEtiqueta.ForeColor = Color.DarkTurquoise;
                    break;
                default:
                    LEtiqueta.ForeColor = Color.Black;
                    break;
            }
        }

        private void LEtiqueta_Click(object sender, EventArgs e)
        {
            
        }

        private void BTamanioMas_Click(object sender, EventArgs e)
        {
            if (LEtiqueta.Font.Size <= 20)
            {
                LEtiqueta.Font = new Font(LEtiqueta.Font.FontFamily, LEtiqueta.Font.Size + 2);
            } else
            {
                MessageBox.Show("Haz alcanzado el tamaño maximo");
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
