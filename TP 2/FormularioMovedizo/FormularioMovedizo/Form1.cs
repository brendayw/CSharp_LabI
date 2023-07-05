using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioMovedizo
{
    public partial class FMovedizo : Form
    {
        public FMovedizo()
        {
            InitializeComponent();
        }

        private void FMovedizo_Click(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "Gris": case "Verde":
                    if (Text == "Gris")
                    {
                        BackColor = Color.Red;
                        Text = "Rojo";
                        Size = new Size(285, 260);
                        Location = new Point(+10, -10);
                    }
                    break;
                case "Rojo":
                    if (Text == "Rojo")
                    {
                        BackColor = Color.Blue;
                        Text = "Azul";
                        Size = new Size(320, 255);
                        Location = new Point(-15, 0);
                    }
                    break;
                case "Azul":
                    if (Text == "Azul")
                    {
                        BackColor = Color.YellowGreen;
                        Text = "Verde";
                        Size = new Size(295, 235);
                        Location = new Point(-5, +15);
                    }
                    break;
            }
        }
    }
}
