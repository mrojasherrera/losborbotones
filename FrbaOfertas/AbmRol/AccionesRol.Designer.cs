namespace FrbaOfertas.AbmRol
{
    partial class AccionesRol
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
            this.FiltrarRolBtn = new System.Windows.Forms.Button();
            this.NuevoRolBtn = new System.Windows.Forms.Button();
            this.SalirBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RestaurarBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RestaurarBtn);
            this.groupBox1.Controls.Add(this.FiltrarRolBtn);
            this.groupBox1.Controls.Add(this.NuevoRolBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // FiltrarRolBtn
            // 
            this.FiltrarRolBtn.Location = new System.Drawing.Point(100, 123);
            this.FiltrarRolBtn.Name = "FiltrarRolBtn";
            this.FiltrarRolBtn.Size = new System.Drawing.Size(123, 44);
            this.FiltrarRolBtn.TabIndex = 1;
            this.FiltrarRolBtn.Text = "Filtrar Rol";
            this.FiltrarRolBtn.UseVisualStyleBackColor = true;
            this.FiltrarRolBtn.Click += new System.EventHandler(this.FiltrarRolBtn_Click);
            // 
            // NuevoRolBtn
            // 
            this.NuevoRolBtn.Location = new System.Drawing.Point(100, 45);
            this.NuevoRolBtn.Name = "NuevoRolBtn";
            this.NuevoRolBtn.Size = new System.Drawing.Size(123, 44);
            this.NuevoRolBtn.TabIndex = 0;
            this.NuevoRolBtn.Text = "Nuevo Rol";
            this.NuevoRolBtn.UseVisualStyleBackColor = true;
            this.NuevoRolBtn.Click += new System.EventHandler(this.NuevoRolBtn_Click);
            // 
            // SalirBtn
            // 
            this.SalirBtn.Location = new System.Drawing.Point(414, 265);
            this.SalirBtn.Name = "SalirBtn";
            this.SalirBtn.Size = new System.Drawing.Size(123, 50);
            this.SalirBtn.TabIndex = 1;
            this.SalirBtn.Text = "Salir";
            this.SalirBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaOfertas.Properties.Resources.icono_planificar_acciones_comerciales;
            this.pictureBox1.Location = new System.Drawing.Point(362, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // RestaurarBtn
            // 
            this.RestaurarBtn.Location = new System.Drawing.Point(100, 207);
            this.RestaurarBtn.Name = "RestaurarBtn";
            this.RestaurarBtn.Size = new System.Drawing.Size(123, 44);
            this.RestaurarBtn.TabIndex = 2;
            this.RestaurarBtn.Text = "Restaurar Rol";
            this.RestaurarBtn.UseVisualStyleBackColor = true;
            // 
            // AccionesRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 327);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SalirBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccionesRol";
            this.Text = "Acciones del rol";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button FiltrarRolBtn;
        private System.Windows.Forms.Button NuevoRolBtn;
        private System.Windows.Forms.Button SalirBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button RestaurarBtn;
    }
}