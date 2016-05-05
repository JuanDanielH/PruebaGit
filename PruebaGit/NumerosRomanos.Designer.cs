namespace PruebaGit
{
    partial class NumerosRomanos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroNormal = new System.Windows.Forms.TextBox();
            this.txtNumeroRomano = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convierte a Numeros Romanos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero a Convertir";
            // 
            // txtNumeroNormal
            // 
            this.txtNumeroNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroNormal.Location = new System.Drawing.Point(149, 91);
            this.txtNumeroNormal.Name = "txtNumeroNormal";
            this.txtNumeroNormal.Size = new System.Drawing.Size(112, 23);
            this.txtNumeroNormal.TabIndex = 2;
            this.txtNumeroNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroNormal.TextChanged += new System.EventHandler(this.txtNumeroNormal_TextChanged);
            // 
            // txtNumeroRomano
            // 
            this.txtNumeroRomano.Enabled = false;
            this.txtNumeroRomano.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroRomano.Location = new System.Drawing.Point(149, 135);
            this.txtNumeroRomano.Name = "txtNumeroRomano";
            this.txtNumeroRomano.Size = new System.Drawing.Size(112, 23);
            this.txtNumeroRomano.TabIndex = 4;
            this.txtNumeroRomano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Numero Romano";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumerosRomanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 196);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumeroRomano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumeroNormal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NumerosRomanos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numeros Romanos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumeroNormal;
        private System.Windows.Forms.TextBox txtNumeroRomano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}