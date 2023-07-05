
namespace Ejercicio1
{
    partial class FSerie
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
            this.bCerrar = new System.Windows.Forms.Button();
            this.bEliminarNum = new System.Windows.Forms.Button();
            this.bEliminarRepe = new System.Windows.Forms.Button();
            this.bResetear = new System.Windows.Forms.Button();
            this.bIngresar = new System.Windows.Forms.Button();
            this.bInvertir = new System.Windows.Forms.Button();
            this.bListar = new System.Windows.Forms.Button();
            this.bParImpar = new System.Windows.Forms.Button();
            this.NUDNum = new System.Windows.Forms.NumericUpDown();
            this.LCantidad = new System.Windows.Forms.Label();
            this.LPromedio = new System.Windows.Forms.Label();
            this.LMayor = new System.Windows.Forms.Label();
            this.LMenor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNum)).BeginInit();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bCerrar.Location = new System.Drawing.Point(0, 310);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(354, 31);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "&Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bEliminarNum
            // 
            this.bEliminarNum.Location = new System.Drawing.Point(192, 52);
            this.bEliminarNum.Name = "bEliminarNum";
            this.bEliminarNum.Size = new System.Drawing.Size(131, 30);
            this.bEliminarNum.TabIndex = 1;
            this.bEliminarNum.Text = "Eliminar &Numero";
            this.bEliminarNum.UseVisualStyleBackColor = true;
            this.bEliminarNum.Click += new System.EventHandler(this.bEliminarNum_Click);
            // 
            // bEliminarRepe
            // 
            this.bEliminarRepe.Location = new System.Drawing.Point(192, 103);
            this.bEliminarRepe.Name = "bEliminarRepe";
            this.bEliminarRepe.Size = new System.Drawing.Size(131, 30);
            this.bEliminarRepe.TabIndex = 2;
            this.bEliminarRepe.Text = "&Eliminar Repetidos";
            this.bEliminarRepe.UseVisualStyleBackColor = true;
            this.bEliminarRepe.Click += new System.EventHandler(this.bEliminarRepe_Click);
            // 
            // bResetear
            // 
            this.bResetear.Location = new System.Drawing.Point(192, 156);
            this.bResetear.Name = "bResetear";
            this.bResetear.Size = new System.Drawing.Size(131, 30);
            this.bResetear.TabIndex = 3;
            this.bResetear.Text = "&Resetear Lista";
            this.bResetear.UseVisualStyleBackColor = true;
            this.bResetear.Click += new System.EventHandler(this.bResetear_Click);
            // 
            // bIngresar
            // 
            this.bIngresar.Location = new System.Drawing.Point(23, 52);
            this.bIngresar.Name = "bIngresar";
            this.bIngresar.Size = new System.Drawing.Size(131, 30);
            this.bIngresar.TabIndex = 4;
            this.bIngresar.Text = "&Ingresar Numero";
            this.bIngresar.UseVisualStyleBackColor = true;
            this.bIngresar.Click += new System.EventHandler(this.bIngresar_Click);
            // 
            // bInvertir
            // 
            this.bInvertir.Location = new System.Drawing.Point(23, 103);
            this.bInvertir.Name = "bInvertir";
            this.bInvertir.Size = new System.Drawing.Size(131, 30);
            this.bInvertir.TabIndex = 5;
            this.bInvertir.Text = "Invertir &Serie";
            this.bInvertir.UseVisualStyleBackColor = true;
            this.bInvertir.Click += new System.EventHandler(this.bInvertir_Click);
            // 
            // bListar
            // 
            this.bListar.Location = new System.Drawing.Point(23, 265);
            this.bListar.Name = "bListar";
            this.bListar.Size = new System.Drawing.Size(131, 30);
            this.bListar.TabIndex = 6;
            this.bListar.Text = "&Listar Serie";
            this.bListar.UseVisualStyleBackColor = true;
            this.bListar.Click += new System.EventHandler(this.bListar_Click);
            // 
            // bParImpar
            // 
            this.bParImpar.Location = new System.Drawing.Point(192, 265);
            this.bParImpar.Name = "bParImpar";
            this.bParImpar.Size = new System.Drawing.Size(131, 30);
            this.bParImpar.TabIndex = 7;
            this.bParImpar.Text = "&Pares / Impares";
            this.bParImpar.UseVisualStyleBackColor = true;
            this.bParImpar.Click += new System.EventHandler(this.bParImpar_Click);
            // 
            // NUDNum
            // 
            this.NUDNum.Location = new System.Drawing.Point(142, 16);
            this.NUDNum.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDNum.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.NUDNum.Name = "NUDNum";
            this.NUDNum.Size = new System.Drawing.Size(62, 20);
            this.NUDNum.TabIndex = 1;
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Location = new System.Drawing.Point(57, 173);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(61, 13);
            this.LCantidad.TabIndex = 9;
            this.LCantidad.Text = "Cantidad: 0";
            // 
            // LPromedio
            // 
            this.LPromedio.AutoSize = true;
            this.LPromedio.Location = new System.Drawing.Point(57, 219);
            this.LPromedio.Name = "LPromedio";
            this.LPromedio.Size = new System.Drawing.Size(54, 13);
            this.LPromedio.TabIndex = 10;
            this.LPromedio.Text = "Promedio:";
            // 
            // LMayor
            // 
            this.LMayor.AutoSize = true;
            this.LMayor.Location = new System.Drawing.Point(225, 208);
            this.LMayor.Name = "LMayor";
            this.LMayor.Size = new System.Drawing.Size(79, 13);
            this.LMayor.TabIndex = 11;
            this.LMayor.Text = "Número Mayor:";
            // 
            // LMenor
            // 
            this.LMenor.AutoSize = true;
            this.LMenor.Location = new System.Drawing.Point(225, 239);
            this.LMenor.Name = "LMenor";
            this.LMenor.Size = new System.Drawing.Size(80, 13);
            this.LMenor.TabIndex = 12;
            this.LMenor.Text = "Número Menor:";
            // 
            // FSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 341);
            this.Controls.Add(this.LMenor);
            this.Controls.Add(this.LMayor);
            this.Controls.Add(this.LPromedio);
            this.Controls.Add(this.LCantidad);
            this.Controls.Add(this.NUDNum);
            this.Controls.Add(this.bParImpar);
            this.Controls.Add(this.bListar);
            this.Controls.Add(this.bInvertir);
            this.Controls.Add(this.bIngresar);
            this.Controls.Add(this.bResetear);
            this.Controls.Add(this.bEliminarRepe);
            this.Controls.Add(this.bEliminarNum);
            this.Controls.Add(this.bCerrar);
            this.Name = "FSerie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serie";
            this.Load += new System.EventHandler(this.FSerie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bEliminarNum;
        private System.Windows.Forms.Button bEliminarRepe;
        private System.Windows.Forms.Button bResetear;
        private System.Windows.Forms.Button bIngresar;
        private System.Windows.Forms.Button bInvertir;
        private System.Windows.Forms.Button bListar;
        private System.Windows.Forms.Button bParImpar;
        private System.Windows.Forms.NumericUpDown NUDNum;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Label LPromedio;
        private System.Windows.Forms.Label LMayor;
        private System.Windows.Forms.Label LMenor;
    }
}

