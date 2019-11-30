namespace FrbaOfertas.PantallaUsuarios
{
    partial class PantallaProveedor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RsTB = new System.Windows.Forms.TextBox();
            this.ProveedorTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OfertaBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.CambiarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RsTB);
            this.groupBox1.Controls.Add(this.ProveedorTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            // 
            // RsTB
            // 
            this.RsTB.Enabled = false;
            this.RsTB.Location = new System.Drawing.Point(195, 93);
            this.RsTB.Name = "RsTB";
            this.RsTB.Size = new System.Drawing.Size(163, 20);
            this.RsTB.TabIndex = 3;
            // 
            // ProveedorTB
            // 
            this.ProveedorTB.Enabled = false;
            this.ProveedorTB.Location = new System.Drawing.Point(195, 48);
            this.ProveedorTB.Name = "ProveedorTB";
            this.ProveedorTB.Size = new System.Drawing.Size(163, 20);
            this.ProveedorTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAZÓN SOCIAL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CambiarBtn);
            this.groupBox2.Controls.Add(this.OfertaBtn);
            this.groupBox2.Location = new System.Drawing.Point(412, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 158);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // OfertaBtn
            // 
            this.OfertaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfertaBtn.Location = new System.Drawing.Point(30, 34);
            this.OfertaBtn.Name = "OfertaBtn";
            this.OfertaBtn.Size = new System.Drawing.Size(140, 47);
            this.OfertaBtn.TabIndex = 0;
            this.OfertaBtn.Text = "Nueva oferta";
            this.OfertaBtn.UseVisualStyleBackColor = true;
            this.OfertaBtn.Click += new System.EventHandler(this.OfertaBtn_Click);
            // 
            // SalirBtn
            // 
            this.SalirBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.SalirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirBtn.Location = new System.Drawing.Point(148, 177);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(125, 40);
            this.SalirBtn.TabIndex = 2;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = false;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // CambiarBtn
            // 
            this.CambiarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CambiarBtn.Location = new System.Drawing.Point(30, 93);
            this.CambiarBtn.Name = "CambiarBtn";
            this.CambiarBtn.Size = new System.Drawing.Size(140, 47);
            this.CambiarBtn.TabIndex = 1;
            this.CambiarBtn.Text = "Cambiar Contraseña";
            this.CambiarBtn.UseVisualStyleBackColor = true;
            // 
            // PantallaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 226);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PantallaProveedor";
            this.Text = "PantallaProveedor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox RsTB;
        private System.Windows.Forms.TextBox ProveedorTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button OfertaBtn;
        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.Button CambiarBtn;

    }
}