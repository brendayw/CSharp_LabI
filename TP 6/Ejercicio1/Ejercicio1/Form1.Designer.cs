
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
            this.NUDNum = new System.Windows.Forms.NumericUpDown();
            this.labelNumero = new System.Windows.Forms.Label();
            this.LCantidad = new System.Windows.Forms.Label();
            this.bIngresar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bERepetidos = new System.Windows.Forms.Button();
            this.bResetear = new System.Windows.Forms.Button();
            this.bListar = new System.Windows.Forms.Button();
            this.bParImpar = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.LPromedio = new System.Windows.Forms.Label();
            this.LMayor = new System.Windows.Forms.Label();
            this.LMenor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNum)).BeginInit();
            this.SuspendLayout();
            // 
            // NUDNum
            // 
            this.NUDNum.Location = new System.Drawing.Point(133, 31);
            this.NUDNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDNum.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.NUDNum.Name = "NUDNum";
            this.NUDNum.Size = new System.Drawing.Size(43, 20);
            this.NUDNum.TabIndex = 0;
            // 
            // labelNumero
            // 
            this.labelNumero.AutoSize = true;
            this.labelNumero.Location = new System.Drawing.Point(60, 38);
            this.labelNumero.Name = "labelNumero";
            this.labelNumero.Size = new System.Drawing.Size(47, 13);
            this.labelNumero.TabIndex = 1;
            this.labelNumero.Text = "Número:";
            // 
            // LCantidad
            // 
            this.LCantidad.AutoSize = true;
            this.LCantidad.Location = new System.Drawing.Point(35, 207);
            this.LCantidad.Name = "LCantidad";
            this.LCantidad.Size = new System.Drawing.Size(61, 13);
            this.LCantidad.TabIndex = 2;
            this.LCantidad.Text = "Cantidad: 0";
            // 
            // bIngresar
            // 
            this.bIngresar.Location = new System.Drawing.Point(12, 74);
            this.bIngresar.Name = "bIngresar";
            this.bIngresar.Size = new System.Drawing.Size(104, 27);
            this.bIngresar.TabIndex = 3;
            this.bIngresar.Text = "Ingresar Número";
            this.bIngresar.UseVisualStyleBackColor = true;
            this.bIngresar.Click += new System.EventHandler(this.bIngresar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(142, 74);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(104, 27);
            this.bEliminar.TabIndex = 4;
            this.bEliminar.Text = "Eliminar Número";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bERepetidos
            // 
            this.bERepetidos.Location = new System.Drawing.Point(142, 112);
            this.bERepetidos.Name = "bERepetidos";
            this.bERepetidos.Size = new System.Drawing.Size(104, 33);
            this.bERepetidos.TabIndex = 5;
            this.bERepetidos.Text = "Eliminar Repetidos";
            this.bERepetidos.UseVisualStyleBackColor = true;
            this.bERepetidos.Click += new System.EventHandler(this.bERepetidos_Click);
            // 
            // bResetear
            // 
            this.bResetear.Location = new System.Drawing.Point(142, 156);
            this.bResetear.Name = "bResetear";
            this.bResetear.Size = new System.Drawing.Size(104, 30);
            this.bResetear.TabIndex = 6;
            this.bResetear.Text = "Resetear Lista";
            this.bResetear.UseVisualStyleBackColor = true;
            // 
            // bListar
            // 
            this.bListar.Location = new System.Drawing.Point(12, 278);
            this.bListar.Name = "bListar";
            this.bListar.Size = new System.Drawing.Size(104, 27);
            this.bListar.TabIndex = 7;
            this.bListar.Text = "Listar Serie";
            this.bListar.UseVisualStyleBackColor = true;
            // 
            // bParImpar
            // 
            this.bParImpar.Location = new System.Drawing.Point(142, 278);
            this.bParImpar.Name = "bParImpar";
            this.bParImpar.Size = new System.Drawing.Size(104, 27);
            this.bParImpar.TabIndex = 8;
            this.bParImpar.Text = "Pares / Impares";
            this.bParImpar.UseVisualStyleBackColor = true;
            // 
            // bCerrar
            // 
            this.bCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bCerrar.Location = new System.Drawing.Point(0, 330);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(280, 27);
            this.bCerrar.TabIndex = 9;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            // 
            // LPromedio
            // 
            this.LPromedio.AutoSize = true;
            this.LPromedio.Location = new System.Drawing.Point(35, 242);
            this.LPromedio.Name = "LPromedio";
            this.LPromedio.Size = new System.Drawing.Size(63, 13);
            this.LPromedio.TabIndex = 10;
            this.LPromedio.Text = "Promedio: 0";
            // 
            // LMayor
            // 
            this.LMayor.AutoSize = true;
            this.LMayor.Location = new System.Drawing.Point(158, 207);
            this.LMayor.Name = "LMayor";
            this.LMayor.Size = new System.Drawing.Size(79, 13);
            this.LMayor.TabIndex = 11;
            this.LMayor.Text = "Número Mayor:";
            // 
            // LMenor
            // 
            this.LMenor.AutoSize = true;
            this.LMenor.Location = new System.Drawing.Point(157, 242);
            this.LMenor.Name = "LMenor";
            this.LMenor.Size = new System.Drawing.Size(80, 13);
            this.LMenor.TabIndex = 12;
            this.LMenor.Text = "Número Menor:";
            // 
            // FSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 357);
            this.Controls.Add(this.LMenor);
            this.Controls.Add(this.LMayor);
            this.Controls.Add(this.LPromedio);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bParImpar);
            this.Controls.Add(this.bListar);
            this.Controls.Add(this.bResetear);
            this.Controls.Add(this.bERepetidos);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bIngresar);
            this.Controls.Add(this.LCantidad);
            this.Controls.Add(this.labelNumero);
            this.Controls.Add(this.NUDNum);
            this.Name = "FSerie";
            this.Text = "Serie";
            ((System.ComponentModel.ISupportInitialize)(this.NUDNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUDNum;
        private System.Windows.Forms.Label labelNumero;
        private System.Windows.Forms.Label LCantidad;
        private System.Windows.Forms.Button bIngresar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bERepetidos;
        private System.Windows.Forms.Button bResetear;
        private System.Windows.Forms.Button bListar;
        private System.Windows.Forms.Button bParImpar;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label LPromedio;
        private System.Windows.Forms.Label LMayor;
        private System.Windows.Forms.Label LMenor;
    }
}

