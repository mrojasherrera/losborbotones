namespace FrbaOfertas.AbmCliente
{
    partial class NuevoCliente
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.FechaNacDTP = new System.Windows.Forms.DateTimePicker();
            this.NuevoBtn = new System.Windows.Forms.Button();
            this.CiudadTB = new System.Windows.Forms.TextBox();
            this.Ciudad = new System.Windows.Forms.Label();
            this.FechNac = new System.Windows.Forms.Label();
            this.CodPost = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.Mail = new System.Windows.Forms.Label();
            this.Dni = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.CodPostTB = new System.Windows.Forms.TextBox();
            this.DireccionTB = new System.Windows.Forms.TextBox();
            this.TelefonoTB = new System.Windows.Forms.TextBox();
            this.MailTB = new System.Windows.Forms.TextBox();
            this.DniTB = new System.Windows.Forms.TextBox();
            this.ApellidoTB = new System.Windows.Forms.TextBox();
            this.NombreTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VolverBtn = new System.Windows.Forms.Button();
            this.ClienteEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteEP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LimpiarBtn);
            this.groupBox1.Controls.Add(this.FechaNacDTP);
            this.groupBox1.Controls.Add(this.NuevoBtn);
            this.groupBox1.Controls.Add(this.CiudadTB);
            this.groupBox1.Controls.Add(this.Ciudad);
            this.groupBox1.Controls.Add(this.FechNac);
            this.groupBox1.Controls.Add(this.CodPost);
            this.groupBox1.Controls.Add(this.Direccion);
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.Mail);
            this.groupBox1.Controls.Add(this.Dni);
            this.groupBox1.Controls.Add(this.Apellido);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.CodPostTB);
            this.groupBox1.Controls.Add(this.DireccionTB);
            this.groupBox1.Controls.Add(this.TelefonoTB);
            this.groupBox1.Controls.Add(this.MailTB);
            this.groupBox1.Controls.Add(this.DniTB);
            this.groupBox1.Controls.Add(this.ApellidoTB);
            this.groupBox1.Controls.Add(this.NombreTB);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "(*) Campo requerido";
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.Location = new System.Drawing.Point(302, 365);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(106, 47);
            this.LimpiarBtn.TabIndex = 10;
            this.LimpiarBtn.Text = "Limpiar";
            this.LimpiarBtn.UseVisualStyleBackColor = true;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // FechaNacDTP
            // 
            this.FechaNacDTP.Location = new System.Drawing.Point(285, 324);
            this.FechaNacDTP.Name = "FechaNacDTP";
            this.FechaNacDTP.Size = new System.Drawing.Size(259, 20);
            this.FechaNacDTP.TabIndex = 8;
            // 
            // NuevoBtn
            // 
            this.NuevoBtn.Location = new System.Drawing.Point(171, 363);
            this.NuevoBtn.Name = "NuevoBtn";
            this.NuevoBtn.Size = new System.Drawing.Size(106, 49);
            this.NuevoBtn.TabIndex = 9;
            this.NuevoBtn.Text = "Nuevo";
            this.NuevoBtn.UseVisualStyleBackColor = true;
            this.NuevoBtn.Click += new System.EventHandler(this.NuevoBtn_Click);
            // 
            // CiudadTB
            // 
            this.CiudadTB.Location = new System.Drawing.Point(285, 263);
            this.CiudadTB.Name = "CiudadTB";
            this.CiudadTB.Size = new System.Drawing.Size(259, 20);
            this.CiudadTB.TabIndex = 6;
            // 
            // Ciudad
            // 
            this.Ciudad.AutoSize = true;
            this.Ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ciudad.Location = new System.Drawing.Point(29, 263);
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.Size = new System.Drawing.Size(83, 20);
            this.Ciudad.TabIndex = 37;
            this.Ciudad.Text = "CIUDAD:";
            // 
            // FechNac
            // 
            this.FechNac.AutoSize = true;
            this.FechNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechNac.Location = new System.Drawing.Point(29, 325);
            this.FechNac.Name = "FechNac";
            this.FechNac.Size = new System.Drawing.Size(218, 20);
            this.FechNac.TabIndex = 36;
            this.FechNac.Text = "FECHA DE NACIMIENTO:";
            // 
            // CodPost
            // 
            this.CodPost.AutoSize = true;
            this.CodPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodPost.Location = new System.Drawing.Point(29, 292);
            this.CodPost.Name = "CodPost";
            this.CodPost.Size = new System.Drawing.Size(158, 20);
            this.CodPost.TabIndex = 35;
            this.CodPost.Text = "CÓDIGO POSTAL:";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(29, 230);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(113, 20);
            this.Direccion.TabIndex = 34;
            this.Direccion.Text = "DIRECCION:";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(29, 199);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(107, 20);
            this.Telefono.TabIndex = 33;
            this.Telefono.Text = "TELÉFONO:";
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail.Location = new System.Drawing.Point(29, 161);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(56, 20);
            this.Mail.TabIndex = 32;
            this.Mail.Text = "MAIL:";
            // 
            // Dni
            // 
            this.Dni.AutoSize = true;
            this.Dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dni.Location = new System.Drawing.Point(29, 125);
            this.Dni.Name = "Dni";
            this.Dni.Size = new System.Drawing.Size(57, 20);
            this.Dni.TabIndex = 31;
            this.Dni.Text = "DNI: *";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.Location = new System.Drawing.Point(29, 91);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(101, 20);
            this.Apellido.TabIndex = 30;
            this.Apellido.Text = "APELLIDO:";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(29, 54);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(90, 20);
            this.Nombre.TabIndex = 29;
            this.Nombre.Text = "NOMBRE:";
            // 
            // CodPostTB
            // 
            this.CodPostTB.Location = new System.Drawing.Point(285, 294);
            this.CodPostTB.Name = "CodPostTB";
            this.CodPostTB.Size = new System.Drawing.Size(259, 20);
            this.CodPostTB.TabIndex = 7;
            // 
            // DireccionTB
            // 
            this.DireccionTB.Location = new System.Drawing.Point(285, 230);
            this.DireccionTB.Name = "DireccionTB";
            this.DireccionTB.Size = new System.Drawing.Size(259, 20);
            this.DireccionTB.TabIndex = 5;
            // 
            // TelefonoTB
            // 
            this.TelefonoTB.Location = new System.Drawing.Point(285, 199);
            this.TelefonoTB.Name = "TelefonoTB";
            this.TelefonoTB.Size = new System.Drawing.Size(259, 20);
            this.TelefonoTB.TabIndex = 4;
            // 
            // MailTB
            // 
            this.MailTB.Location = new System.Drawing.Point(285, 161);
            this.MailTB.Name = "MailTB";
            this.MailTB.Size = new System.Drawing.Size(259, 20);
            this.MailTB.TabIndex = 3;
            // 
            // DniTB
            // 
            this.DniTB.Location = new System.Drawing.Point(285, 125);
            this.DniTB.Name = "DniTB";
            this.DniTB.Size = new System.Drawing.Size(259, 20);
            this.DniTB.TabIndex = 2;
            this.DniTB.Validated += new System.EventHandler(this.DniTB_Validated);
            // 
            // ApellidoTB
            // 
            this.ApellidoTB.Location = new System.Drawing.Point(285, 91);
            this.ApellidoTB.Name = "ApellidoTB";
            this.ApellidoTB.Size = new System.Drawing.Size(259, 20);
            this.ApellidoTB.TabIndex = 1;
            // 
            // NombreTB
            // 
            this.NombreTB.Location = new System.Drawing.Point(285, 54);
            this.NombreTB.Name = "NombreTB";
            this.NombreTB.Size = new System.Drawing.Size(259, 20);
            this.NombreTB.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrbaOfertas.Properties.Resources.add;
            this.pictureBox1.Location = new System.Drawing.Point(596, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // VolverBtn
            // 
            this.VolverBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.VolverBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolverBtn.Location = new System.Drawing.Point(684, 310);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(106, 49);
            this.VolverBtn.TabIndex = 11;
            this.VolverBtn.Text = "Volver";
            this.VolverBtn.UseVisualStyleBackColor = false;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // ClienteEP
            // 
            this.ClienteEP.ContainerControl = this;
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 451);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevoCliente";
            this.Text = "NuevoCliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteEP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CiudadTB;
        private System.Windows.Forms.Label Ciudad;
        private System.Windows.Forms.Label FechNac;
        private System.Windows.Forms.Label CodPost;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label Dni;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox CodPostTB;
        private System.Windows.Forms.TextBox DireccionTB;
        private System.Windows.Forms.TextBox TelefonoTB;
        private System.Windows.Forms.TextBox MailTB;
        private System.Windows.Forms.TextBox DniTB;
        private System.Windows.Forms.TextBox ApellidoTB;
        private System.Windows.Forms.TextBox NombreTB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button VolverBtn;
        private System.Windows.Forms.Button NuevoBtn;
        private System.Windows.Forms.Button LimpiarBtn;
        private System.Windows.Forms.DateTimePicker FechaNacDTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ClienteEP;
    }
}