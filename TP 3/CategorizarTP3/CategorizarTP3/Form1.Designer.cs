
namespace CategorizarTP3
{
    partial class FCategoria
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
            this.LApellido = new System.Windows.Forms.Label();
            this.LFechaNac = new System.Windows.Forms.Label();
            this.LCategorias = new System.Windows.Forms.Label();
            this.LCantBenjamin = new System.Windows.Forms.Label();
            this.LCantInfantil = new System.Windows.Forms.Label();
            this.LCantAmateur = new System.Windows.Forms.Label();
            this.LCantQuerubin = new System.Windows.Forms.Label();
            this.LCantCadete = new System.Windows.Forms.Label();
            this.LCantJuvenil = new System.Windows.Forms.Label();
            this.LCantVeteranos = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.nudDia = new System.Windows.Forms.NumericUpDown();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.bIngresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(57, 44);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(47, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre:";
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(57, 83);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(47, 13);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido:";
            // 
            // LFechaNac
            // 
            this.LFechaNac.AutoSize = true;
            this.LFechaNac.Location = new System.Drawing.Point(57, 126);
            this.LFechaNac.Name = "LFechaNac";
            this.LFechaNac.Size = new System.Drawing.Size(63, 13);
            this.LFechaNac.TabIndex = 2;
            this.LFechaNac.Text = "Fecha Nac:";
            // 
            // LCategorias
            // 
            this.LCategorias.AutoSize = true;
            this.LCategorias.Location = new System.Drawing.Point(387, 44);
            this.LCategorias.Name = "LCategorias";
            this.LCategorias.Size = new System.Drawing.Size(60, 13);
            this.LCategorias.TabIndex = 3;
            this.LCategorias.Text = "Categorias:";
            this.LCategorias.Click += new System.EventHandler(this.LCategorias_Click);
            // 
            // LCantBenjamin
            // 
            this.LCantBenjamin.AutoSize = true;
            this.LCantBenjamin.Location = new System.Drawing.Point(387, 78);
            this.LCantBenjamin.Name = "LCantBenjamin";
            this.LCantBenjamin.Size = new System.Drawing.Size(56, 13);
            this.LCantBenjamin.TabIndex = 4;
            this.LCantBenjamin.Text = "Bejamin: 0";
            this.LCantBenjamin.Click += new System.EventHandler(this.LCantBenjamin_Click);
            // 
            // LCantInfantil
            // 
            this.LCantInfantil.AutoSize = true;
            this.LCantInfantil.Location = new System.Drawing.Point(387, 111);
            this.LCantInfantil.Name = "LCantInfantil";
            this.LCantInfantil.Size = new System.Drawing.Size(50, 13);
            this.LCantInfantil.TabIndex = 5;
            this.LCantInfantil.Text = "Infantil: 0";
            // 
            // LCantAmateur
            // 
            this.LCantAmateur.AutoSize = true;
            this.LCantAmateur.Location = new System.Drawing.Point(387, 145);
            this.LCantAmateur.Name = "LCantAmateur";
            this.LCantAmateur.Size = new System.Drawing.Size(58, 13);
            this.LCantAmateur.TabIndex = 6;
            this.LCantAmateur.Text = "Amateur: 0";
            // 
            // LCantQuerubin
            // 
            this.LCantQuerubin.AutoSize = true;
            this.LCantQuerubin.Location = new System.Drawing.Point(490, 44);
            this.LCantQuerubin.Name = "LCantQuerubin";
            this.LCantQuerubin.Size = new System.Drawing.Size(62, 13);
            this.LCantQuerubin.TabIndex = 7;
            this.LCantQuerubin.Text = "Querubin: 0";
            this.LCantQuerubin.TextChanged += new System.EventHandler(this.LCantQuerubin_Click);
            this.LCantQuerubin.Click += new System.EventHandler(this.LCantQuerubin_Click);
            // 
            // LCantCadete
            // 
            this.LCantCadete.AutoSize = true;
            this.LCantCadete.Location = new System.Drawing.Point(490, 78);
            this.LCantCadete.Name = "LCantCadete";
            this.LCantCadete.Size = new System.Drawing.Size(53, 13);
            this.LCantCadete.TabIndex = 8;
            this.LCantCadete.Text = "Cadete: 0";
            // 
            // LCantJuvenil
            // 
            this.LCantJuvenil.AutoSize = true;
            this.LCantJuvenil.Location = new System.Drawing.Point(490, 114);
            this.LCantJuvenil.Name = "LCantJuvenil";
            this.LCantJuvenil.Size = new System.Drawing.Size(52, 13);
            this.LCantJuvenil.TabIndex = 9;
            this.LCantJuvenil.Text = "Juvenil: 0";
            // 
            // LCantVeteranos
            // 
            this.LCantVeteranos.AutoSize = true;
            this.LCantVeteranos.Location = new System.Drawing.Point(493, 143);
            this.LCantVeteranos.Name = "LCantVeteranos";
            this.LCantVeteranos.Size = new System.Drawing.Size(67, 13);
            this.LCantVeteranos.TabIndex = 10;
            this.LCantVeteranos.Text = "Veteranos: 0";
            // 
            // bCancelar
            // 
            this.bCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bCancelar.Location = new System.Drawing.Point(0, 218);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(605, 28);
            this.bCancelar.TabIndex = 11;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // TNombre
            // 
            this.TNombre.Location = new System.Drawing.Point(150, 44);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(194, 20);
            this.TNombre.TabIndex = 12;
            this.TNombre.TextChanged += new System.EventHandler(this.tNombre_TextChanged);
            // 
            // tApellido
            // 
            this.tApellido.Location = new System.Drawing.Point(150, 83);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(194, 20);
            this.tApellido.TabIndex = 13;
            this.tApellido.TextChanged += new System.EventHandler(this.tApellido_TextChanged);
            // 
            // nudDia
            // 
            this.nudDia.Location = new System.Drawing.Point(150, 126);
            this.nudDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDia.Name = "nudDia";
            this.nudDia.Size = new System.Drawing.Size(56, 20);
            this.nudDia.TabIndex = 14;
            this.nudDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDia.ValueChanged += new System.EventHandler(this.nudDia_ValueChanged);
            // 
            // nudMes
            // 
            this.nudMes.Location = new System.Drawing.Point(219, 126);
            this.nudMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMes.Name = "nudMes";
            this.nudMes.Size = new System.Drawing.Size(56, 20);
            this.nudMes.TabIndex = 15;
            this.nudMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(288, 126);
            this.nudAnio.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.nudAnio.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(56, 20);
            this.nudAnio.TabIndex = 16;
            this.nudAnio.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudAnio.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // bIngresar
            // 
            this.bIngresar.Location = new System.Drawing.Point(150, 161);
            this.bIngresar.Name = "bIngresar";
            this.bIngresar.Size = new System.Drawing.Size(194, 29);
            this.bIngresar.TabIndex = 17;
            this.bIngresar.Text = "Ingresar";
            this.bIngresar.UseVisualStyleBackColor = true;
            this.bIngresar.Click += new System.EventHandler(this.bIngresar_Click);
            // 
            // FCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 246);
            this.Controls.Add(this.bIngresar);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.nudMes);
            this.Controls.Add(this.nudDia);
            this.Controls.Add(this.tApellido);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.LCantVeteranos);
            this.Controls.Add(this.LCantJuvenil);
            this.Controls.Add(this.LCantCadete);
            this.Controls.Add(this.LCantQuerubin);
            this.Controls.Add(this.LCantAmateur);
            this.Controls.Add(this.LCantInfantil);
            this.Controls.Add(this.LCantBenjamin);
            this.Controls.Add(this.LCategorias);
            this.Controls.Add(this.LFechaNac);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Name = "FCategoria";
            this.Text = "Categoria";
            this.Load += new System.EventHandler(this.FCategoria_Load);
            this.TextChanged += new System.EventHandler(this.LCantQuerubin_Click);
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LFechaNac;
        private System.Windows.Forms.Label LCategorias;
        private System.Windows.Forms.Label LCantBenjamin;
        private System.Windows.Forms.Label LCantInfantil;
        private System.Windows.Forms.Label LCantAmateur;
        private System.Windows.Forms.Label LCantQuerubin;
        private System.Windows.Forms.Label LCantCadete;
        private System.Windows.Forms.Label LCantJuvenil;
        private System.Windows.Forms.Label LCantVeteranos;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.NumericUpDown nudDia;
        private System.Windows.Forms.NumericUpDown nudMes;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Button bIngresar;
    }
}

