
namespace EtiquetaTP3
{
    partial class FEtiqueta
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
            this.LEtiqueta = new System.Windows.Forms.Label();
            this.tTexto = new System.Windows.Forms.TextBox();
            this.LTexto = new System.Windows.Forms.Label();
            this.LTexto1 = new System.Windows.Forms.Label();
            this.nudLetra = new System.Windows.Forms.NumericUpDown();
            this.LLetra = new System.Windows.Forms.Label();
            this.BColor = new System.Windows.Forms.Button();
            this.BTamanioMas = new System.Windows.Forms.Button();
            this.BTamanioMenos = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLetra)).BeginInit();
            this.SuspendLayout();
            // 
            // LEtiqueta
            // 
            this.LEtiqueta.AutoSize = true;
            this.LEtiqueta.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEtiqueta.ForeColor = System.Drawing.Color.Black;
            this.LEtiqueta.Location = new System.Drawing.Point(107, 21);
            this.LEtiqueta.Name = "LEtiqueta";
            this.LEtiqueta.Size = new System.Drawing.Size(65, 23);
            this.LEtiqueta.TabIndex = 0;
            this.LEtiqueta.Text = "Etiqueta";
            this.LEtiqueta.Click += new System.EventHandler(this.LEtiqueta_Click);
            // 
            // tTexto
            // 
            this.tTexto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tTexto.Location = new System.Drawing.Point(83, 62);
            this.tTexto.MaxLength = 10;
            this.tTexto.Name = "tTexto";
            this.tTexto.Size = new System.Drawing.Size(168, 20);
            this.tTexto.TabIndex = 1;
            this.tTexto.TextChanged += new System.EventHandler(this.tTexto_TextChanged);
            // 
            // LTexto
            // 
            this.LTexto.AutoSize = true;
            this.LTexto.Location = new System.Drawing.Point(40, 69);
            this.LTexto.Name = "LTexto";
            this.LTexto.Size = new System.Drawing.Size(37, 13);
            this.LTexto.TabIndex = 2;
            this.LTexto.Text = "Texto:";
            // 
            // LTexto1
            // 
            this.LTexto1.AutoSize = true;
            this.LTexto1.Location = new System.Drawing.Point(43, 95);
            this.LTexto1.Name = "LTexto1";
            this.LTexto1.Size = new System.Drawing.Size(34, 13);
            this.LTexto1.TabIndex = 3;
            this.LTexto1.Text = "Letra:";
            // 
            // nudLetra
            // 
            this.nudLetra.Location = new System.Drawing.Point(83, 88);
            this.nudLetra.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudLetra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLetra.Name = "nudLetra";
            this.nudLetra.Size = new System.Drawing.Size(68, 20);
            this.nudLetra.TabIndex = 4;
            this.nudLetra.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLetra.ValueChanged += new System.EventHandler(this.nudLetra_ValueChanged);
            // 
            // LLetra
            // 
            this.LLetra.AutoSize = true;
            this.LLetra.Location = new System.Drawing.Point(167, 95);
            this.LLetra.Name = "LLetra";
            this.LLetra.Size = new System.Drawing.Size(55, 13);
            this.LLetra.TabIndex = 5;
            this.LLetra.Text = "Avocados";
            this.LLetra.Click += new System.EventHandler(this.LCambia_Click);
            // 
            // BColor
            // 
            this.BColor.Location = new System.Drawing.Point(43, 114);
            this.BColor.Name = "BColor";
            this.BColor.Size = new System.Drawing.Size(208, 26);
            this.BColor.TabIndex = 6;
            this.BColor.Text = "Cambio de Color";
            this.BColor.UseVisualStyleBackColor = true;
            this.BColor.TextChanged += new System.EventHandler(this.BColor_Click);
            this.BColor.Click += new System.EventHandler(this.BColor_Click);
            // 
            // BTamanioMas
            // 
            this.BTamanioMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTamanioMas.Location = new System.Drawing.Point(159, 146);
            this.BTamanioMas.Name = "BTamanioMas";
            this.BTamanioMas.Size = new System.Drawing.Size(92, 26);
            this.BTamanioMas.TabIndex = 7;
            this.BTamanioMas.Text = "> Tamaño";
            this.BTamanioMas.UseVisualStyleBackColor = true;
            this.BTamanioMas.Click += new System.EventHandler(this.BTamanioMas_Click);
            // 
            // BTamanioMenos
            // 
            this.BTamanioMenos.Location = new System.Drawing.Point(43, 146);
            this.BTamanioMenos.Name = "BTamanioMenos";
            this.BTamanioMenos.Size = new System.Drawing.Size(92, 26);
            this.BTamanioMenos.TabIndex = 8;
            this.BTamanioMenos.Text = "< Tamaño";
            this.BTamanioMenos.UseVisualStyleBackColor = true;
            this.BTamanioMenos.ClientSizeChanged += new System.EventHandler(this.BTamanioMenos_Click);
            this.BTamanioMenos.Click += new System.EventHandler(this.BTamanioMenos_Click);
            // 
            // BSalir
            // 
            this.BSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BSalir.Location = new System.Drawing.Point(0, 187);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(302, 35);
            this.BSalir.TabIndex = 9;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // FEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 222);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BTamanioMenos);
            this.Controls.Add(this.BTamanioMas);
            this.Controls.Add(this.BColor);
            this.Controls.Add(this.LLetra);
            this.Controls.Add(this.nudLetra);
            this.Controls.Add(this.LTexto1);
            this.Controls.Add(this.LTexto);
            this.Controls.Add(this.tTexto);
            this.Controls.Add(this.LEtiqueta);
            this.Name = "FEtiqueta";
            this.Text = "Etiqueta";
            this.Load += new System.EventHandler(this.FEtiqueta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLetra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LEtiqueta;
        private System.Windows.Forms.TextBox tTexto;
        private System.Windows.Forms.Label LTexto;
        private System.Windows.Forms.Label LTexto1;
        private System.Windows.Forms.NumericUpDown nudLetra;
        private System.Windows.Forms.Label LLetra;
        private System.Windows.Forms.Button BColor;
        private System.Windows.Forms.Button BTamanioMas;
        private System.Windows.Forms.Button BTamanioMenos;
        private System.Windows.Forms.Button BSalir;
    }
}

