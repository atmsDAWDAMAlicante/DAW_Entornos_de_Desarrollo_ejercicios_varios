namespace ExamenED1EV2324
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDividendo = new System.Windows.Forms.TextBox();
            this.txtDivisor = new System.Windows.Forms.TextBox();
            this.lblDividendo = new System.Windows.Forms.Label();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.btDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDividendo
            // 
            this.txtDividendo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDividendo.Location = new System.Drawing.Point(179, 43);
            this.txtDividendo.Name = "txtDividendo";
            this.txtDividendo.Size = new System.Drawing.Size(115, 32);
            this.txtDividendo.TabIndex = 0;
            // 
            // txtDivisor
            // 
            this.txtDivisor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDivisor.Location = new System.Drawing.Point(180, 97);
            this.txtDivisor.Name = "txtDivisor";
            this.txtDivisor.Size = new System.Drawing.Size(113, 32);
            this.txtDivisor.TabIndex = 1;
            // 
            // lblDividendo
            // 
            this.lblDividendo.AutoSize = true;
            this.lblDividendo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDividendo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDividendo.Location = new System.Drawing.Point(50, 50);
            this.lblDividendo.Name = "lblDividendo";
            this.lblDividendo.Size = new System.Drawing.Size(109, 24);
            this.lblDividendo.TabIndex = 2;
            this.lblDividendo.Text = "Dividendo:";
            // 
            // lblDivisor
            // 
            this.lblDivisor.AutoSize = true;
            this.lblDivisor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivisor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDivisor.Location = new System.Drawing.Point(77, 100);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(82, 24);
            this.lblDivisor.TabIndex = 3;
            this.lblDivisor.Text = "Divisor:";
            // 
            // btDividir
            // 
            this.btDividir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btDividir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDividir.ForeColor = System.Drawing.Color.PapayaWhip;
            this.btDividir.Location = new System.Drawing.Point(116, 170);
            this.btDividir.Name = "btDividir";
            this.btDividir.Size = new System.Drawing.Size(130, 35);
            this.btDividir.TabIndex = 4;
            this.btDividir.Text = "Dividir";
            this.btDividir.UseVisualStyleBackColor = false;
            this.btDividir.Click += new System.EventHandler(this.btDividir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 245);
            this.Controls.Add(this.btDividir);
            this.Controls.Add(this.lblDivisor);
            this.Controls.Add(this.lblDividendo);
            this.Controls.Add(this.txtDivisor);
            this.Controls.Add(this.txtDividendo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDividendo;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Label lblDividendo;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.Button btDividir;
    }
}

