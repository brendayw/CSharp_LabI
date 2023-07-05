
namespace FraseTP4
{
    partial class FFrase
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
            this.labelFrase = new System.Windows.Forms.Label();
            this.tFrase = new System.Windows.Forms.TextBox();
            this.labelreemplazar = new System.Windows.Forms.Label();
            this.bEliminarEspacios = new System.Windows.Forms.Button();
            this.bPasarOracion = new System.Windows.Forms.Button();
            this.tReemplazarLetra = new System.Windows.Forms.TextBox();
            this.tReemplazarPor = new System.Windows.Forms.TextBox();
            this.bReemplazar = new System.Windows.Forms.Button();
            this.bVocales = new System.Windows.Forms.Button();
            this.bPalabras = new System.Windows.Forms.Button();
            this.LCantVocales = new System.Windows.Forms.Label();
            this.LCantPalabras = new System.Windows.Forms.Label();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFrase
            // 
            this.labelFrase.AutoSize = true;
            this.labelFrase.Location = new System.Drawing.Point(71, 35);
            this.labelFrase.Name = "labelFrase";
            this.labelFrase.Size = new System.Drawing.Size(36, 13);
            this.labelFrase.TabIndex = 0;
            this.labelFrase.Text = "Frase:";
            // 
            // tFrase
            // 
            this.tFrase.Location = new System.Drawing.Point(113, 32);
            this.tFrase.Name = "tFrase";
            this.tFrase.Size = new System.Drawing.Size(365, 20);
            this.tFrase.TabIndex = 1;
            this.tFrase.TextChanged += new System.EventHandler(this.tFrase_TextChanged);
            // 
            // labelreemplazar
            // 
            this.labelreemplazar.AutoSize = true;
            this.labelreemplazar.Location = new System.Drawing.Point(71, 141);
            this.labelreemplazar.Name = "labelreemplazar";
            this.labelreemplazar.Size = new System.Drawing.Size(153, 13);
            this.labelreemplazar.TabIndex = 2;
            this.labelreemplazar.Text = "Reemplazar:                        por";
            // 
            // bEliminarEspacios
            // 
            this.bEliminarEspacios.Location = new System.Drawing.Point(113, 61);
            this.bEliminarEspacios.Name = "bEliminarEspacios";
            this.bEliminarEspacios.Size = new System.Drawing.Size(168, 29);
            this.bEliminarEspacios.TabIndex = 3;
            this.bEliminarEspacios.Text = "&Eliminar Espacios";
            this.bEliminarEspacios.UseVisualStyleBackColor = true;
            this.bEliminarEspacios.Click += new System.EventHandler(this.bEliminarEspacios_Click);
            // 
            // bPasarOracion
            // 
            this.bPasarOracion.Location = new System.Drawing.Point(310, 61);
            this.bPasarOracion.Name = "bPasarOracion";
            this.bPasarOracion.Size = new System.Drawing.Size(168, 29);
            this.bPasarOracion.TabIndex = 4;
            this.bPasarOracion.Text = "Pasar a tipo de &oración";
            this.bPasarOracion.UseVisualStyleBackColor = true;
            this.bPasarOracion.Click += new System.EventHandler(this.bPasarOracion_Click);
            // 
            // tReemplazarLetra
            // 
            this.tReemplazarLetra.Location = new System.Drawing.Point(149, 138);
            this.tReemplazarLetra.MaxLength = 1;
            this.tReemplazarLetra.Name = "tReemplazarLetra";
            this.tReemplazarLetra.Size = new System.Drawing.Size(44, 20);
            this.tReemplazarLetra.TabIndex = 5;
            // 
            // tReemplazarPor
            // 
            this.tReemplazarPor.Location = new System.Drawing.Point(230, 138);
            this.tReemplazarPor.MaxLength = 1;
            this.tReemplazarPor.Name = "tReemplazarPor";
            this.tReemplazarPor.Size = new System.Drawing.Size(44, 20);
            this.tReemplazarPor.TabIndex = 6;
            // 
            // bReemplazar
            // 
            this.bReemplazar.Location = new System.Drawing.Point(338, 129);
            this.bReemplazar.Name = "bReemplazar";
            this.bReemplazar.Size = new System.Drawing.Size(140, 29);
            this.bReemplazar.TabIndex = 7;
            this.bReemplazar.Text = "&Reemplazar";
            this.bReemplazar.UseVisualStyleBackColor = true;
            this.bReemplazar.Click += new System.EventHandler(this.bReemplazar_Click);
            // 
            // bVocales
            // 
            this.bVocales.Location = new System.Drawing.Point(74, 181);
            this.bVocales.Name = "bVocales";
            this.bVocales.Size = new System.Drawing.Size(132, 29);
            this.bVocales.TabIndex = 8;
            this.bVocales.Text = "Cantidad de &vocales";
            this.bVocales.UseVisualStyleBackColor = true;
            this.bVocales.Click += new System.EventHandler(this.bVocales_Click);
            // 
            // bPalabras
            // 
            this.bPalabras.Location = new System.Drawing.Point(74, 216);
            this.bPalabras.Name = "bPalabras";
            this.bPalabras.Size = new System.Drawing.Size(132, 29);
            this.bPalabras.TabIndex = 9;
            this.bPalabras.Text = "Cantidad de &palabras";
            this.bPalabras.UseVisualStyleBackColor = true;
            this.bPalabras.Click += new System.EventHandler(this.bPalabras_Click);
            // 
            // LCantVocales
            // 
            this.LCantVocales.AutoSize = true;
            this.LCantVocales.Location = new System.Drawing.Point(250, 189);
            this.LCantVocales.Name = "LCantVocales";
            this.LCantVocales.Size = new System.Drawing.Size(108, 13);
            this.LCantVocales.TabIndex = 10;
            this.LCantVocales.Text = "Cantidad de Vocales:";
            // 
            // LCantPalabras
            // 
            this.LCantPalabras.AutoSize = true;
            this.LCantPalabras.Location = new System.Drawing.Point(250, 224);
            this.LCantPalabras.Name = "LCantPalabras";
            this.LCantPalabras.Size = new System.Drawing.Size(110, 13);
            this.LCantPalabras.TabIndex = 11;
            this.LCantPalabras.Text = "Cantidad de palabras:";
            // 
            // bCerrar
            // 
            this.bCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bCerrar.Location = new System.Drawing.Point(0, 271);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(596, 34);
            this.bCerrar.TabIndex = 12;
            this.bCerrar.Text = "&Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // FFrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCerrar;
            this.ClientSize = new System.Drawing.Size(596, 305);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.LCantPalabras);
            this.Controls.Add(this.LCantVocales);
            this.Controls.Add(this.bPalabras);
            this.Controls.Add(this.bVocales);
            this.Controls.Add(this.bReemplazar);
            this.Controls.Add(this.tReemplazarPor);
            this.Controls.Add(this.tReemplazarLetra);
            this.Controls.Add(this.bPasarOracion);
            this.Controls.Add(this.bEliminarEspacios);
            this.Controls.Add(this.labelreemplazar);
            this.Controls.Add(this.tFrase);
            this.Controls.Add(this.labelFrase);
            this.Name = "FFrase";
            this.Text = "Frase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFrase;
        private System.Windows.Forms.TextBox tFrase;
        private System.Windows.Forms.Label labelreemplazar;
        private System.Windows.Forms.Button bEliminarEspacios;
        private System.Windows.Forms.Button bPasarOracion;
        private System.Windows.Forms.TextBox tReemplazarLetra;
        private System.Windows.Forms.TextBox tReemplazarPor;
        private System.Windows.Forms.Button bReemplazar;
        private System.Windows.Forms.Button bVocales;
        private System.Windows.Forms.Button bPalabras;
        private System.Windows.Forms.Label LCantVocales;
        private System.Windows.Forms.Label LCantPalabras;
        private System.Windows.Forms.Button bCerrar;
    }
}

