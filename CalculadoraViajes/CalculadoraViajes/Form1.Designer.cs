namespace CalculadoraViajes
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
            this.txtPtOrigen = new System.Windows.Forms.TextBox();
            this.txtPtDestino = new System.Windows.Forms.TextBox();
            this.Vconstante = new System.Windows.Forms.TextBox();
            this.butonCalcular = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPtOrigen
            // 
            this.txtPtOrigen.Location = new System.Drawing.Point(402, 98);
            this.txtPtOrigen.Name = "txtPtOrigen";
            this.txtPtOrigen.Size = new System.Drawing.Size(205, 22);
            this.txtPtOrigen.TabIndex = 0;
            // 
            // txtPtDestino
            // 
            this.txtPtDestino.Location = new System.Drawing.Point(402, 143);
            this.txtPtDestino.Name = "txtPtDestino";
            this.txtPtDestino.Size = new System.Drawing.Size(205, 22);
            this.txtPtDestino.TabIndex = 1;
            // 
            // Vconstante
            // 
            this.Vconstante.Location = new System.Drawing.Point(402, 190);
            this.Vconstante.Name = "Vconstante";
            this.Vconstante.Size = new System.Drawing.Size(205, 22);
            this.Vconstante.TabIndex = 2;
            // 
            // butonCalcular
            // 
            this.butonCalcular.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.butonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butonCalcular.Location = new System.Drawing.Point(402, 242);
            this.butonCalcular.Name = "butonCalcular";
            this.butonCalcular.Size = new System.Drawing.Size(199, 30);
            this.butonCalcular.TabIndex = 3;
            this.butonCalcular.Text = "CLACULAR";
            this.butonCalcular.UseVisualStyleBackColor = false;
            this.butonCalcular.Click += new System.EventHandler(this.butonCalcular_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelResultado.Location = new System.Drawing.Point(399, 308);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 16);
            this.labelResultado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "PUNTO ORIGEN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "PUNTO DESTINO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "VELOCIAD Const";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(298, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Calculadora de Viajes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(851, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.butonCalcular);
            this.Controls.Add(this.Vconstante);
            this.Controls.Add(this.txtPtDestino);
            this.Controls.Add(this.txtPtOrigen);
            this.Name = "Form1";
            this.Text = "Viajes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPtOrigen;
        private System.Windows.Forms.TextBox txtPtDestino;
        private System.Windows.Forms.TextBox Vconstante;
        private System.Windows.Forms.Button butonCalcular;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

