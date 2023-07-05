using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IngresoTP4
{
    public partial class FIngreso : Form
    {
        public FIngreso()
        {
            InitializeComponent();
        }


        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("Desea salir?", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
            else
            {

            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            string nombre = tNombres.Text;
            string apellido = tApellidos.Text;
            string contra = tContrasenia.Text;
            string confirma = tConfirmacion.Text;
            string email = tEmail.Text;

            //bools del email
            Boolean arroba = email.Contains("@");
            Boolean dot = email.Contains(".");


            //bools de la contraseña
            Boolean numero = false;
            Boolean letra = false;
            Boolean simbolo = false;

            int n = nombre.Length;
            int a = apellido.Length;
            int c = contra.Length;
            int cf = confirma.Length;
            int em = email.Length;


            while ( n <= 0 || a <= 0 || c <=0 || cf <= 0 || em <= 0 )
            {
                MessageBox.Show("Hay campos sin rellenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;

            }

            


            if ((nombre != "") && (apellido != "") && (contra != "") && (confirma != "") && (email != ""))
            {
                
                while (!arroba || !dot) //se muestra igual aunque tenga el arroba
                {
                    MessageBox.Show("Ingrese un email valido", "Email no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tEmail.Focus();
                    break;
                }

                while (contra != confirma || c < 8)
                {
                    if (contra != confirma)
                    {
                        MessageBox.Show("Las contraseñas no coinciden", "Contraseñas no validas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tConfirmacion.Focus();
                    } else
                    {
                        MessageBox.Show("La contraseña debe tener minimo 8 caracteres", "Contraseña no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tContrasenia.Focus();
                    }
                    break;
                    
                }


                foreach (char caracter in contra)
                {
                    if (char.IsLetter(caracter) && char.IsDigit(caracter) && !char.IsLetterOrDigit(caracter))

                        MessageBox.Show("La contraseña debe contener al menos una letra, un numero y un simbolo", 
                            "Contraseña no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tContrasenia.Focus();
                }

            } 
            
            if ((nombre != "") && (apellido != "") && (contra != "") && (confirma != "") && (email != "") && (contra == confirma) && c >= 8 && !numero && !letra && !simbolo)
            {
                
              /*  char inicialNombre = nombre[0], inicialApellido = apellido[0];*/

                string [] inicialesNombre = nombre.Split(' '), inicialesApellido = apellido.Split(' ');

                string primerN = nombre[0];
                string segundoN = nombre[1];
                char inicialNombre = primerN[0], inicialNombreS = segundoN[0];

                string primerA = apellido[a - 1];
                char inicialApellido = primerA[0];
                

                MessageBox.Show($"Ingreso exitoso \n " +
                                $"Su usuario asignado es: {inicialNombre}{inicialApellido}\n" + //falta saber si son compuestos
                                $" ", "Exitoso", MessageBoxButtons.OK); /*asignar usuario*/
            
            }

        }
    }
}
