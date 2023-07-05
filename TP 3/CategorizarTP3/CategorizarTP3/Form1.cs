using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CategorizarTP3
{
    public partial class FCategoria : Form
    {
        public FCategoria()
        {
            InitializeComponent();
        }

        /*contador -> variables globales, hecho con strings,
         */



        //string nombre, apellido, categoria;
       // int dia, mes, anio;
        //DateTime fechaActual = DateTime.Today; //copiado de fede
       // int edad;
        //int contador = 0;
        //copie aca las categorias para no tener que convertirlas *mucho codigo*
       // string querubin, bejamin, infantil, cadete, juvenil, amateur, veteranos;

        private void FCategoria_Load(object sender, EventArgs e)
        {
            int maxValue = DateTime.Today.Year - 2;

            nudAnio.Maximum = maxValue;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void LCategorias_Click(object sender, EventArgs e)
        {

        }

        private void LCantQuerubin_Click(object sender, EventArgs e)
        {
   

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            nudAnio.Maximum = (DateTime.Today.Year - 2);
        }

        private void LCantBenjamin_Click(object sender, EventArgs e)
        {
               
        }

        private void tNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void nudDia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bIngresar_Click(object sender, EventArgs e)
        {
            int cantQuerubin = 0;
            int cantBenjamin = 0;
            int cantInfantil = 0;
            int cantCadete = 0;
            int cantJuvenil = 0;
            int cantAmateur = 0;
            int cantVeteranos = 0;
            string nombre = TNombre.Text;
            string categoria = "";
            string apellido = tApellido.Text;
            int dia = (int)nudDia.Value;
            int mes = (int)nudMes.Value;
            int anio = (int)nudAnio.Value;
            bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0);
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - anio;

            if (nombre.Length == 0)
            {
                MessageBox.Show("El nombre está vacío.", "Error");
                TNombre.Focus();
                return;
            }
            else if (apellido.Length == 0)
            {
                MessageBox.Show("El apellido está vacío.", "Error");
                tApellido.Focus();
                return;
            }

            switch (mes)
            {
                case 2:
                    if (mes == 2 && dia > 29)
                    {
                        MessageBox.Show("El día ingresado es inválido para febrero", "ERROR");
                        nudDia.Focus();
                    }
                    else if (mes == 2 && dia == 29 && !esBisiesto)
                    {
                        MessageBox.Show("El año ingresado no es bisiesto: febrero no tiene 29 días", "ERROR");
                        nudDia.Focus();
                    }
                    break;
                case 3:
                case 6:
                case 9:
                case 11:
                    if (dia > 30)
                    {
                        MessageBox.Show("Fecha inválida", "Error");
                    }
                    break;
            }

            if (fechaActual.Month > mes || (fechaActual.Month == mes && fechaActual.Day < dia))
                edad--;

            if (edad >= 3 && edad <= 5)
            {
                categoria = "Querubín";
                cantQuerubin++;
                LCantQuerubin.Text = $"Querubín: {cantQuerubin}.";
            }
            else if (edad >= 6 && edad <= 8)
            {
                categoria = "Benjamín";
                cantBenjamin++;
                LCantBenjamin.Text = $"Benjamín: {cantBenjamin}.";
            }
            else if (edad >= 9 && edad <= 12)
            {
                categoria = "Infantil";
                cantInfantil++;
                LCantInfantil.Text = $"Infantil: {cantInfantil}.";
                /*LCantInfantil.Text = "Cantidad de Vocales: " + (cantInfantil).ToString();*/
            }
            else if (edad >= 13 && edad <= 15)
            {
                categoria = "Cadete";
                cantCadete++;
                LCantCadete.Text = $"Cadete: {cantCadete}.";
            }
            else if (edad >= 16 && edad <= 18)
            {
                categoria = "Juvenil";
                cantJuvenil++;
                LCantJuvenil.Text = $"Juvenil: {cantJuvenil}.";
            }
            else if (edad >= 19 && edad <= 30)
            {
                categoria = "Amateur";
                cantAmateur++;
                LCantAmateur.Text = $"Amateur: {cantAmateur}.";
            }
            else if (edad > 30)
            {
                categoria = "Veteranos";
                cantVeteranos++;
                LCantVeteranos.Text = $"Veteranos: {cantVeteranos}.";
            }
            else
            {
                MessageBox.Show("No se puede ingresar: menor de edad", "ERROR");
                return;
            }

            MessageBox.Show($"Ingreso Exitoso:\n-{apellido}, {nombre}\n-Edad: {edad} años\n-Categoría: {categoria}");
            TNombre.Clear();
            TNombre.Focus();
            tApellido.Clear();
            nudDia.Value = 1;
            nudMes.Value = 1;
            nudAnio.Value = 2000;
        }

        /* nombre = Convert.ToString(TNombre.Text);
         apellido = Convert.ToString(tApellido.Text);
         dia = Convert.ToInt32(nudDia.Value);
         mes = Convert.ToInt32(nudMes.Value);
         anio = Convert.ToInt32(nudAnio.Value);

         /*querubin = Convert.ToString(LCantQuerubin.Text);
         bejamin = Convert.ToString(LCantBenjamin.Text);
         infantil = Convert.ToString(LCantInfantil.Text);
         cadete = Convert.ToString(LCantCadete.Text);
         juvenil = Convert.ToString(LCantJuvenil.Text);
         amateur = Convert.ToString(LCantAmateur.Text);
         veteranos = Convert.ToString(LCantAmateur.Text); */

        //calculo de edad
        // edad = fechaActual.Year - anio;

        //contador de jugadores


        //seleccion de categoria
        /* if (edad >= 3 && edad <= 5)
         {
             categoria = "Querubin";
             contador = ++contador;
         }
         else if (edad >= 6 && edad <= 8)
         {
             categoria = "Bejamin";
             contador = ++contador;
         }
         else if (edad >= 9 && edad <= 12)
         {
             categoria = "Infantil";
             contador = ++contador;
         }
         else if (edad >= 13 && edad <= 15)
         {
             categoria = "Cadete";
             contador = ++contador;
         }
         else if (edad >= 16 && edad <= 18)
         {
             categoria = "Juvenil";
             contador = ++contador;
         }
         else if (edad >= 19 && edad <= 30)
         {
             categoria = "Amateur";
             contador = ++contador;
         }
         else if (edad > 30)
         {
             categoria = "Veteranos";
             contador = ++contador;
         }

         //Mensajes de error y si los datos son correctos
         if (nombre == "")
         {
             MessageBox.Show("Debe ingresar un nombre");
             TNombre.Focus();
         } else if (apellido == "") {
             MessageBox.Show("Debe ingresar un apellido");
             tApellido.Focus();
         } else if (dia==0 || dia > 31 || mes ==0 || mes >12 || anio > 2023)
         {
             MessageBox.Show("Debe ingresar una fecha valida");
             nudDia.Focus();
         } else if (anio % 4 == 0 && anio % 100 !=0) //copiado de Fede
         {
             if (mes == 2 && dia > 29) 
             {
                 MessageBox.Show("Debe ingresar un dia correcto, el año ingresado es biciesto");
                 nudDia.Focus();
             }
         } else

         {
             MessageBox.Show($"Ingreso exitoso: \n" +
                             $"{apellido}, {nombre} \n" +
                             $"Edad: {edad} \n" +
                             $"Categoria: {categoria}"); // usar interpolacion $
         }*/
    }


   

}
