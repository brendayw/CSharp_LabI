namespace Trabajo3_Categoria
{
    public partial class FCategoria : Form
    {
        public FCategoria()
        {
            InitializeComponent();
        }

        private void bIngresar_Click(object sender, EventArgs e)
        {
            string nombre = tNombre.Text;
            string categoria;
            string apellido = tApellido.Text;
            int dia = (int)NUDDia.Value;
            int mes = (int)NUDMes.Value;
            int anio = (int)NUDAnio.Value;
            bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0);
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - anio;

            if (nombre.Length == 0)
            {
                MessageBox.Show("El nombre está vacío.", "Error");
                tNombre.Focus();
            }
            else if (apellido.Length == 0)
            {
                MessageBox.Show("El apellido está vacío.", "Error");
                tApellido.Focus();
            }
            else
            {
                if (mes == 2 && dia > 29)
                {
                    MessageBox.Show("El día ingresado es inválido para febrero", "ERROR");
                    NUDDia.Value = 1;
                    NUDMes.Value = 1;
                    NUDAnio.Value = 2000;
                }
                else if (mes == 2 && dia == 29 && !esBisiesto)
                {
                    MessageBox.Show("El año ingresado no es bisiesto: febrero no tiene 29 días", "ERROR");
                    NUDDia.Value = 1;
                    NUDMes.Value = 1;
                    NUDAnio.Value = 2000;
                }
                else if ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && dia > 30)
                {
                    MessageBox.Show("Fecha inválida", "Error");
                    NUDDia.Value = 1;
                    NUDMes.Value = 1;
                    NUDAnio.Value = 2000;
                }
                else
                {
                    if (fechaActual.Month > mes || (fechaActual.Month == mes && fechaActual.Day < dia))
                        edad--;

                    if (edad < 3)
                    {
                        MessageBox.Show("No se puede ingresar: menor de edad", "ERROR");
                        NUDDia.Value = 1;
                        NUDMes.Value = 1;
                        NUDAnio.Value = 2000;
                    }
                    else
                    {
                        if (edad >= 3 && edad <= 5)
                        {
                            string querubin = lCantQuerubin.Text;
                            string valorActual = querubin.Substring(10); // 11 es la posición de la primera cifra
                            int cantQuerubin;

                            if (valorActual.Length == 1)
                            {
                                cantQuerubin = int.Parse(valorActual);
                                cantQuerubin++;
                                lCantQuerubin.Text = "Querubín: " + cantQuerubin.ToString();
                            }
                            else if (valorActual.Length == 2)
                            {
                                cantQuerubin = int.Parse(valorActual);
                                cantQuerubin++;
                                lCantQuerubin.Text = "Querubín: " + cantQuerubin.ToString("D2");
                            }

                            categoria = "Querubín";
                        }
                        else if (edad >= 6 && edad <= 8)
                        {
                            string benjamin = lCantBenjamin.Text;
                            string valorActual = benjamin.Substring(10);
                            int cantBenjamin;

                            if (valorActual.Length == 1)
                            {
                                cantBenjamin = int.Parse(valorActual);
                                cantBenjamin++;
                                lCantBenjamin.Text = "Benjamín: " + cantBenjamin.ToString();
                            }
                            else if (valorActual.Length == 2)
                            {
                                cantBenjamin = int.Parse(valorActual);
                                cantBenjamin++;
                                lCantBenjamin.Text = "Benjamín: " + cantBenjamin.ToString("D2");
                            }

                            categoria = "Benjamín";
                        }
                        else if (edad >= 9 && edad <= 12)
                        {
                            categoria = "Infantil";

                            string infantil = lCantInfantil.Text;
                            string valorActual = infantil.Substring(10);
                            int cantInfantil;

                            if (valorActual.Length == 1)
                            {
                                cantInfantil = int.Parse(valorActual);
                                cantInfantil++;
                                lCantInfantil.Text = "Infantil: " + cantInfantil.ToString();
                            }
                            else if (valorActual.Length == 2)
                            {
                                cantInfantil = int.Parse(valorActual);
                                cantInfantil++;
                                lCantInfantil.Text = "Infantil: " + cantInfantil.ToString("D2");
                            }
                        }
                        else if (edad >= 13 && edad <= 15)
                        {
                            categoria = "Cadete";

                            string cadete = lCantCadete.Text;
                            string valorActual = cadete.Substring(8);
                            int cantCadete;

                            if (valorActual.Length == 1)
                            {
                                cantCadete = int.Parse(valorActual);
                                cantCadete++;
                                lCantCadete.Text = "Cadete: " + cantCadete.ToString();
                            }
                            else if (valorActual.Length == 2)
                            {
                                cantCadete = int.Parse(valorActual);
                                cantCadete++;
                                lCantCadete.Text = "Cadete: " + cantCadete.ToString("D2");
                            }
                        }
                        else if (edad >= 16 && edad <= 18)
                        {
                            categoria = "Juvenil";

                            string juvenil = lCantJuvenil.Text;
                            string valorActual = juvenil.Substring(9);
                            int cantJuvenil;

                            if (valorActual.Length == 1)
                            {
                                cantJuvenil = int.Parse(valorActual);
                                cantJuvenil++;
                                lCantJuvenil.Text = "Juvenil: " + cantJuvenil.ToString();
                            }
                            else if (valorActual.Length == 2)
                            {
                                cantJuvenil = int.Parse(valorActual);
                                cantJuvenil++;
                                lCantJuvenil.Text = "Juvenil: " + cantJuvenil.ToString("D2");
                            }
                        }
                        else if (edad >= 19 && edad <= 30)
                        {
                            categoria = "Amateur";

                            string amateur = lCantAmateur.Text;
                            string valorActual = amateur.Substring(9);
                            int cantAmateur;

                            if (valorActual.Length == 1)
                            {
                                cantAmateur = int.Parse(valorActual);
                                cantAmateur++;
                                lCantAmateur.Text = "Amateur: " + cantAmateur.ToString();
                            }
                            else if (valorActual.Length == 2)
                            {
                                cantAmateur = int.Parse(valorActual);
                                cantAmateur++;
                                lCantAmateur.Text = "Amateur: " + cantAmateur.ToString("D2");
                            }
                        }
                        else
                        {
                            categoria = "Veteranos";

                            string veterano = lCantVeteranos.Text;
                            string valorActual = veterano.Substring(11);
                            int cantVeterano;

                            if (valorActual.Length == 1)
                            {
                                cantVeterano = int.Parse(valorActual);
                                cantVeterano++;
                                lCantVeteranos.Text = "Veteranos: " + cantVeterano.ToString();
                            }
                            else if (valorActual.Length == 2)
                            {
                                cantVeterano = int.Parse(valorActual);
                                cantVeterano++;
                                lCantVeteranos.Text = "Veteranos: " + cantVeterano.ToString("D2");
                            }
                        }

                        MessageBox.Show($"Ingreso Exitoso:\n-{apellido}, {nombre}\n-Edad: {edad} años\n-Categoría: {categoria}");
                        tNombre.Clear();
                        tNombre.Focus();
                        tApellido.Clear();
                        NUDDia.Value = 1;
                        NUDMes.Value = 1;
                        NUDAnio.Value = 2000;
                    }
                }
            }
        }

        private void FCategoria_Load(object sender, EventArgs e)
        {
            int maxValue = DateTime.Today.Year - 2;

            NUDAnio.Maximum = maxValue;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

// Hecho por Franco Pedroncini, Bren Yañez Wagner, Jero Baltian Ortiz y Federico Perez Martinetti