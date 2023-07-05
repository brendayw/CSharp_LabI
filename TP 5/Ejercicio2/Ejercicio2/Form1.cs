using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class FDeportes : Form
    {
        #region "variables globales"
            string[] aDeportes;
            int ultimo;
            int tope;
        #endregion

        public FDeportes()
        {
            InitializeComponent();
            tope = 10; //cantidad de deportes que admite
            aDeportes = new string[tope]; //crea el arreglo deportes
            ultimo = -1; //inicializa el arreglo en VACIO
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            string deporte = Convert.ToString(tDeporte.Text.Trim().ToLower());

            if (ultimo + 1 == tope) //si el arreglo esta lleno
            {
                MessageBox.Show("No hay más lugar en la lista \n" +
                    "No se puede agregar el deporte " + deporte, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tDeporte.Focus();

            } else if (deporte.Length == 0) //si no se agrego un deporte
            {
                MessageBox.Show("Falta completar el campo deporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tDeporte.Focus();

            } else // si todo es correcto, se guarda
            {
                aDeportes[++ultimo] = deporte;
                tDeporte.Clear(); //limpia el control
            }

            LCantitdad.Text = "Cantidad de Deportes: " + (ultimo + 1).ToString();
        } //fin del boton agregar

        private void bListar_Click(object sender, EventArgs e)
        {
            string listado = "";

            for (int i = 0; i <= ultimo; i++) //busca el ultimo lugar ocupado en el array
            {
                listado += aDeportes[i] + "\n";
            }

            MessageBox.Show($"Los deportes son: \n" +
                $"{listado}",
                "Listado de deportes", MessageBoxButtons.OK, MessageBoxIcon.Information);

        } // fin del boton listar

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        } //fin del boton cerrar

        private void bEliminar_Click(object sender, EventArgs e)
        {
            int pos = -1;
            string deporte = Convert.ToString(tDeporte.Text.Trim().ToLower());

            if (ultimo == -1)
            {
                MessageBox.Show("No se encontro el deporte " + deporte, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tDeporte.Focus();
            } 
            else if (deporte == "")
            {
                MessageBox.Show("Falta completar el campo deporte ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tDeporte.Focus();
            }
            else
            {
                pos = 0;

                while ((pos <= ultimo) && (aDeportes[pos] != deporte))
                {
                    pos++;
                }

                if (pos <= ultimo) // lo encontro
                {
                    aDeportes[pos] = aDeportes[ultimo];
                    ultimo--;
                    
                    LCantitdad.Text = "Cantidad de Deportes: " + (ultimo + 1).ToString();

                    MessageBox.Show($"Se han eliminado {deporte} correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show($"No se encontro el deporte ha eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        } // fin del boton eliminar

        private void bResetear_Click(object sender, EventArgs e)
        {
            ultimo = -1;

            LCantitdad.Text = "Cantidad de Deportes: 0";
        } //fin del boton resetear

        private void bBuscar_Click(object sender, EventArgs e)
        {
            int pos;
            string deporte = Convert.ToString(tDeporte.Text.Trim().ToLower());

            if (ultimo == -1)
            {
                MessageBox.Show($"No hay deportes guardados como {deporte}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tDeporte.Focus();
            } else if (deporte == "")
            {
                MessageBox.Show($"Falta completar el campo deporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tDeporte.Focus();
            } else
            {
                pos = 0;

                while ((pos <= ultimo) && (aDeportes[pos] != deporte))
                {
                    pos++;
                }

                if (pos <= ultimo)
                {
                    MessageBox.Show($"{deporte} se encontro en la posicion {pos + 1}", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tDeporte.Clear();
                }
            }
        } // fin del boton buscar
    }
}
