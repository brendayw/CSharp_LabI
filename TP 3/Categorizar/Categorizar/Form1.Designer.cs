
namespace Categorizar
{
    partial class FCategorizar
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
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LFechaNac = new System.Windows.Forms.Label();
            this.LCategorias = new System.Windows.Forms.Label();
            this.LCantBenjamin = new System.Windows.Forms.Label();
            this.LCantInfantil = new System.Windows.Forms.Label();
            this.LAmateur = new System.Windows.Forms.Label();
            this.LCantQuerubin = new System.Windows.Forms.Label();
            this.LCantCadete = new System.Windows.Forms.Label();
            this.LCantJuvenil = new System.Windows.Forms.Label();
            this.LCantVeteranos = new System.Windows.Forms.Label();
            this.bIngresar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.nudDia = new System.Windows.Forms.NumericUpDown();
            this.nudMes = new System.Windows.Forms.NumericUpDown();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(128, 67);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(183, 20);
            this.tNombre.TabIndex = 0;
            this.tNombre.TextChanged += new System.EventHandler(this.tNombre_TextChanged);
            // 
            // tApellido
            // 
            this.tApellido.Location = new System.Drawing.Point(128, 124);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(183, 20);
            this.tApellido.TabIndex = 1;
            this.tApellido.TextChanged += new System.EventHandler(this.tApellido_TextChanged);
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(49, 74);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(47, 13);
            this.LNombre.TabIndex = 2;
            this.LNombre.Text = "Nombre:";
            this.LNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(49, 131);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(47, 13);
            this.LApellido.TabIndex = 3;
            this.LApellido.Text = "Apellido:";
            this.LApellido.Click += new System.EventHandler(this.LApellido_Click);
            // 
            // LFechaNac
            // 
            this.LFechaNac.AutoSize = true;
            this.LFechaNac.Location = new System.Drawing.Point(49, 181);
            this.LFechaNac.Name = "LFechaNac";
            this.LFechaNac.Size = new System.Drawing.Size(58, 26);
            this.LFechaNac.TabIndex = 4;
            this.LFechaNac.Text = "Fecha de\r\nnacimiento";
            this.LFechaNac.Click += new System.EventHandler(this.LFechaNac_Click);
            // 
            // LCategorias
            // 
            this.LCategorias.AutoSize = true;
            this.LCategorias.Location = new System.Drawing.Point(422, 30);
            this.LCategorias.Name = "LCategorias";
            this.LCategorias.Size = new System.Drawing.Size(60, 13);
            this.LCategorias.TabIndex = 5;
            this.LCategorias.Text = "Categorias:";
            this.LCategorias.Click += new System.EventHandler(this.LCategorias_Click);
            // 
            // LCantBenjamin
            // 
            this.LCantBenjamin.AutoSize = true;
            this.LCantBenjamin.Location = new System.Drawing.Point(368, 111);
            this.LCantBenjamin.Name = "LCantBenjamin";
            this.LCantBenjamin.Size = new System.Drawing.Size(53, 13);
            this.LCantBenjamin.TabIndex = 6;
            this.LCantBenjamin.Text = "Benjamin:";
            this.LCantBenjamin.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LCantInfantil
            // 
            this.LCantInfantil.AutoSize = true;
            this.LCantInfantil.Location = new System.Drawing.Point(368, 146);
            this.LCantInfantil.Name = "LCantInfantil";
            this.LCantInfantil.Size = new System.Drawing.Size(41, 13);
            this.LCantInfantil.TabIndex = 7;
            this.LCantInfantil.Text = "Infantil:";
            this.LCantInfantil.Click += new System.EventHandler(this.LCantInfantil_Click);
            // 
            // LAmateur
            // 
            this.LAmateur.AutoSize = true;
            this.LAmateur.Location = new System.Drawing.Point(368, 181);
            this.LAmateur.Name = "LAmateur";
            this.LAmateur.Size = new System.Drawing.Size(49, 13);
            this.LAmateur.TabIndex = 8;
            this.LAmateur.Text = "Amateur:";
            this.LAmateur.Click += new System.EventHandler(this.LAmateur_Click);
            // 
            // LCantQuerubin
            // 
            this.LCantQuerubin.AutoSize = true;
            this.LCantQuerubin.Location = new System.Drawing.Point(368, 74);
            this.LCantQuerubin.Name = "LCantQuerubin";
            this.LCantQuerubin.Size = new System.Drawing.Size(53, 13);
            this.LCantQuerubin.TabIndex = 9;
            this.LCantQuerubin.Text = "Querubin:";
            this.LCantQuerubin.Click += new System.EventHandler(this.LCantQuerubin_Click);
            // 
            // LCantCadete
            // 
            this.LCantCadete.AutoSize = true;
            this.LCantCadete.Location = new System.Drawing.Point(493, 74);
            this.LCantCadete.Name = "LCantCadete";
            this.LCantCadete.Size = new System.Drawing.Size(44, 13);
            this.LCantCadete.TabIndex = 10;
            this.LCantCadete.Text = "Cadete:";
            this.LCantCadete.Click += new System.EventHandler(this.LCantCadete_Click);
            // 
            // LCantJuvenil
            // 
            this.LCantJuvenil.AutoSize = true;
            this.LCantJuvenil.Location = new System.Drawing.Point(494, 111);
            this.LCantJuvenil.Name = "LCantJuvenil";
            this.LCantJuvenil.Size = new System.Drawing.Size(43, 13);
            this.LCantJuvenil.TabIndex = 11;
            this.LCantJuvenil.Text = "Juvenil:";
            this.LCantJuvenil.Click += new System.EventHandler(this.LCantJuvenil_Click);
            // 
            // LCantVeteranos
            // 
            this.LCantVeteranos.AutoSize = true;
            this.LCantVeteranos.Location = new System.Drawing.Point(493, 146);
            this.LCantVeteranos.Name = "LCantVeteranos";
            this.LCantVeteranos.Size = new System.Drawing.Size(58, 13);
            this.LCantVeteranos.TabIndex = 12;
            this.LCantVeteranos.Text = "Veteranos:";
            this.LCantVeteranos.Click += new System.EventHandler(this.LCantVeteranos_Click);
            // 
            // bIngresar
            // 
            this.bIngresar.Location = new System.Drawing.Point(128, 232);
            this.bIngresar.Name = "bIngresar";
            this.bIngresar.Size = new System.Drawing.Size(183, 28);
            this.bIngresar.TabIndex = 13;
            this.bIngresar.Text = "Ingresar";
            this.bIngresar.UseVisualStyleBackColor = true;
            this.bIngresar.Click += new System.EventHandler(this.bIngresar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bCancelar.Location = new System.Drawing.Point(0, 353);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(608, 31);
            this.bCancelar.TabIndex = 14;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // nudDia
            // 
            this.nudDia.Location = new System.Drawing.Point(128, 187);
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
            this.nudDia.Size = new System.Drawing.Size(47, 20);
            this.nudDia.TabIndex = 15;
            this.nudDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDia.ValueChanged += new System.EventHandler(this.nudDia_ValueChanged);
            // 
            // nudMes
            // 
            this.nudMes.Location = new System.Drawing.Point(196, 187);
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
            this.nudMes.Size = new System.Drawing.Size(47, 20);
            this.nudMes.TabIndex = 16;
            this.nudMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMes.ValueChanged += new System.EventHandler(this.nudMes_ValueChanged);
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(264, 187);
            this.nudAnio.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nudAnio.Minimum = new decimal(new int[] {
            1950,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(47, 20);
            this.nudAnio.TabIndex = 17;
            this.nudAnio.ThousandsSeparator = true;
            this.nudAnio.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudAnio.ValueChanged += new System.EventHandler(this.nudAnio_ValueChanged);
            // 
            // FCategorizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 384);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.nudMes);
            this.Controls.Add(this.nudDia);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bIngresar);
            this.Controls.Add(this.LCantVeteranos);
            this.Controls.Add(this.LCantJuvenil);
            this.Controls.Add(this.LCantCadete);
            this.Controls.Add(this.LCantQuerubin);
            this.Controls.Add(this.LAmateur);
            this.Controls.Add(this.LCantInfantil);
            this.Controls.Add(this.LCantBenjamin);
            this.Controls.Add(this.LCategorias);
            this.Controls.Add(this.LFechaNac);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.LNombre);
            this.Controls.Add(this.tApellido);
            this.Controls.Add(this.tNombre);
            this.Name = "FCategorizar";
            this.Text = "Categorizar";
            this.Load += new System.EventHandler(this.FCategorizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LFechaNac;
        private System.Windows.Forms.Label LCategorias;
        private System.Windows.Forms.Label LCantBenjamin;
        private System.Windows.Forms.Label LCantInfantil;
        private System.Windows.Forms.Label LAmateur;
        private System.Windows.Forms.Label LCantQuerubin;
        private System.Windows.Forms.Label LCantCadete;
        private System.Windows.Forms.Label LCantJuvenil;
        private System.Windows.Forms.Label LCantVeteranos;
        private System.Windows.Forms.Button bIngresar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.NumericUpDown nudDia;
        private System.Windows.Forms.NumericUpDown nudMes;
        private System.Windows.Forms.NumericUpDown nudAnio;
    }
}

