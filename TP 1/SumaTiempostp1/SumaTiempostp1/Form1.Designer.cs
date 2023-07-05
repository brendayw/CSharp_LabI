
namespace SumaTiempostp1
{
    partial class FSumarTiempos
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
            this.ltextoinformativo = new System.Windows.Forms.Label();
            this.ttiempo1hs = new System.Windows.Forms.TextBox();
            this.tTiempo1m = new System.Windows.Forms.TextBox();
            this.ttiempo1s = new System.Windows.Forms.TextBox();
            this.ltiempo1 = new System.Windows.Forms.Label();
            this.ltiempo2 = new System.Windows.Forms.Label();
            this.ttiempo2hs = new System.Windows.Forms.TextBox();
            this.ttiempo2m = new System.Windows.Forms.TextBox();
            this.ttiempo2s = new System.Windows.Forms.TextBox();
            this.bsuma = new System.Windows.Forms.Button();
            this.bcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltextoinformativo
            // 
            this.ltextoinformativo.AutoSize = true;
            this.ltextoinformativo.Location = new System.Drawing.Point(157, 47);
            this.ltextoinformativo.Name = "ltextoinformativo";
            this.ltextoinformativo.Size = new System.Drawing.Size(256, 13);
            this.ltextoinformativo.TabIndex = 0;
            this.ltextoinformativo.Text = "Ingrese dos tiempos en hs, m, s para poder sumarlos:";
            // 
            // ttiempo1hs
            // 
            this.ttiempo1hs.Location = new System.Drawing.Point(210, 84);
            this.ttiempo1hs.Name = "ttiempo1hs";
            this.ttiempo1hs.Size = new System.Drawing.Size(47, 20);
            this.ttiempo1hs.TabIndex = 1;
            this.ttiempo1hs.TextChanged += new System.EventHandler(this.ttiempo1hs_TextChanged);
            // 
            // tTiempo1m
            // 
            this.tTiempo1m.Location = new System.Drawing.Point(277, 84);
            this.tTiempo1m.Name = "tTiempo1m";
            this.tTiempo1m.Size = new System.Drawing.Size(47, 20);
            this.tTiempo1m.TabIndex = 2;
            this.tTiempo1m.TextChanged += new System.EventHandler(this.ttiempo1m_TextChanged);
            // 
            // ttiempo1s
            // 
            this.ttiempo1s.Location = new System.Drawing.Point(345, 84);
            this.ttiempo1s.Name = "ttiempo1s";
            this.ttiempo1s.Size = new System.Drawing.Size(47, 20);
            this.ttiempo1s.TabIndex = 3;
            this.ttiempo1s.TextChanged += new System.EventHandler(this.ttiempo1s_TextChanged);
            // 
            // ltiempo1
            // 
            this.ltiempo1.AutoSize = true;
            this.ltiempo1.Location = new System.Drawing.Point(131, 87);
            this.ltiempo1.Name = "ltiempo1";
            this.ltiempo1.Size = new System.Drawing.Size(54, 13);
            this.ltiempo1.TabIndex = 4;
            this.ltiempo1.Text = "Tiempo 1:";
            this.ltiempo1.Click += new System.EventHandler(this.label2_Click);
            // 
            // ltiempo2
            // 
            this.ltiempo2.AutoSize = true;
            this.ltiempo2.Location = new System.Drawing.Point(131, 134);
            this.ltiempo2.Name = "ltiempo2";
            this.ltiempo2.Size = new System.Drawing.Size(54, 13);
            this.ltiempo2.TabIndex = 5;
            this.ltiempo2.Text = "Tiempo 2:";
            // 
            // ttiempo2hs
            // 
            this.ttiempo2hs.Location = new System.Drawing.Point(210, 134);
            this.ttiempo2hs.Name = "ttiempo2hs";
            this.ttiempo2hs.Size = new System.Drawing.Size(47, 20);
            this.ttiempo2hs.TabIndex = 6;
            this.ttiempo2hs.TextChanged += new System.EventHandler(this.ttiempo2hs_TextChanged);
            // 
            // ttiempo2m
            // 
            this.ttiempo2m.Location = new System.Drawing.Point(277, 134);
            this.ttiempo2m.Name = "ttiempo2m";
            this.ttiempo2m.Size = new System.Drawing.Size(47, 20);
            this.ttiempo2m.TabIndex = 7;
            this.ttiempo2m.TextChanged += new System.EventHandler(this.ttiempo2m_TextChanged);
            // 
            // ttiempo2s
            // 
            this.ttiempo2s.Location = new System.Drawing.Point(345, 134);
            this.ttiempo2s.Name = "ttiempo2s";
            this.ttiempo2s.Size = new System.Drawing.Size(47, 20);
            this.ttiempo2s.TabIndex = 8;
            this.ttiempo2s.TextChanged += new System.EventHandler(this.ttiempo2s_TextChanged);
            // 
            // bsuma
            // 
            this.bsuma.Location = new System.Drawing.Point(277, 174);
            this.bsuma.Name = "bsuma";
            this.bsuma.Size = new System.Drawing.Size(114, 29);
            this.bsuma.TabIndex = 9;
            this.bsuma.Text = "Sumar tiempos";
            this.bsuma.UseVisualStyleBackColor = true;
            this.bsuma.Click += new System.EventHandler(this.bsuma_Click);
            // 
            // bcancelar
            // 
            this.bcancelar.Location = new System.Drawing.Point(443, 295);
            this.bcancelar.Name = "bcancelar";
            this.bcancelar.Size = new System.Drawing.Size(89, 30);
            this.bcancelar.TabIndex = 10;
            this.bcancelar.Text = "Cancelar";
            this.bcancelar.UseVisualStyleBackColor = true;
            // 
            // FSumarTiempos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 337);
            this.Controls.Add(this.bcancelar);
            this.Controls.Add(this.bsuma);
            this.Controls.Add(this.ttiempo2s);
            this.Controls.Add(this.ttiempo2m);
            this.Controls.Add(this.ttiempo2hs);
            this.Controls.Add(this.ltiempo2);
            this.Controls.Add(this.ltiempo1);
            this.Controls.Add(this.ttiempo1s);
            this.Controls.Add(this.tTiempo1m);
            this.Controls.Add(this.ttiempo1hs);
            this.Controls.Add(this.ltextoinformativo);
            this.Name = "FSumarTiempos";
            this.Text = "Sumar Tiempos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltextoinformativo;
        private System.Windows.Forms.TextBox ttiempo1hs;
        private System.Windows.Forms.TextBox tTiempo1m;
        private System.Windows.Forms.TextBox ttiempo1s;
        private System.Windows.Forms.Label ltiempo1;
        private System.Windows.Forms.Label ltiempo2;
        private System.Windows.Forms.TextBox ttiempo2hs;
        private System.Windows.Forms.TextBox ttiempo2m;
        private System.Windows.Forms.TextBox ttiempo2s;
        private System.Windows.Forms.Button bsuma;
        private System.Windows.Forms.Button bcancelar;
    }
}

