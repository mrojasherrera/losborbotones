﻿namespace FrbaOfertas.CargaCredito
{
    partial class DummyForm1
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
            this.btnFechaSistema = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnFechaSistema
            // 
            this.btnFechaSistema.Location = new System.Drawing.Point(65, 126);
            this.btnFechaSistema.Name = "btnFechaSistema";
            this.btnFechaSistema.Size = new System.Drawing.Size(75, 23);
            this.btnFechaSistema.TabIndex = 1;
            this.btnFechaSistema.Text = " Fecha Sistema";
            this.btnFechaSistema.UseVisualStyleBackColor = true;
            this.btnFechaSistema.Click += new System.EventHandler(this.btnFechaSistema_Click);
            // 
            // DummyForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnFechaSistema);
            this.Controls.Add(this.label1);
            this.Name = "DummyForm1";
            this.Text = "DummyForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFechaSistema;
    }
}