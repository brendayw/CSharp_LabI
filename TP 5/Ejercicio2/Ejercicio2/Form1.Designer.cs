
namespace Ejercicio2
{
    partial class FDeportes
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
            this.labelDeporte = new System.Windows.Forms.Label();
            this.LCantitdad = new System.Windows.Forms.Label();
            this.tDeporte = new System.Windows.Forms.TextBox();
            this.bCerrar = new System.Windows.Forms.Button();
            this.bResetear = new System.Windows.Forms.Button();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDeporte
            // 
            this.labelDeporte.AutoSize = true;
            this.labelDeporte.Location = new System.Drawing.Point(25, 34);
            this.labelDeporte.Name = "labelDeporte";
            this.labelDeporte.Size = new System.Drawing.Size(48, 13);
            this.labelDeporte.TabIndex = 0;
            this.labelDeporte.Text = "Deporte:";
            // 
            // LCantitdad
            // 
            this.LCantitdad.AutoSize = true;
            this.LCantitdad.Location = new System.Drawing.Point(25, 147);
            this.LCantitdad.Name = "LCantitdad";
            this.LCantitdad.Size = new System.Drawing.Size(122, 13);
            this.LCantitdad.TabIndex = 1;
            this.LCantitdad.Text = "Cantidad de Deportes: 0";
            // 
            // tDeporte
            // 
            this.tDeporte.Location = new System.Drawing.Point(100, 27);
            this.tDeporte.Name = "tDeporte";
            this.tDeporte.Size = new System.Drawing.Size(261, 20);
            this.tDeporte.TabIndex = 2;
            // 
            // bCerrar
            // 
            this.bCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bCerrar.Location = new System.Drawing.Point(0, 184);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(392, 29);
            this.bCerrar.TabIndex = 3;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bResetear
            // 
            this.bResetear.Location = new System.Drawing.Point(286, 140);
            this.bResetear.Name = "bResetear";
            this.bResetear.Size = new System.Drawing.Size(75, 27);
            this.bResetear.TabIndex = 4;
            this.bResetear.Text = "Resetear";
            this.bResetear.UseVisualStyleBackColor = true;
            this.bResetear.Click += new System.EventHandler(this.bResetear_Click);
            // 
            // bAgregar
            // 
            this.bAgregar.Location = new System.Drawing.Point(100, 53);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(67, 27);
            this.bAgregar.TabIndex = 5;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(197, 53);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(67, 27);
            this.bBuscar.TabIndex = 6;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(294, 53);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(67, 27);
            this.bEliminar.TabIndex = 7;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bListar
            // 
            this.bListar.Location = new System.Drawing.Point(100, 91);
            this.bListar.Name = "bListar";
            this.bListar.Size = new System.Drawing.Size(261, 27);
            this.bListar.TabIndex = 8;
            this.bListar.Text = "Listar";
            this.bListar.UseVisualStyleBackColor = true;
            this.bListar.Click += new System.EventHandler(this.bListar_Click);
            // 
            // FDeportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 213);
            this.Controls.Add(this.bListar);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.bResetear);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.tDeporte);
            this.Controls.Add(this.LCantitdad);
            this.Controls.Add(this.labelDeporte);
            this.Name = "FDeportes";
            this.Text = "Deportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeporte;
        private System.Windows.Forms.Label LCantitdad;
        private System.Windows.Forms.TextBox tDeporte;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bResetear;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bListar;
    }
}

