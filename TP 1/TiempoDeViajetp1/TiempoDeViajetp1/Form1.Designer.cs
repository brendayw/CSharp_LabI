
namespace TiempoDeViajetp1
{
    partial class FTiempoDeViaje
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
            this.LTextoInformativo = new System.Windows.Forms.Label();
            this.LDestino = new System.Windows.Forms.Label();
            this.LDistancia = new System.Windows.Forms.Label();
            this.LVelocidad = new System.Windows.Forms.Label();
            this.tDestino = new System.Windows.Forms.TextBox();
            this.tDistancia = new System.Windows.Forms.TextBox();
            this.tVelocidad = new System.Windows.Forms.TextBox();
            this.bCalcularTiempo = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LTextoInformativo
            // 
            this.LTextoInformativo.AutoSize = true;
            this.LTextoInformativo.Location = new System.Drawing.Point(46, 41);
            this.LTextoInformativo.Name = "LTextoInformativo";
            this.LTextoInformativo.Size = new System.Drawing.Size(104, 13);
            this.LTextoInformativo.TabIndex = 0;
            this.LTextoInformativo.Text = "¿A dónde quieres ir?";
            this.LTextoInformativo.Click += new System.EventHandler(this.label1_Click);
            // 
            // LDestino
            // 
            this.LDestino.AutoSize = true;
            this.LDestino.Location = new System.Drawing.Point(46, 82);
            this.LDestino.Name = "LDestino";
            this.LDestino.Size = new System.Drawing.Size(83, 13);
            this.LDestino.TabIndex = 1;
            this.LDestino.Text = "Destino elegido:";
            this.LDestino.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LDistancia
            // 
            this.LDistancia.AutoSize = true;
            this.LDistancia.Location = new System.Drawing.Point(46, 129);
            this.LDistancia.Name = "LDistancia";
            this.LDistancia.Size = new System.Drawing.Size(125, 13);
            this.LDistancia.TabIndex = 2;
            this.LDistancia.Text = "Distancia a recorrer (km):";
            this.LDistancia.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // LVelocidad
            // 
            this.LVelocidad.AutoSize = true;
            this.LVelocidad.Location = new System.Drawing.Point(46, 182);
            this.LVelocidad.Name = "LVelocidad";
            this.LVelocidad.Size = new System.Drawing.Size(57, 13);
            this.LVelocidad.TabIndex = 3;
            this.LVelocidad.Text = "Velocidad:";
            this.LVelocidad.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // tDestino
            // 
            this.tDestino.Location = new System.Drawing.Point(216, 75);
            this.tDestino.Name = "tDestino";
            this.tDestino.Size = new System.Drawing.Size(214, 20);
            this.tDestino.TabIndex = 4;
            // 
            // tDistancia
            // 
            this.tDistancia.Location = new System.Drawing.Point(216, 127);
            this.tDistancia.Name = "tDistancia";
            this.tDistancia.Size = new System.Drawing.Size(214, 20);
            this.tDistancia.TabIndex = 5;
            // 
            // tVelocidad
            // 
            this.tVelocidad.Location = new System.Drawing.Point(216, 183);
            this.tVelocidad.Name = "tVelocidad";
            this.tVelocidad.Size = new System.Drawing.Size(213, 20);
            this.tVelocidad.TabIndex = 6;
            // 
            // bCalcularTiempo
            // 
            this.bCalcularTiempo.Location = new System.Drawing.Point(492, 247);
            this.bCalcularTiempo.Name = "bCalcularTiempo";
            this.bCalcularTiempo.Size = new System.Drawing.Size(151, 25);
            this.bCalcularTiempo.TabIndex = 7;
            this.bCalcularTiempo.Text = "Calcular Tiempo De Viaje";
            this.bCalcularTiempo.UseVisualStyleBackColor = true;
            this.bCalcularTiempo.Click += new System.EventHandler(this.bCalcularTiempo_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(549, 293);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(94, 22);
            this.bCancelar.TabIndex = 8;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // FTiempoDeViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 327);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bCalcularTiempo);
            this.Controls.Add(this.tVelocidad);
            this.Controls.Add(this.tDistancia);
            this.Controls.Add(this.tDestino);
            this.Controls.Add(this.LVelocidad);
            this.Controls.Add(this.LDistancia);
            this.Controls.Add(this.LDestino);
            this.Controls.Add(this.LTextoInformativo);
            this.Name = "FTiempoDeViaje";
            this.Text = "TiempoDeViaje";
            this.Load += new System.EventHandler(this.TiempoDeViaje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTextoInformativo;
        private System.Windows.Forms.Label LDestino;
        private System.Windows.Forms.Label LDistancia;
        private System.Windows.Forms.Label LVelocidad;
        private System.Windows.Forms.TextBox tDestino;
        private System.Windows.Forms.TextBox tDistancia;
        private System.Windows.Forms.TextBox tVelocidad;
        private System.Windows.Forms.Button bCalcularTiempo;
        private System.Windows.Forms.Button bCancelar;
    }
}

