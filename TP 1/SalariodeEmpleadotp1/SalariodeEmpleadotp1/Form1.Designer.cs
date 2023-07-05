
namespace SalariodeEmpleadotp1
{
    partial class FSueldoEmpleado
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
            this.lnombre = new System.Windows.Forms.Label();
            this.lingreso = new System.Windows.Forms.Label();
            this.ltarifa = new System.Windows.Forms.Label();
            this.lhorasdia = new System.Windows.Forms.Label();
            this.ldiasalmes = new System.Windows.Forms.Label();
            this.tnombre = new System.Windows.Forms.TextBox();
            this.tingreso = new System.Windows.Forms.TextBox();
            this.ttarifa = new System.Windows.Forms.TextBox();
            this.thoraspordia = new System.Windows.Forms.TextBox();
            this.tdiaspormes = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.bcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Location = new System.Drawing.Point(57, 36);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(126, 13);
            this.lnombre.TabIndex = 0;
            this.lnombre.Text = "Nombre de un empleado:";
            this.lnombre.Click += new System.EventHandler(this.lnombre_Click);
            // 
            // lingreso
            // 
            this.lingreso.AutoSize = true;
            this.lingreso.Location = new System.Drawing.Point(57, 74);
            this.lingreso.Name = "lingreso";
            this.lingreso.Size = new System.Drawing.Size(81, 13);
            this.lingreso.TabIndex = 1;
            this.lingreso.Text = "Año de ingreso:";
            // 
            // ltarifa
            // 
            this.ltarifa.AutoSize = true;
            this.ltarifa.Location = new System.Drawing.Point(57, 116);
            this.ltarifa.Name = "ltarifa";
            this.ltarifa.Size = new System.Drawing.Size(72, 13);
            this.ltarifa.TabIndex = 2;
            this.ltarifa.Text = "Tarifa horaria:";
            // 
            // lhorasdia
            // 
            this.lhorasdia.AutoSize = true;
            this.lhorasdia.Location = new System.Drawing.Point(57, 155);
            this.lhorasdia.Name = "lhorasdia";
            this.lhorasdia.Size = new System.Drawing.Size(96, 26);
            this.lhorasdia.TabIndex = 3;
            this.lhorasdia.Text = "Cantidad de horas\r\ntrabajadas por día:";
            // 
            // ldiasalmes
            // 
            this.ldiasalmes.AutoSize = true;
            this.ldiasalmes.Location = new System.Drawing.Point(57, 212);
            this.ldiasalmes.Name = "ldiasalmes";
            this.ldiasalmes.Size = new System.Drawing.Size(92, 26);
            this.ldiasalmes.TabIndex = 4;
            this.ldiasalmes.Text = "Cantidad de días \r\ntrabajados al mes:";
            // 
            // tnombre
            // 
            this.tnombre.Location = new System.Drawing.Point(228, 29);
            this.tnombre.Name = "tnombre";
            this.tnombre.Size = new System.Drawing.Size(161, 20);
            this.tnombre.TabIndex = 5;
            // 
            // tingreso
            // 
            this.tingreso.Location = new System.Drawing.Point(228, 67);
            this.tingreso.Name = "tingreso";
            this.tingreso.Size = new System.Drawing.Size(161, 20);
            this.tingreso.TabIndex = 6;
            // 
            // ttarifa
            // 
            this.ttarifa.Location = new System.Drawing.Point(228, 113);
            this.ttarifa.Name = "ttarifa";
            this.ttarifa.Size = new System.Drawing.Size(161, 20);
            this.ttarifa.TabIndex = 7;
            // 
            // thoraspordia
            // 
            this.thoraspordia.Location = new System.Drawing.Point(228, 161);
            this.thoraspordia.Name = "thoraspordia";
            this.thoraspordia.Size = new System.Drawing.Size(161, 20);
            this.thoraspordia.TabIndex = 8;
            // 
            // tdiaspormes
            // 
            this.tdiaspormes.Location = new System.Drawing.Point(228, 212);
            this.tdiaspormes.Name = "tdiaspormes";
            this.tdiaspormes.Size = new System.Drawing.Size(161, 20);
            this.tdiaspormes.TabIndex = 9;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(324, 249);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(127, 26);
            this.bCalcular.TabIndex = 10;
            this.bCalcular.Text = "Calcular sueldo";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // bcancelar
            // 
            this.bcancelar.Location = new System.Drawing.Point(438, 298);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(94, 24);
            this.bcancelar.TabIndex = 11;
            this.bcancelar.Text = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = true;
            // 
            // FSueldoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 334);
            this.Controls.Add(this.bcancelar);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tdiaspormes);
            this.Controls.Add(this.thoraspordia);
            this.Controls.Add(this.ttarifa);
            this.Controls.Add(this.tingreso);
            this.Controls.Add(this.tnombre);
            this.Controls.Add(this.ldiasalmes);
            this.Controls.Add(this.lhorasdia);
            this.Controls.Add(this.ltarifa);
            this.Controls.Add(this.lingreso);
            this.Controls.Add(this.lnombre);
            this.Name = "FSueldoEmpleado";
            this.Text = "Sueldo de un empleado";
            this.Load += new System.EventHandler(this.SueldoEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.Label lingreso;
        private System.Windows.Forms.Label ltarifa;
        private System.Windows.Forms.Label lhorasdia;
        private System.Windows.Forms.Label ldiasalmes;
        private System.Windows.Forms.TextBox tnombre;
        private System.Windows.Forms.TextBox tingreso;
        private System.Windows.Forms.TextBox ttarifa;
        private System.Windows.Forms.TextBox thoraspordia;
        private System.Windows.Forms.TextBox tdiaspormes;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Button bcancelar;
    }
}

