namespace FrbaOfertas.ComprarOferta
{
    partial class Ofertas
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
            this.VolverBtn = new System.Windows.Forms.Button();
            this.ComprarBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BuscarTB = new System.Windows.Forms.TextBox();
            this.CantNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DisponibleTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UsuarioTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OfertaDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantNUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfertaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // VolverBtn
            // 
            this.VolverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverBtn.Location = new System.Drawing.Point(1017, 116);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(127, 52);
            this.VolverBtn.TabIndex = 10;
            this.VolverBtn.Text = "Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // ComprarBtn
            // 
            this.ComprarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprarBtn.Location = new System.Drawing.Point(1017, 33);
            this.ComprarBtn.Name = "ComprarBtn";
            this.ComprarBtn.Size = new System.Drawing.Size(127, 52);
            this.ComprarBtn.TabIndex = 9;
            this.ComprarBtn.Text = "Comprar Oferta";
            this.ComprarBtn.UseVisualStyleBackColor = true;
            this.ComprarBtn.Click += new System.EventHandler(this.ComprarBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaOfertas.Properties.Resources._185_1850575_las_compras_en_linea_venta_graphic_icono_online_png;
            this.pictureBox1.Location = new System.Drawing.Point(725, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BuscarTB);
            this.groupBox2.Controls.Add(this.CantNUD);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 86);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oferta";
            // 
            // BuscarTB
            // 
            this.BuscarTB.Location = new System.Drawing.Point(289, 19);
            this.BuscarTB.Name = "BuscarTB";
            this.BuscarTB.Size = new System.Drawing.Size(412, 20);
            this.BuscarTB.TabIndex = 3;
            this.BuscarTB.TextChanged += new System.EventHandler(this.BuscarTB_TextChanged);
            // 
            // CantNUD
            // 
            this.CantNUD.Location = new System.Drawing.Point(289, 56);
            this.CantNUD.Name = "CantNUD";
            this.CantNUD.Size = new System.Drawing.Size(120, 20);
            this.CantNUD.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "CANTIDAD A COMPRAR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "BUSCAR OFERTA:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DisponibleTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.UsuarioTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 73);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // DisponibleTB
            // 
            this.DisponibleTB.Enabled = false;
            this.DisponibleTB.Location = new System.Drawing.Point(526, 28);
            this.DisponibleTB.Name = "DisponibleTB";
            this.DisponibleTB.Size = new System.Drawing.Size(175, 20);
            this.DisponibleTB.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(315, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "CRÉDITO DISPONIBLE:";
            // 
            // UsuarioTB
            // 
            this.UsuarioTB.Enabled = false;
            this.UsuarioTB.Location = new System.Drawing.Point(108, 28);
            this.UsuarioTB.Name = "UsuarioTB";
            this.UsuarioTB.Size = new System.Drawing.Size(175, 20);
            this.UsuarioTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "USUARIO:";
            // 
            // OfertaDGV
            // 
            this.OfertaDGV.AllowUserToAddRows = false;
            this.OfertaDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.OfertaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OfertaDGV.Location = new System.Drawing.Point(13, 184);
            this.OfertaDGV.Name = "OfertaDGV";
            this.OfertaDGV.Size = new System.Drawing.Size(1148, 315);
            this.OfertaDGV.TabIndex = 12;
            // 
            // Ofertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 511);
            this.Controls.Add(this.OfertaDGV);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.ComprarBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ofertas";
            this.Text = "Ofertas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantNUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OfertaDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button VolverBtn;
        private System.Windows.Forms.Button ComprarBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox BuscarTB;
        private System.Windows.Forms.NumericUpDown CantNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox DisponibleTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsuarioTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView OfertaDGV;
    }
}