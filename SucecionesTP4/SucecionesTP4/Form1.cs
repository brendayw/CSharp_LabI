using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SucecionesTP4
{
    public partial class FSuceciones : Form
    {
        public FSuceciones()
        {
            InitializeComponent();
        }

        int multiplo, fibo;
        string salidaMultiplicar, salidaFibonacci;

        private void bCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta=MessageBox.Show("Desea salir?", "Cerrar", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question); //mensaje, titulo, botones

            if (respuesta == DialogResult.Yes)
            {
                Close();
            } else
            {
                
            }
            
        }

        private void bTablaMultiplicar_Click(object sender, EventArgs e)
        {
            multiplo = Convert.ToInt32(nudTabla.Value);
            

            int contador, resultado;
            salidaMultiplicar = $@"Tabla de Multiplicar \n {multiplo}";

            for (contador = 0; contador <= 10; contador++)
            {

                resultado = multiplo * contador;
                salidaMultiplicar += $"{multiplo} * {contador++} = {resultado}";

            }

            LRespuesta.Visible = true;
        }

        private void bFibonacci_Click(object sender, EventArgs e)
        {
            

            fibo = Convert.ToInt32(nudFibonacci.Value);

            int contador, resultado;
            string salidaFibonacci = $"Secuencia de Fibonacci \n {fibo}";

            for (contador = 0; contador < 30; contador++)
            {
                int temp = contador;
                contador = fibo;
                resultado = temp + fibo;

            }

            LRespuesta.Visible = true;
        }

        private void nudTabla_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void LRespuesta_Click(object sender, EventArgs e)
        {


            LRespuesta.Text = salidaMultiplicar;
            LRespuesta.Text = salidaFibonacci;
            LRespuesta.Visible = true;

        }
    }

        
    }
