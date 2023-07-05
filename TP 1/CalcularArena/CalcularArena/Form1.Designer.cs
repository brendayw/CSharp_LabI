
namespace CalcularArena
{
    partial class FCalcularArena
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LAncho = new System.Windows.Forms.Label();
            this.LAlto = new System.Windows.Forms.Label();
            this.TAncho = new System.Windows.Forms.TextBox();
            this.TAlto = new System.Windows.Forms.TextBox();
            this.LRevoque = new System.Windows.Forms.Label();
            this.TRevoque = new System.Windows.Forms.TextBox();
            this.BCalcular = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LAncho
            // 
            this.LAncho.AutoSize = true;
            this.LAncho.Location = new System.Drawing.Point(98, 78);
            this.LAncho.Name = "LAncho";
            this.LAncho.Size = new System.Drawing.Size(97, 13);
            this.LAncho.TabIndex = 0;
            this.LAncho.Text = "Ancho de la pared:";
            // 
            // LAlto
            // 
            this.LAlto.AutoSize = true;
            this.LAlto.Location = new System.Drawing.Point(98, 137);
            this.LAlto.Name = "LAlto";
            this.LAlto.Size = new System.Drawing.Size(84, 13);
            this.LAlto.TabIndex = 1;
            this.LAlto.Text = "Alto de la pared:";
            // 
            // TAncho
            // 
            this.TAncho.Location = new System.Drawing.Point(251, 75);
            this.TAncho.Name = "TAncho";
            this.TAncho.Size = new System.Drawing.Size(201, 20);
            this.TAncho.TabIndex = 2;
            // 
            // TAlto
            // 
            this.TAlto.Location = new System.Drawing.Point(251, 137);
            this.TAlto.Name = "TAlto";
            this.TAlto.Size = new System.Drawing.Size(201, 20);
            this.TAlto.TabIndex = 3;
            // 
            // LRevoque
            // 
            this.LRevoque.AutoSize = true;
            this.LRevoque.Location = new System.Drawing.Point(98, 204);
            this.LRevoque.Name = "LRevoque";
            this.LRevoque.Size = new System.Drawing.Size(133, 26);
            this.LRevoque.TabIndex = 4;
            this.LRevoque.Text = "Metros cubicos necesarios\r\n     por metro cuadrado:";
            // 
            // TRevoque
            // 
            this.TRevoque.Location = new System.Drawing.Point(251, 210);
            this.TRevoque.Name = "TRevoque";
            this.TRevoque.Size = new System.Drawing.Size(201, 20);
            this.TRevoque.TabIndex = 5;
            // 
            // BCalcular
            // 
            this.BCalcular.Location = new System.Drawing.Point(387, 246);
            this.BCalcular.Name = "BCalcular";
            this.BCalcular.Size = new System.Drawing.Size(114, 27);
            this.BCalcular.TabIndex = 6;
            this.BCalcular.Text = "Calcular";
            this.BCalcular.UseVisualStyleBackColor = true;
            this.BCalcular.Click += new System.EventHandler(this.BCalcular_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(527, 297);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(87, 24);
            this.BCancelar.TabIndex = 7;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            // 
            // FCalcularArena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 333);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BCalcular);
            this.Controls.Add(this.TRevoque);
            this.Controls.Add(this.LRevoque);
            this.Controls.Add(this.TAlto);
            this.Controls.Add(this.TAncho);
            this.Controls.Add(this.LAlto);
            this.Controls.Add(this.LAncho);
            this.Name = "FCalcularArena";
            this.Text = "Calcular la arena necesaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAncho;
        private System.Windows.Forms.Label LAlto;
        private System.Windows.Forms.TextBox TAncho;
        private System.Windows.Forms.TextBox TAlto;
        private System.Windows.Forms.Label LRevoque;
        private System.Windows.Forms.TextBox TRevoque;
        private System.Windows.Forms.Button BCalcular;
        private System.Windows.Forms.Button BCancelar;
    }
}

