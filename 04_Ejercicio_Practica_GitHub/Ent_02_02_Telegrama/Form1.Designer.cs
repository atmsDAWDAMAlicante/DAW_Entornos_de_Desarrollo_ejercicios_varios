namespace Ent_02_02_Telegrama
{
    partial class Ent_02_02_Telegrama
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
            this.button1 = new System.Windows.Forms.Button();
            this.cbUrgente = new System.Windows.Forms.CheckBox();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblCoste = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(542, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbUrgente
            // 
            this.cbUrgente.AutoSize = true;
            this.cbUrgente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUrgente.Location = new System.Drawing.Point(38, 289);
            this.cbUrgente.Name = "cbUrgente";
            this.cbUrgente.Size = new System.Drawing.Size(137, 33);
            this.cbUrgente.TabIndex = 1;
            this.cbUrgente.Text = "Urgente?";
            this.cbUrgente.UseVisualStyleBackColor = true;
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelegrama.Location = new System.Drawing.Point(38, 69);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(713, 202);
            this.txtTelegrama.TabIndex = 2;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(38, 22);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(79, 29);
            this.lblTexto.TabIndex = 3;
            this.lblTexto.Text = "Texto";
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoste.Location = new System.Drawing.Point(38, 351);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(88, 29);
            this.lblCoste.TabIndex = 4;
            this.lblCoste.Text = "Coste:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(133, 350);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(157, 35);
            this.txtPrecio.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(339, 310);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Ent_02_02_Telegrama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblCoste);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.cbUrgente);
            this.Controls.Add(this.button1);
            this.Name = "Ent_02_02_Telegrama";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbUrgente;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

