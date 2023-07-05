namespace radiotp1
{
    partial class fRadio
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
            this.LRadio = new System.Windows.Forms.Label();
            this.LExpresion = new System.Windows.Forms.Label();
            this.tRadio = new System.Windows.Forms.TextBox();
            this.tExpresion = new System.Windows.Forms.TextBox();
            this.bPerimetro = new System.Windows.Forms.Button();
            this.bArea = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LTextoInformativo
            // 
            this.LTextoInformativo.AutoSize = true;
            this.LTextoInformativo.Location = new System.Drawing.Point(30, 31);
            this.LTextoInformativo.Name = "LTextoInformativo";
            this.LTextoInformativo.Size = new System.Drawing.Size(130, 13);
            this.LTextoInformativo.TabIndex = 2;
            this.LTextoInformativo.Text = "Ingrese el radio del circulo";
            this.LTextoInformativo.Click += new System.EventHandler(this.label1_Click);
            // 
            // LRadio
            // 
            this.LRadio.AutoSize = true;
            this.LRadio.Location = new System.Drawing.Point(33, 62);
            this.LRadio.Name = "LRadio";
            this.LRadio.Size = new System.Drawing.Size(38, 13);
            this.LRadio.TabIndex = 3;
            this.LRadio.Text = "Radio:";
            this.LRadio.Click += new System.EventHandler(this.label2_Click);
            // 
            // LExpresion
            // 
            this.LExpresion.AutoSize = true;
            this.LExpresion.Location = new System.Drawing.Point(36, 103);
            this.LExpresion.Name = "LExpresion";
            this.LExpresion.Size = new System.Drawing.Size(110, 13);
            this.LExpresion.TabIndex = 4;
            this.LExpresion.Text = "Expresion (cm m, km):";
            this.LExpresion.Click += new System.EventHandler(this.label3_Click);
            // 
            // tRadio
            // 
            this.tRadio.Location = new System.Drawing.Point(90, 59);
            this.tRadio.Name = "tRadio";
            this.tRadio.Size = new System.Drawing.Size(93, 20);
            this.tRadio.TabIndex = 5;
            this.tRadio.TextChanged += new System.EventHandler(this.tRadio_TextChanged);
            // 
            // tExpresion
            // 
            this.tExpresion.Location = new System.Drawing.Point(163, 100);
            this.tExpresion.Name = "tExpresion";
            this.tExpresion.Size = new System.Drawing.Size(99, 20);
            this.tExpresion.TabIndex = 6;
            // 
            // bPerimetro
            // 
            this.bPerimetro.Location = new System.Drawing.Point(90, 166);
            this.bPerimetro.Name = "bPerimetro";
            this.bPerimetro.Size = new System.Drawing.Size(75, 23);
            this.bPerimetro.TabIndex = 7;
            this.bPerimetro.Text = "Perimetro";
            this.bPerimetro.UseVisualStyleBackColor = true;
            this.bPerimetro.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // bArea
            // 
            this.bArea.Location = new System.Drawing.Point(204, 166);
            this.bArea.Name = "bArea";
            this.bArea.Size = new System.Drawing.Size(75, 23);
            this.bArea.TabIndex = 8;
            this.bArea.Text = "Area";
            this.bArea.UseVisualStyleBackColor = true;
            this.bArea.Click += new System.EventHandler(this.bArea_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(280, 227);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(90, 23);
            this.bCancelar.TabIndex = 9;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // fRadio
            // 
            this.ClientSize = new System.Drawing.Size(379, 261);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.bPerimetro);
            this.Controls.Add(this.tExpresion);
            this.Controls.Add(this.tRadio);
            this.Controls.Add(this.LExpresion);
            this.Controls.Add(this.LRadio);
            this.Controls.Add(this.LTextoInformativo);
            this.Name = "fRadio";
            this.Text = "Radio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        
       
        private System.Windows.Forms.Label LTextoInformativo;
        private System.Windows.Forms.Label LRadio;
        private System.Windows.Forms.Label LExpresion;
        private System.Windows.Forms.TextBox tRadio;
        private System.Windows.Forms.TextBox tExpresion;
        private System.Windows.Forms.Button bPerimetro;
        private System.Windows.Forms.Button bArea;
        private System.Windows.Forms.Button bCancelar;
    }
}

