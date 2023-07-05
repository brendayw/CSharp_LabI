
namespace ValorAbsoluto
{
    partial class fValorAbsoluto
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
            this.LInformacion = new System.Windows.Forms.Label();
            this.tNumero = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.LDecimales = new System.Windows.Forms.Label();
            this.tDecimales = new System.Windows.Forms.TextBox();
            this.bRedondeado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LInformacion
            // 
            this.LInformacion.AutoSize = true;
            this.LInformacion.Location = new System.Drawing.Point(78, 44);
            this.LInformacion.Name = "LInformacion";
            this.LInformacion.Size = new System.Drawing.Size(98, 13);
            this.LInformacion.TabIndex = 0;
            this.LInformacion.Text = "Ingrese un número:";
            // 
            // tNumero
            // 
            this.tNumero.Location = new System.Drawing.Point(225, 41);
            this.tNumero.Name = "tNumero";
            this.tNumero.Size = new System.Drawing.Size(176, 20);
            this.tNumero.TabIndex = 1;
            this.tNumero.TextChanged += new System.EventHandler(this.tNumero_TextChanged);
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(451, 32);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(89, 36);
            this.bCalcular.TabIndex = 2;
            this.bCalcular.Text = "    Calcular \r\nvalor absoluto";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // LDecimales
            // 
            this.LDecimales.AutoSize = true;
            this.LDecimales.Location = new System.Drawing.Point(78, 128);
            this.LDecimales.Name = "LDecimales";
            this.LDecimales.Size = new System.Drawing.Size(189, 13);
            this.LDecimales.TabIndex = 3;
            this.LDecimales.Text = "Ingrese un número con dos decimales:";
            // 
            // tDecimales
            // 
            this.tDecimales.Location = new System.Drawing.Point(286, 125);
            this.tDecimales.Name = "tDecimales";
            this.tDecimales.Size = new System.Drawing.Size(200, 20);
            this.tDecimales.TabIndex = 4;
            // 
            // bRedondeado
            // 
            this.bRedondeado.Location = new System.Drawing.Point(521, 117);
            this.bRedondeado.Name = "bRedondeado";
            this.bRedondeado.Size = new System.Drawing.Size(97, 35);
            this.bRedondeado.TabIndex = 5;
            this.bRedondeado.Text = "Calcular número \r\n  redondeado";
            this.bRedondeado.UseVisualStyleBackColor = true;
            this.bRedondeado.Click += new System.EventHandler(this.bRedondeado_Click);
            // 
            // fValorAbsoluto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 338);
            this.Controls.Add(this.bRedondeado);
            this.Controls.Add(this.tDecimales);
            this.Controls.Add(this.LDecimales);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tNumero);
            this.Controls.Add(this.LInformacion);
            this.Name = "fValorAbsoluto";
            this.Text = "Valor Absoluto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LInformacion;
        private System.Windows.Forms.TextBox tNumero;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Label LDecimales;
        private System.Windows.Forms.TextBox tDecimales;
        private System.Windows.Forms.Button bRedondeado;
    }
}

