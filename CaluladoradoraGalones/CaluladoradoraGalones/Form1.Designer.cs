namespace CaluladoradoraGalones
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.btnCacular = new System.Windows.Forms.Button();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.txtRendimiento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSUMO DE CONBUSTIBLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "RENDIMIENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "DISTANCIA";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Resultado.Location = new System.Drawing.Point(352, 293);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(0, 16);
            this.Resultado.TabIndex = 3;
            // 
            // btnCacular
            // 
            this.btnCacular.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCacular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCacular.Location = new System.Drawing.Point(322, 222);
            this.btnCacular.Name = "btnCacular";
            this.btnCacular.Size = new System.Drawing.Size(141, 31);
            this.btnCacular.TabIndex = 4;
            this.btnCacular.Text = "CALCULAR";
            this.btnCacular.UseVisualStyleBackColor = false;
            this.btnCacular.Click += new System.EventHandler(this.btnCacular_Click);
            // 
            // txtDistancia
            // 
            this.txtDistancia.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDistancia.Location = new System.Drawing.Point(355, 85);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(245, 30);
            this.txtDistancia.TabIndex = 5;
            // 
            // txtRendimiento
            // 
            this.txtRendimiento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtRendimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRendimiento.Location = new System.Drawing.Point(355, 161);
            this.txtRendimiento.Name = "txtRendimiento";
            this.txtRendimiento.Size = new System.Drawing.Size(245, 27);
            this.txtRendimiento.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRendimiento);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.btnCacular);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Consumo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button btnCacular;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.TextBox txtRendimiento;
    }
}

