using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP3_Etiqueta
{
    public partial class FEtiqueta : Form
    {
        public FEtiqueta()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void FEtiqueta_Load(object sender, EventArgs e)
        {
            lEtiqueta.Top = 75;
            lEtiqueta.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        }

        private void TTexto_TextChanged(object sender, EventArgs e)
        {
            string texto = TTexto.Text;

            texto = TTexto.Text.ToUpper();
            lEtiqueta.Text = texto;
            centrarEtiqueta();
        }


        private void bColor_Click(object sender, EventArgs e)
        {
            switch (lEtiqueta.ForeColor.Name)
               {
               case "Black":
                   lEtiqueta.ForeColor = Color.Purple;
                   break;
               case "Purple":
                   lEtiqueta.ForeColor = Color.DarkCyan;
                   break;
               case "DarkCyan":
                   lEtiqueta.ForeColor = Color.BlueViolet;
                   break;
               case "BlueViolet":
                   lEtiqueta.ForeColor = Color.LimeGreen;
                   break;
               default:
                   lEtiqueta.ForeColor = Color.Black;
                   break; 
               } 
        }

        //Controla que la etiqueta quede centrada en el lugar especificado, sin importar el cambio de tamaño o fuente
        private void centrarEtiqueta()
        {           
            lEtiqueta.Left = (this.ClientSize.Width - lEtiqueta.Width) / 2;

            int labelTop = -275;
            int formHeight = this.ClientSize.Height;
            int labelHeight = lEtiqueta.Height;
            int newTop = labelTop + (formHeight - labelTop - labelHeight) / 2;

            lEtiqueta.Top = newTop;
        }

        private void bTamanioMas_Click(object sender, EventArgs e)
        {
            float tamanioFuente = lEtiqueta.Font.Size;

            if (tamanioFuente <= 20)
            {
                lEtiqueta.Font = new Font(lEtiqueta.Font.FontFamily, lEtiqueta.Font.Size + 2);
                bTamanioMenos.Enabled = true;
                centrarEtiqueta();               
            }
            else
            {
                bTamanioMas.Enabled = false;
            }
        }

        private void bTamanioMenos_Click(object sender, EventArgs e)
        {
            float tamanioFuente = lEtiqueta.Font.Size;

            if (tamanioFuente >= 10)
            {
                lEtiqueta.Font = new Font(lEtiqueta.Font.FontFamily, lEtiqueta.Font.Size - 2);
                bTamanioMas.Enabled = true;
                centrarEtiqueta();
            }
            else
            {
                bTamanioMenos.Enabled = false;
            }
        }

        private void NUDLetra_ValueChanged(object sender, EventArgs e)
        {
            switch (NUDLetra.Value)
            {
                case 1:
                    lEtiqueta.Font = new Font("Century Gothic", lEtiqueta.Font.Size);
                    LLetra.Text = "Century Gothic";
                    centrarEtiqueta();
                    break;
                case 2:
                    lEtiqueta.Font = new Font("Impact", lEtiqueta.Font.Size);
                    LLetra.Text = "Impact";
                    centrarEtiqueta();
                    break;
                case 3:
                    lEtiqueta.Font = new Font("Script MT", lEtiqueta.Font.Size);
                    LLetra.Text = "Script MT";
                    centrarEtiqueta();
                    break;
                case 4:
                    lEtiqueta.Font = new Font("Segoe Script", lEtiqueta.Font.Size);
                    LLetra.Text = "Segoe Script";
                    centrarEtiqueta();
                    break;
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

// Hecho por Franco Pedroncini, Bren Yañez Wagner, Jero Baltian Ortiz y Federico Perez Martinetti