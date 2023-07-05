
namespace TamañodeArchivotp1
{
    partial class Ftamanio
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
            this.LNombre = new System.Windows.Forms.Label();
            this.LTamaño = new System.Windows.Forms.Label();
            this.bCalcular = new System.Windows.Forms.Button();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tTamaño = new System.Windows.Forms.TextBox();
            this.bCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(46, 104);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(102, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre del archivo:";
            this.LNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // LTamaño
            // 
            this.LTamaño.AutoSize = true;
            this.LTamaño.Location = new System.Drawing.Point(46, 150);
            this.LTamaño.Name = "LTamaño";
            this.LTamaño.Size = new System.Drawing.Size(118, 13);
            this.LTamaño.TabIndex = 1;
            this.LTamaño.Text = "Tamaño en megabytes:";
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(304, 188);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(99, 35);
            this.bCalcular.TabIndex = 2;
            this.bCalcular.Text = "Calcular tamaño en gb";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(177, 101);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(177, 20);
            this.tNombre.TabIndex = 3;
            // 
            // tTamaño
            // 
            this.tTamaño.Location = new System.Drawing.Point(177, 147);
            this.tTamaño.Name = "tTamaño";
            this.tTamaño.Size = new System.Drawing.Size(177, 20);
            this.tTamaño.TabIndex = 4;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(437, 266);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(108, 30);
            this.bCancelar.TabIndex = 5;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // Ftamanio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 321);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.tTamaño);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.LTamaño);
            this.Controls.Add(this.LNombre);
            this.Name = "Ftamanio";
            this.Text = "Tamaño del archivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LTamaño;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tTamaño;
        private System.Windows.Forms.Button bCancelar;
    }
}

