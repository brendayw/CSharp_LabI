using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class FSerie : Form
    {
        #region "variables globales"
        int[] aLista;
        int tope;
        int ultimo;
        #endregion

        public FSerie()
        {
            InitializeComponent();
            tope = 10;
            aLista = new int[tope];
            ultimo = -1;
        }

        private void SacarPromedio(out int suma, out double promedio)
        {
            suma = 0;

            for (int i = 0; i <= ultimo; i++)
            {
                suma += aLista[i];
            }

            promedio = (double)suma / (ultimo + 1);
        }

        private void EliminarOrdenado(int pos, int numero)
        {

            if ((pos<ultimo) && numero == aLista[pos])
            {
                for (int i=pos; i < ultimo; i++)
                {
                    aLista[i] = aLista[i + 1];
                }
                ultimo--;

            } else
            {
                for (int i = 0; i <= ultimo; i++)
                {
                    EliminarOrdenado(i, aLista[i]);
                }
            }
           
        }

        private void bIngresar_Click(object sender, EventArgs e)
        {
            if (ultimo + 1 >= aLista.Length)
            {
                int[] nuevoALista = new int[aLista.Length + 5];
                Array.Copy(aLista, nuevoALista, aLista.Length);
                aLista = nuevoALista;
                tope = aLista.Length - 1;
            }

            int numero = (int)NUDNum.Value;
            int pos = ultimo;

            while ((pos >= 0) && (aLista[pos] > numero))
            {
                aLista[pos + 1] = aLista[pos];
                pos--;
            }

            aLista[pos + 1] = numero;
            ultimo++;

            // Calcular promedio
            int suma;
            double promedio;
            SacarPromedio(out suma, out promedio);

            LCantidad.Text = "Cantidad: " + (ultimo + 1).ToString();
            LPromedio.Text = "Promedio: " + promedio.ToString();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            int pos = 0;
            int numero = (int)NUDNum.Value;
            EliminarOrdenado(pos, numero);
            
        }

        private void bERepetidos_Click(object sender, EventArgs e)
        {
            int pos = 0;
            int numero = (int)NUDNum.Value;
            EliminarOrdenado(pos, numero);
        }
    }
}
