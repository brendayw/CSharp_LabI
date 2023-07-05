
namespace Sumadigitostp1
{
    partial class FSuma
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
            this.lTexoInformativo = new System.Windows.Forms.Label();
            this.tnumero = new System.Windows.Forms.TextBox();
            this.bcancelar = new System.Windows.Forms.Button();
            this.bSuma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lTexoInformativo
            // 
            this.lTexoInformativo.AutoSize = true;
            this.lTexoInformativo.Location = new System.Drawing.Point(213, 44);
            this.lTexoInformativo.Name = "lTexoInformativo";
            this.lTexoInformativo.Size = new System.Drawing.Size(183, 13);
            this.lTexoInformativo.TabIndex = 0;
            this.lTexoInformativo.Text = "Ingrese un número entero de 2 cifras:";
            // 
            // tnumero
            // 
            this.tnumero.Location = new System.Drawing.Point(216, 78);
            this.tnumero.Name = "tnumero";
            this.tnumero.Size = new System.Drawing.Size(180, 20);
            this.tnumero.TabIndex = 1;
            // 
            // bcancelar
            // 
            this.bcancelar.Location = new System.Drawing.Point(497, 288);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(108, 31);
            this.bcancelar.TabIndex = 2;
            this.bcancelar.Text = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = true;
            // 
            // bSuma
            // 
            this.bSuma.Location = new System.Drawing.Point(250, 120);
            this.bSuma.Name = "bSuma";
            this.bSuma.Size = new System.Drawing.Size(117, 40);
            this.bSuma.TabIndex = 3;
            this.bSuma.Text = "Calcular suma de digitos";
            this.bSuma.UseVisualStyleBackColor = true;
            this.bSuma.Click += new System.EventHandler(this.bSuma_Click);
            // 
            // FSuma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 331);
            this.Controls.Add(this.bSuma);
            this.Controls.Add(this.bcancelar);
            this.Controls.Add(this.tnumero);
            this.Controls.Add(this.lTexoInformativo);
            this.Name = "FSuma";
            this.Text = "Suma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTexoInformativo;
        private System.Windows.Forms.TextBox tnumero;
        private System.Windows.Forms.Button bcancelar;
        private System.Windows.Forms.Button bSuma;
    }
}

