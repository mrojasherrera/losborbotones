namespace FrbaOfertas.PantallaUsuarios
{
    partial class PantallaAdmin
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
            this.SalirBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClienteBtn = new System.Windows.Forms.Button();
            this.EstadisticoBtn = new System.Windows.Forms.Button();
            this.ProveedorBtn = new System.Windows.Forms.Button();
            this.FacturarBtn = new System.Windows.Forms.Button();
            this.RolBtn = new System.Windows.Forms.Button();
            this.CreditoBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AdmTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SalirBtn
            // 
            this.SalirBtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.SalirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirBtn.Location = new System.Drawing.Point(257, 331);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(135, 49);
            this.SalirBtn.TabIndex = 15;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = false;
            this.SalirBtn.Click += new System.EventHandler(this.SalirBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ClienteBtn);
            this.groupBox1.Controls.Add(this.EstadisticoBtn);
            this.groupBox1.Controls.Add(this.ProveedorBtn);
            this.groupBox1.Controls.Add(this.FacturarBtn);
            this.groupBox1.Controls.Add(this.RolBtn);
            this.groupBox1.Controls.Add(this.CreditoBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 216);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // ClienteBtn
            // 
            this.ClienteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClienteBtn.Location = new System.Drawing.Point(23, 37);
            this.ClienteBtn.Name = "ClienteBtn";
            this.ClienteBtn.Size = new System.Drawing.Size(135, 56);
            this.ClienteBtn.TabIndex = 7;
            this.ClienteBtn.Text = "ABM Cliente";
            this.ClienteBtn.UseVisualStyleBackColor = true;
            this.ClienteBtn.Click += new System.EventHandler(this.ClienteBtn_Click);
            // 
            // EstadisticoBtn
            // 
            this.EstadisticoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadisticoBtn.Location = new System.Drawing.Point(245, 121);
            this.EstadisticoBtn.Name = "EstadisticoBtn";
            this.EstadisticoBtn.Size = new System.Drawing.Size(135, 56);
            this.EstadisticoBtn.TabIndex = 12;
            this.EstadisticoBtn.Text = "Listado Estadístico";
            this.EstadisticoBtn.UseVisualStyleBackColor = true;
            this.EstadisticoBtn.Click += new System.EventHandler(this.EstadisticoBtn_Click);
            // 
            // ProveedorBtn
            // 
            this.ProveedorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProveedorBtn.Location = new System.Drawing.Point(245, 37);
            this.ProveedorBtn.Name = "ProveedorBtn";
            this.ProveedorBtn.Size = new System.Drawing.Size(135, 56);
            this.ProveedorBtn.TabIndex = 8;
            this.ProveedorBtn.Text = "ABM Proveedor";
            this.ProveedorBtn.UseVisualStyleBackColor = true;
            this.ProveedorBtn.Click += new System.EventHandler(this.ProveedorBtn_Click);
            // 
            // FacturarBtn
            // 
            this.FacturarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturarBtn.Location = new System.Drawing.Point(439, 121);
            this.FacturarBtn.Name = "FacturarBtn";
            this.FacturarBtn.Size = new System.Drawing.Size(135, 56);
            this.FacturarBtn.TabIndex = 11;
            this.FacturarBtn.Text = "Facturar Proveedor";
            this.FacturarBtn.UseVisualStyleBackColor = true;
            this.FacturarBtn.Click += new System.EventHandler(this.FacturarBtn_Click);
            // 
            // RolBtn
            // 
            this.RolBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RolBtn.Location = new System.Drawing.Point(439, 37);
            this.RolBtn.Name = "RolBtn";
            this.RolBtn.Size = new System.Drawing.Size(135, 56);
            this.RolBtn.TabIndex = 9;
            this.RolBtn.Text = "ABM Rol";
            this.RolBtn.UseVisualStyleBackColor = true;
            this.RolBtn.Click += new System.EventHandler(this.RolBtn_Click);
            // 
            // CreditoBtn
            // 
            this.CreditoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditoBtn.Location = new System.Drawing.Point(23, 121);
            this.CreditoBtn.Name = "CreditoBtn";
            this.CreditoBtn.Size = new System.Drawing.Size(135, 56);
            this.CreditoBtn.TabIndex = 10;
            this.CreditoBtn.Text = "Cargar Crédito";
            this.CreditoBtn.UseVisualStyleBackColor = true;
            this.CreditoBtn.Click += new System.EventHandler(this.CreditoBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AdmTB);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 91);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administrador General";
            // 
            // AdmTB
            // 
            this.AdmTB.Enabled = false;
            this.AdmTB.Location = new System.Drawing.Point(188, 40);
            this.AdmTB.Name = "AdmTB";
            this.AdmTB.Size = new System.Drawing.Size(180, 20);
            this.AdmTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMINISTRADOR:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaOfertas.Properties.Resources.icono_planificar_acciones_comerciales;
            this.pictureBox1.Location = new System.Drawing.Point(478, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // PantallaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "PantallaAdmin";
            this.Text = "PantallaAdmin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox AdmTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClienteBtn;
        private System.Windows.Forms.Button EstadisticoBtn;
        private System.Windows.Forms.Button ProveedorBtn;
        private System.Windows.Forms.Button FacturarBtn;
        private System.Windows.Forms.Button RolBtn;
        private System.Windows.Forms.Button CreditoBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}