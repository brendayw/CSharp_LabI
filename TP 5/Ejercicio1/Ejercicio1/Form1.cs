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
        int[] aSerie;
        int ultimo;
        int tope;
        #endregion

        public FSerie()
        {
            InitializeComponent();
            tope = 10;
            aSerie = new int[tope];
            ultimo = -1;
        }

        private void FSerie_Load(object sender, EventArgs e)
        {

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bIngresar_Click(object sender, EventArgs e)
        {
            int suma = 0;
            double promedio = 0;
            int num = (int)NUDNum.Value;

            if (ultimo + 1 == tope)
            {
                // Si se alcanza el límite del arreglo, se agrega automáticamente 5 lugares
                int[] nuevoASerie = new int[tope + 5];
                // Copiar elementos del arreglo original al nuevo arreglo
                for (int i = 0; i <= ultimo; i++)
                {
                    nuevoASerie[i] = aSerie[i];
                }
                // Asignar el nuevo arreglo como el arreglo principal
                aSerie = nuevoASerie;
            }

            aSerie[++ultimo] = num;

            suma += num;
            promedio = (double)suma / (ultimo + 1);
            promedio = Math.Round(promedio, 2); // redondea a dos decimales

            //mayor o menor de los numeros ingresados
            int mayor = aSerie[0];
            int menor = aSerie[0];
            int total = ultimo + 1; //cantidad de numeros en el arreglo= (ultimo +1);

            for (int i = 1; i < total; i++)
            {
                if (aSerie[i] > mayor)
                {
                    mayor = aSerie[i];
                }
                if (aSerie[i] < menor)
                {
                    menor = aSerie[i];
                }
            }

            //labels
            LCantidad.Text = "Cantidad: " + (ultimo + 1).ToString();
            LPromedio.Text = "Promedio: " + promedio.ToString("N2");
            LMayor.Text = "Número Mayor: " + mayor.ToString();
            LMenor.Text = "Número Menor: " + menor.ToString();

        }

        private void bListar_Click(object sender, EventArgs e)
        {
            string listado = "";
            

            for (int i=0; i <= ultimo; i++) //busca el ultimo lugar ocupado en el array
            {
                listado += aSerie[i] + "\n";
            }

            MessageBox.Show($"Los números del arreglos son: \n {listado}", 
                "Listado de serie", MessageBoxButtons.OK, MessageBoxIcon.Information);

        } //termina boton listar

        private void bEliminarNum_Click(object sender, EventArgs e)
        {
            int pos = -1;
            int num = (int)NUDNum.Value;

            int cont = 0;

            if (ultimo == -1)
            {
                MessageBox.Show("No se encontro el numero " + num, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pos = 0;

                while ((pos <= ultimo) && (aSerie[pos]!=num))
                {
                    pos++;
                }

                if (pos <= ultimo) // lo encontro
                {
                    aSerie[pos] = aSerie[ultimo];
                    ultimo--;
                    cont++;

                    LCantidad.Text = "Cantidad: " + (ultimo + 1 - cont).ToString();

                    MessageBox.Show($"Se han eliminado {cont} números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show($"No se encontro el numero ha eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
          
           

        } // termina boton eliminar numero

        private void bEliminarRepe_Click(object sender, EventArgs e) //FUNCIONA BIEN
        {
            int num = (int)NUDNum.Value;
            int contador = 0;

            int pos = 0;

            while ((pos <= ultimo) && (aSerie[pos] != num))
            {
                pos++;
            }

            if (pos <= ultimo) // lo encontro
            {
                aSerie[pos] = aSerie[ultimo];
                ultimo--;
                contador++;

                LCantidad.Text = "Cantidad: " + (ultimo + 1 - contador).ToString();

                MessageBox.Show($"Se han eliminado {contador} numeros repetidos", "Aviso",MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show($"No se encontraron numeros repetidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        } //termina boton eliminar repetidos

        private void bResetear_Click(object sender, EventArgs e) //FUNCIONA BIEN
        {

            ultimo = -1;

            //Resetea contadores
            LMenor.Text = "Número Menor: ";
            LMayor.Text = "Número Mayor: ";
            LCantidad.Text = "Cantidad: 0";
            LPromedio.Text = "Promedio: ";

        } //termina boton resetear

        private void bParImpar_Click(object sender, EventArgs e) //FUNCIONA BIEN
        {
            int num = (int)NUDNum.Value;
            string pares = "";
            string impares = "";

            int ultimoIndice = aSerie.Length - 1;

            for (int i = 0; i < aSerie.Length; i++) //busca el ultimo lugar ocupado en el array
            {
                if (aSerie[i] != 0)
                {
                    ultimoIndice = i;
                }
            }

            for (int i = 0; i <= ultimoIndice; i++)
            {
                if (aSerie[i] % 2 == 0) // Si el número es par
                {
                    pares += aSerie[i] + ", ";
                }
                else // Si el número es impar
                {
                    impares += aSerie[i] + ", ";
                }
            }

            MessageBox.Show($"Los números pares son {pares} \n" +
                $"Los números impares son: {impares}", 
                "Números eliminados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } //termina boton par/impar

        private void bInvertir_Click(object sender, EventArgs e) //FUNCIONA BIEN
        {
            int longitud = aSerie.Length;

            for (int i = 0; i < longitud / 2; i++)
            {
                int temp = aSerie[i];
                aSerie[i] = aSerie[longitud - 1 - i];
                aSerie[longitud - 1 - i] = temp;
            }

            //imprimir listado invertido
            string listado = "";
            bool primerElemento = true;

            for (int i = aSerie.Length - 1; i >= 0; i--)
            {
                if (aSerie[i] != 0 || primerElemento)
                {
                    if (primerElemento)
                    {
                        listado += aSerie[i].ToString();
                        primerElemento = false;
                    }
                    else
                    {
                        listado = aSerie[i] + ", " + listado;
                    }
                }
            }

            MessageBox.Show($"Los números del arreglos son:  {listado}",
                "Listado de serie invertido", MessageBoxButtons.OK, MessageBoxIcon.Information);

        } //termina boton invertir
    }
}
