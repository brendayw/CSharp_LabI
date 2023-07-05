
namespace CalcularVueltotp1
{
    partial class FCalcularVuelto
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
            this.LValor = new System.Windows.Forms.Label();
            this.LMonto = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tValor = new System.Windows.Forms.TextBox();
            this.tMonto = new System.Windows.Forms.TextBox();
            this.bVuelto = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(60, 61);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(98, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre del cliente:";
            // 
            // LValor
            // 
            this.LValor.AutoSize = true;
            this.LValor.Location = new System.Drawing.Point(60, 125);
            this.LValor.Name = "LValor";
            this.LValor.Size = new System.Drawing.Size(98, 13);
            this.LValor.TabIndex = 1;
            this.LValor.Text = "Valor de la compra:";
            this.LValor.Click += new System.EventHandler(this.label1_Click);
            // 
            // LMonto
            // 
            this.LMonto.AutoSize = true;
            this.LMonto.Location = new System.Drawing.Point(60, 182);
            this.LMonto.Name = "LMonto";
            this.LMonto.Size = new System.Drawing.Size(88, 13);
            this.LMonto.TabIndex = 2;
            this.LMonto.Text = "Monto que pagó:";
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(199, 58);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(169, 20);
            this.tNombre.TabIndex = 3;
            // 
            // tValor
            // 
            this.tValor.Location = new System.Drawing.Point(199, 125);
            this.tValor.Name = "tValor";
            this.tValor.Size = new System.Drawing.Size(169, 20);
            this.tValor.TabIndex = 4;
            // 
            // tMonto
            // 
            this.tMonto.Location = new System.Drawing.Point(199, 182);
            this.tMonto.Name = "tMonto";
            this.tMonto.Size = new System.Drawing.Size(169, 20);
            this.tMonto.TabIndex = 5;
            // 
            // bVuelto
            // 
            this.bVuelto.Location = new System.Drawing.Point(329, 230);
            this.bVuelto.Name = "bVuelto";
            this.bVuelto.Size = new System.Drawing.Size(98, 24);
            this.bVuelto.TabIndex = 6;
            this.bVuelto.Text = "Calcular Vuelto";
            this.bVuelto.UseVisualStyleBackColor = true;
            this.bVuelto.Click += new System.EventHandler(this.bVuelto_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(502, 297);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(109, 28);
            this.bCancelar.TabIndex = 7;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // FCalcularVuelto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 337);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bVuelto);
            this.Controls.Add(this.tMonto);
            this.Controls.Add(this.tValor);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.LMonto);
            this.Controls.Add(this.LValor);
            this.Controls.Add(this.LNombre);
            this.Name = "FCalcularVuelto";
            this.Text = "Calcular Vuelto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LValor;
        private System.Windows.Forms.Label LMonto;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tValor;
        private System.Windows.Forms.TextBox tMonto;
        private System.Windows.Forms.Button bVuelto;
        private System.Windows.Forms.Button bCancelar;
    }
}

