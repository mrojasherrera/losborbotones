namespace FrbaOfertas.Facturar
{
    partial class FacturarProv
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BuscarProvTB = new System.Windows.Forms.TextBox();
            this.DesdeDTP = new System.Windows.Forms.DateTimePicker();
            this.HastaDTP = new System.Windows.Forms.DateTimePicker();
            this.ProvDGV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FacturarBtn = new System.Windows.Forms.Button();
            this.VolverBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProvDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HastaDTP);
            this.groupBox1.Controls.Add(this.DesdeDTP);
            this.groupBox1.Controls.Add(this.BuscarProvTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Facturar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROVEEDOR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "FECHA DESDE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA HASTA:";
            // 
            // BuscarProvTB
            // 
            this.BuscarProvTB.Location = new System.Drawing.Point(175, 27);
            this.BuscarProvTB.Name = "BuscarProvTB";
            this.BuscarProvTB.Size = new System.Drawing.Size(205, 20);
            this.BuscarProvTB.TabIndex = 0;
            this.BuscarProvTB.TextChanged += new System.EventHandler(this.BuscarProvTB_TextChanged);
            // 
            // DesdeDTP
            // 
            this.DesdeDTP.Location = new System.Drawing.Point(175, 58);
            this.DesdeDTP.Name = "DesdeDTP";
            this.DesdeDTP.Size = new System.Drawing.Size(200, 20);
            this.DesdeDTP.TabIndex = 1;
            // 
            // HastaDTP
            // 
            this.HastaDTP.Location = new System.Drawing.Point(175, 90);
            this.HastaDTP.Name = "HastaDTP";
            this.HastaDTP.Size = new System.Drawing.Size(200, 20);
            this.HastaDTP.TabIndex = 2;
            // 
            // ProvDGV
            // 
            this.ProvDGV.AllowUserToAddRows = false;
            this.ProvDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ProvDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProvDGV.Location = new System.Drawing.Point(13, 153);
            this.ProvDGV.Name = "ProvDGV";
            this.ProvDGV.Size = new System.Drawing.Size(406, 313);
            this.ProvDGV.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaOfertas.Properties.Resources.fac;
            this.pictureBox1.Location = new System.Drawing.Point(426, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FacturarBtn
            // 
            this.FacturarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacturarBtn.Location = new System.Drawing.Point(485, 263);
            this.FacturarBtn.Name = "FacturarBtn";
            this.FacturarBtn.Size = new System.Drawing.Size(112, 40);
            this.FacturarBtn.TabIndex = 4;
            this.FacturarBtn.Text = "Facturar";
            this.FacturarBtn.UseVisualStyleBackColor = true;
            this.FacturarBtn.Click += new System.EventHandler(this.FacturarBtn_Click);
            // 
            // VolverBtn
            // 
            this.VolverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverBtn.Location = new System.Drawing.Point(485, 359);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(112, 40);
            this.VolverBtn.TabIndex = 5;
            this.VolverBtn.Text = "Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // FacturarProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 478);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.FacturarBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProvDGV);
            this.Controls.Add(this.groupBox1);
            this.Name = "FacturarProv";
            this.Text = "Facturar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProvDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker HastaDTP;
        private System.Windows.Forms.DateTimePicker DesdeDTP;
        private System.Windows.Forms.TextBox BuscarProvTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProvDGV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button FacturarBtn;
        private System.Windows.Forms.Button VolverBtn;
    }
}