
namespace SucecionesTP4
{
    partial class FSuceciones
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
            this.LTabladel = new System.Windows.Forms.Label();
            this.bTablaMultiplicar = new System.Windows.Forms.Button();
            this.nudTabla = new System.Windows.Forms.NumericUpDown();
            this.LFibonaccidel = new System.Windows.Forms.Label();
            this.nudFibonacci = new System.Windows.Forms.NumericUpDown();
            this.bFibonacci = new System.Windows.Forms.Button();
            this.nudDesde = new System.Windows.Forms.NumericUpDown();
            this.nudHasta = new System.Windows.Forms.NumericUpDown();
            this.nudCada = new System.Windows.Forms.NumericUpDown();
            this.LDesde = new System.Windows.Forms.Label();
            this.LHasta = new System.Windows.Forms.Label();
            this.LCada = new System.Windows.Forms.Label();
            this.LRespuesta = new System.Windows.Forms.Label();
            this.bSerie = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFibonacci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCada)).BeginInit();
            this.SuspendLayout();
            // 
            // LTabladel
            // 
            this.LTabladel.AutoSize = true;
            this.LTabladel.Location = new System.Drawing.Point(30, 23);
            this.LTabladel.Name = "LTabladel";
            this.LTabladel.Size = new System.Drawing.Size(54, 13);
            this.LTabladel.TabIndex = 0;
            this.LTabladel.Text = "Tabla del:";
            // 
            // bTablaMultiplicar
            // 
            this.bTablaMultiplicar.Location = new System.Drawing.Point(33, 47);
            this.bTablaMultiplicar.Name = "bTablaMultiplicar";
            this.bTablaMultiplicar.Size = new System.Drawing.Size(114, 27);
            this.bTablaMultiplicar.TabIndex = 1;
            this.bTablaMultiplicar.Text = "Tabla de Multiplicar";
            this.bTablaMultiplicar.UseVisualStyleBackColor = true;
            this.bTablaMultiplicar.Click += new System.EventHandler(this.bTablaMultiplicar_Click);
            // 
            // nudTabla
            // 
            this.nudTabla.Location = new System.Drawing.Point(90, 21);
            this.nudTabla.Name = "nudTabla";
            this.nudTabla.Size = new System.Drawing.Size(57, 20);
            this.nudTabla.TabIndex = 2;
            this.nudTabla.ValueChanged += new System.EventHandler(this.nudTabla_ValueChanged);
            // 
            // LFibonaccidel
            // 
            this.LFibonaccidel.AutoSize = true;
            this.LFibonaccidel.Location = new System.Drawing.Point(13, 89);
            this.LFibonaccidel.Name = "LFibonaccidel";
            this.LFibonaccidel.Size = new System.Drawing.Size(71, 13);
            this.LFibonaccidel.TabIndex = 3;
            this.LFibonaccidel.Text = "Fibonacci de:";
            // 
            // nudFibonacci
            // 
            this.nudFibonacci.Location = new System.Drawing.Point(90, 87);
            this.nudFibonacci.Name = "nudFibonacci";
            this.nudFibonacci.Size = new System.Drawing.Size(57, 20);
            this.nudFibonacci.TabIndex = 4;
            // 
            // bFibonacci
            // 
            this.bFibonacci.Location = new System.Drawing.Point(33, 113);
            this.bFibonacci.Name = "bFibonacci";
            this.bFibonacci.Size = new System.Drawing.Size(114, 27);
            this.bFibonacci.TabIndex = 5;
            this.bFibonacci.Text = "Fibonacci";
            this.bFibonacci.UseVisualStyleBackColor = true;
            this.bFibonacci.Click += new System.EventHandler(this.bFibonacci_Click);
            // 
            // nudDesde
            // 
            this.nudDesde.Location = new System.Drawing.Point(93, 150);
            this.nudDesde.Name = "nudDesde";
            this.nudDesde.Size = new System.Drawing.Size(57, 20);
            this.nudDesde.TabIndex = 6;
            // 
            // nudHasta
            // 
            this.nudHasta.Location = new System.Drawing.Point(93, 176);
            this.nudHasta.Name = "nudHasta";
            this.nudHasta.Size = new System.Drawing.Size(57, 20);
            this.nudHasta.TabIndex = 7;
            // 
            // nudCada
            // 
            this.nudCada.Location = new System.Drawing.Point(93, 202);
            this.nudCada.Name = "nudCada";
            this.nudCada.Size = new System.Drawing.Size(57, 20);
            this.nudCada.TabIndex = 8;
            // 
            // LDesde
            // 
            this.LDesde.AutoSize = true;
            this.LDesde.Location = new System.Drawing.Point(43, 157);
            this.LDesde.Name = "LDesde";
            this.LDesde.Size = new System.Drawing.Size(41, 13);
            this.LDesde.TabIndex = 9;
            this.LDesde.Text = "Desde:";
            // 
            // LHasta
            // 
            this.LHasta.AutoSize = true;
            this.LHasta.Location = new System.Drawing.Point(43, 183);
            this.LHasta.Name = "LHasta";
            this.LHasta.Size = new System.Drawing.Size(38, 13);
            this.LHasta.TabIndex = 10;
            this.LHasta.Text = "Hasta:";
            // 
            // LCada
            // 
            this.LCada.AutoSize = true;
            this.LCada.Location = new System.Drawing.Point(46, 209);
            this.LCada.Name = "LCada";
            this.LCada.Size = new System.Drawing.Size(35, 13);
            this.LCada.TabIndex = 11;
            this.LCada.Text = "Cada:";
            this.LCada.Click += new System.EventHandler(this.LRespuesta_Click);
            // 
            // LRespuesta
            // 
            this.LRespuesta.AutoSize = true;
            this.LRespuesta.Location = new System.Drawing.Point(173, 20);
            this.LRespuesta.Name = "LRespuesta";
            this.LRespuesta.Size = new System.Drawing.Size(0, 13);
            this.LRespuesta.TabIndex = 12;
            this.LRespuesta.Click += new System.EventHandler(this.LRespuesta_Click);
            // 
            // bSerie
            // 
            this.bSerie.Location = new System.Drawing.Point(33, 234);
            this.bSerie.Name = "bSerie";
            this.bSerie.Size = new System.Drawing.Size(114, 23);
            this.bSerie.TabIndex = 13;
            this.bSerie.Text = "Serie";
            this.bSerie.UseVisualStyleBackColor = true;
            // 
            // bCerrar
            // 
            this.bCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bCerrar.Location = new System.Drawing.Point(0, 275);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(336, 29);
            this.bCerrar.TabIndex = 14;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // FSuceciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 304);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bSerie);
            this.Controls.Add(this.LRespuesta);
            this.Controls.Add(this.LCada);
            this.Controls.Add(this.LHasta);
            this.Controls.Add(this.LDesde);
            this.Controls.Add(this.nudCada);
            this.Controls.Add(this.nudHasta);
            this.Controls.Add(this.nudDesde);
            this.Controls.Add(this.bFibonacci);
            this.Controls.Add(this.nudFibonacci);
            this.Controls.Add(this.LFibonaccidel);
            this.Controls.Add(this.nudTabla);
            this.Controls.Add(this.bTablaMultiplicar);
            this.Controls.Add(this.LTabladel);
            this.Name = "FSuceciones";
            this.Text = "Suceciones";
            ((System.ComponentModel.ISupportInitialize)(this.nudTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFibonacci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LTabladel;
        private System.Windows.Forms.Button bTablaMultiplicar;
        private System.Windows.Forms.NumericUpDown nudTabla;
        private System.Windows.Forms.Label LFibonaccidel;
        private System.Windows.Forms.NumericUpDown nudFibonacci;
        private System.Windows.Forms.Button bFibonacci;
        private System.Windows.Forms.NumericUpDown nudDesde;
        private System.Windows.Forms.NumericUpDown nudHasta;
        private System.Windows.Forms.NumericUpDown nudCada;
        private System.Windows.Forms.Label LDesde;
        private System.Windows.Forms.Label LHasta;
        private System.Windows.Forms.Label LCada;
        private System.Windows.Forms.Label LRespuesta;
        private System.Windows.Forms.Button bSerie;
        private System.Windows.Forms.Button bCerrar;
    }
}

