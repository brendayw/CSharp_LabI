
namespace IngresoTP4
{
    partial class FIngreso
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
            this.labelNombres = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.labelcontra = new System.Windows.Forms.Label();
            this.labelconfirma = new System.Windows.Forms.Label();
            this.tNombres = new System.Windows.Forms.TextBox();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.tContrasenia = new System.Windows.Forms.TextBox();
            this.tConfirmacion = new System.Windows.Forms.TextBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Location = new System.Drawing.Point(103, 42);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(52, 13);
            this.labelNombres.TabIndex = 0;
            this.labelNombres.Text = "Nombres:";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(103, 79);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(52, 13);
            this.labelApellidos.TabIndex = 1;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Location = new System.Drawing.Point(120, 116);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(35, 13);
            this.labelemail.TabIndex = 2;
            this.labelemail.Text = "Email:";
            // 
            // labelcontra
            // 
            this.labelcontra.AutoSize = true;
            this.labelcontra.Location = new System.Drawing.Point(91, 153);
            this.labelcontra.Name = "labelcontra";
            this.labelcontra.Size = new System.Drawing.Size(64, 13);
            this.labelcontra.TabIndex = 3;
            this.labelcontra.Text = "Contraseña:";
            // 
            // labelconfirma
            // 
            this.labelconfirma.AutoSize = true;
            this.labelconfirma.Location = new System.Drawing.Point(84, 190);
            this.labelconfirma.Name = "labelconfirma";
            this.labelconfirma.Size = new System.Drawing.Size(71, 13);
            this.labelconfirma.TabIndex = 4;
            this.labelconfirma.Text = "Confirmacion:";
            // 
            // tNombres
            // 
            this.tNombres.Location = new System.Drawing.Point(188, 35);
            this.tNombres.Name = "tNombres";
            this.tNombres.Size = new System.Drawing.Size(204, 20);
            this.tNombres.TabIndex = 5;
            // 
            // tApellidos
            // 
            this.tApellidos.Location = new System.Drawing.Point(188, 77);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(204, 20);
            this.tApellidos.TabIndex = 6;
            // 
            // tEmail
            // 
            this.tEmail.Location = new System.Drawing.Point(188, 117);
            this.tEmail.Name = "tEmail";
            this.tEmail.Size = new System.Drawing.Size(204, 20);
            this.tEmail.TabIndex = 7;
            // 
            // tContrasenia
            // 
            this.tContrasenia.Location = new System.Drawing.Point(188, 152);
            this.tContrasenia.Name = "tContrasenia";
            this.tContrasenia.PasswordChar = '*';
            this.tContrasenia.Size = new System.Drawing.Size(204, 20);
            this.tContrasenia.TabIndex = 8;
            // 
            // tConfirmacion
            // 
            this.tConfirmacion.Location = new System.Drawing.Point(188, 190);
            this.tConfirmacion.Name = "tConfirmacion";
            this.tConfirmacion.PasswordChar = '*';
            this.tConfirmacion.Size = new System.Drawing.Size(204, 20);
            this.tConfirmacion.TabIndex = 9;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(222, 276);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(108, 34);
            this.bAceptar.TabIndex = 10;
            this.bAceptar.Text = "&Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(350, 276);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(108, 34);
            this.bCancelar.TabIndex = 11;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // FIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 322);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tConfirmacion);
            this.Controls.Add(this.tContrasenia);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.tNombres);
            this.Controls.Add(this.labelconfirma);
            this.Controls.Add(this.labelcontra);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombres);
            this.Name = "FIngreso";
            this.Text = "Ingreso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labelcontra;
        private System.Windows.Forms.Label labelconfirma;
        private System.Windows.Forms.TextBox tNombres;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox tContrasenia;
        private System.Windows.Forms.TextBox tConfirmacion;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
    }
}

