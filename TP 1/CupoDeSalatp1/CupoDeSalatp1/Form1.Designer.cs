
namespace CupoDeSalatp1
{
    partial class FCupoSala
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
            this.LCupototal = new System.Windows.Forms.Label();
            this.Lcantidadpersonas = new System.Windows.Forms.Label();
            this.Tcupototal = new System.Windows.Forms.TextBox();
            this.Tcantidadpersonas = new System.Windows.Forms.TextBox();
            this.BPorcentajeocupacion = new System.Windows.Forms.Button();
            this.Bingreso = new System.Windows.Forms.Button();
            this.Bsalida = new System.Windows.Forms.Button();
            this.Bcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LCupototal
            // 
            this.LCupototal.AutoSize = true;
            this.LCupototal.Location = new System.Drawing.Point(59, 62);
            this.LCupototal.Name = "LCupototal";
            this.LCupototal.Size = new System.Drawing.Size(106, 13);
            this.LCupototal.TabIndex = 0;
            this.LCupototal.Text = "Cupo total de la sala:";
            this.LCupototal.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lcantidadpersonas
            // 
            this.Lcantidadpersonas.AutoSize = true;
            this.Lcantidadpersonas.Location = new System.Drawing.Point(59, 111);
            this.Lcantidadpersonas.Name = "Lcantidadpersonas";
            this.Lcantidadpersonas.Size = new System.Drawing.Size(150, 13);
            this.Lcantidadpersonas.TabIndex = 1;
            this.Lcantidadpersonas.Text = "Cantidad de personas en sala:";
            // 
            // Tcupototal
            // 
            this.Tcupototal.Location = new System.Drawing.Point(248, 59);
            this.Tcupototal.Name = "Tcupototal";
            this.Tcupototal.Size = new System.Drawing.Size(168, 20);
            this.Tcupototal.TabIndex = 2;
            this.Tcupototal.TextChanged += new System.EventHandler(this.tcupototal_TextChanged);
            // 
            // Tcantidadpersonas
            // 
            this.Tcantidadpersonas.Location = new System.Drawing.Point(248, 108);
            this.Tcantidadpersonas.Name = "Tcantidadpersonas";
            this.Tcantidadpersonas.Size = new System.Drawing.Size(168, 20);
            this.Tcantidadpersonas.TabIndex = 3;
            this.Tcantidadpersonas.TextChanged += new System.EventHandler(this.tcantidadpersonas_TextChanged);
            // 
            // BPorcentajeocupacion
            // 
            this.BPorcentajeocupacion.Location = new System.Drawing.Point(63, 193);
            this.BPorcentajeocupacion.Name = "BPorcentajeocupacion";
            this.BPorcentajeocupacion.Size = new System.Drawing.Size(102, 36);
            this.BPorcentajeocupacion.TabIndex = 4;
            this.BPorcentajeocupacion.Text = "Porcentaje de \r\n  ocupación";
            this.BPorcentajeocupacion.UseVisualStyleBackColor = true;
            this.BPorcentajeocupacion.Click += new System.EventHandler(this.bPorcentajeocupacion_Click);
            // 
            // Bingreso
            // 
            this.Bingreso.Location = new System.Drawing.Point(194, 193);
            this.Bingreso.Name = "Bingreso";
            this.Bingreso.Size = new System.Drawing.Size(102, 36);
            this.Bingreso.TabIndex = 5;
            this.Bingreso.Text = "Ingresa una persona";
            this.Bingreso.UseVisualStyleBackColor = true;
            this.Bingreso.Click += new System.EventHandler(this.bingreso_Click);
            // 
            // Bsalida
            // 
            this.Bsalida.Location = new System.Drawing.Point(314, 193);
            this.Bsalida.Name = "Bsalida";
            this.Bsalida.Size = new System.Drawing.Size(102, 36);
            this.Bsalida.TabIndex = 6;
            this.Bsalida.Text = "Sale una persona";
            this.Bsalida.UseVisualStyleBackColor = true;
            this.Bsalida.Click += new System.EventHandler(this.bsalida_Click);
            // 
            // Bcancelar
            // 
            this.Bcancelar.Location = new System.Drawing.Point(409, 300);
            this.Bcancelar.Name = "Bcancelar";
            this.Bcancelar.Size = new System.Drawing.Size(115, 28);
            this.Bcancelar.TabIndex = 7;
            this.Bcancelar.Text = "Cancelar";
            this.Bcancelar.UseVisualStyleBackColor = true;
            // 
            // FCupoSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 340);
            this.Controls.Add(this.Bcancelar);
            this.Controls.Add(this.Bsalida);
            this.Controls.Add(this.Bingreso);
            this.Controls.Add(this.BPorcentajeocupacion);
            this.Controls.Add(this.Tcantidadpersonas);
            this.Controls.Add(this.Tcupototal);
            this.Controls.Add(this.Lcantidadpersonas);
            this.Controls.Add(this.LCupototal);
            this.Name = "FCupoSala";
            this.Text = "Cupo de la sala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCupototal;
        private System.Windows.Forms.Label Lcantidadpersonas;
        private System.Windows.Forms.TextBox Tcupototal;
        private System.Windows.Forms.TextBox Tcantidadpersonas;
        private System.Windows.Forms.Button BPorcentajeocupacion;
        private System.Windows.Forms.Button Bingreso;
        private System.Windows.Forms.Button Bsalida;
        private System.Windows.Forms.Button Bcancelar;
    }
}

