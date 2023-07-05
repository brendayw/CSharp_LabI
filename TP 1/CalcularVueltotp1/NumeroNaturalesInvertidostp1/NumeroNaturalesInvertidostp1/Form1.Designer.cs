
namespace NumeroNaturalesInvertidostp1
{
    partial class FNumerosNaturales
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
            this.ltextoinformativo = new System.Windows.Forms.Label();
            this.lnumeroA = new System.Windows.Forms.Label();
            this.lNumeroB = new System.Windows.Forms.Label();
            this.tnumeroA = new System.Windows.Forms.TextBox();
            this.tNumeroB = new System.Windows.Forms.TextBox();
            this.binvertir = new System.Windows.Forms.Button();
            this.bcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltextoinformativo
            // 
            this.ltextoinformativo.AutoSize = true;
            this.ltextoinformativo.Location = new System.Drawing.Point(231, 54);
            this.ltextoinformativo.Name = "ltextoinformativo";
            this.ltextoinformativo.Size = new System.Drawing.Size(154, 13);
            this.ltextoinformativo.TabIndex = 0;
            this.ltextoinformativo.Text = "Ingrese dos números naturales:";
            // 
            // lnumeroA
            // 
            this.lnumeroA.AutoSize = true;
            this.lnumeroA.Location = new System.Drawing.Point(193, 101);
            this.lnumeroA.Name = "lnumeroA";
            this.lnumeroA.Size = new System.Drawing.Size(57, 13);
            this.lnumeroA.TabIndex = 1;
            this.lnumeroA.Text = "Número A:";
            // 
            // lNumeroB
            // 
            this.lNumeroB.AutoSize = true;
            this.lNumeroB.Location = new System.Drawing.Point(193, 166);
            this.lNumeroB.Name = "lNumeroB";
            this.lNumeroB.Size = new System.Drawing.Size(57, 13);
            this.lNumeroB.TabIndex = 2;
            this.lNumeroB.Text = "Número B:";
            // 
            // tnumeroA
            // 
            this.tnumeroA.Location = new System.Drawing.Point(291, 98);
            this.tnumeroA.Name = "tnumeroA";
            this.tnumeroA.Size = new System.Drawing.Size(175, 20);
            this.tnumeroA.TabIndex = 3;
            // 
            // tNumeroB
            // 
            this.tNumeroB.Location = new System.Drawing.Point(291, 159);
            this.tNumeroB.Name = "tNumeroB";
            this.tNumeroB.Size = new System.Drawing.Size(175, 20);
            this.tNumeroB.TabIndex = 4;
            // 
            // binvertir
            // 
            this.binvertir.Location = new System.Drawing.Point(381, 205);
            this.binvertir.Name = "binvertir";
            this.binvertir.Size = new System.Drawing.Size(85, 36);
            this.binvertir.TabIndex = 5;
            this.binvertir.Text = "Invertir \r\nnúmeros";
            this.binvertir.UseVisualStyleBackColor = true;
            this.binvertir.Click += new System.EventHandler(this.binvertir_Click);
            // 
            // bcancelar
            // 
            this.bcancelar.Location = new System.Drawing.Point(497, 298);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(95, 32);
            this.bcancelar.TabIndex = 6;
            this.bcancelar.Text = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = true;
            // 
            // FNumerosNaturales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 345);
            this.Controls.Add(this.bcancelar);
            this.Controls.Add(this.binvertir);
            this.Controls.Add(this.tNumeroB);
            this.Controls.Add(this.tnumeroA);
            this.Controls.Add(this.lNumeroB);
            this.Controls.Add(this.lnumeroA);
            this.Controls.Add(this.ltextoinformativo);
            this.Name = "FNumerosNaturales";
            this.Text = "Números naturales invertidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltextoinformativo;
        private System.Windows.Forms.Label lnumeroA;
        private System.Windows.Forms.Label lNumeroB;
        private System.Windows.Forms.TextBox tnumeroA;
        private System.Windows.Forms.TextBox tNumeroB;
        private System.Windows.Forms.Button binvertir;
        private System.Windows.Forms.Button bcancelar;
    }
}

