using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaOfertas.AbmCliente
{
    public partial class NuevoCliente : Form
    {
        public NuevoCliente()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        
        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            NombreTB.Text = String.Empty;
            ApellidoTB.Text = String.Empty;
            DniTB.Text = String.Empty;
            MailTB.Text = String.Empty;
            TelefonoTB.Text = String.Empty;
            DireccionTB.Text = String.Empty;
            CiudadTB.Text = String.Empty;
            CodPostTB.Text = String.Empty;
            //FechNacTB.Text = String.Empty;
        }

        public void generarRolUsuario(String usuario) {

            String cadena = "INSERT INTO Los_Borbotones.Rol_Usuario ";
            cadena += "(User_name, Rol_Id) ";
            cadena += "VALUES ";
            cadena += "(@usuario, 2)";
            SqlCommand comandoNuevo = new SqlCommand(cadena, conexion);
            comandoNuevo.Parameters.AddWithValue("@usuario", usuario);
            int cant;
            cant = comandoNuevo.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se registró correctamente, su usuario y contraseña es su DNI...");

            }
        }

        public void generarUsuario(string usuario) {
            
            String cadena = "INSERT INTO LOS_BORBOTONES.Usuario ";
            cadena += "(User_name, Password) ";
            cadena += "VALUES ";
            cadena += "(@usuario, HASHBYTES('SHA2_256', CAST( (cast(@usuario as nvarchar(20))) AS varbinary(70))))";
            SqlCommand comandoNuevo = new SqlCommand(cadena, conexion);
            comandoNuevo.Parameters.AddWithValue("@usuario", usuario);
            int cant;
            cant = comandoNuevo.ExecuteNonQuery();
            if (cant == 1)
            {
                generarRolUsuario(usuario);
                
            }
        }

        private void NuevoBtn_Click(object sender, EventArgs e)
        {
            
            int dni = Convert.ToInt32(DniTB.Text);
            DateTime fecha = FechaNacDTP.Value;

            String cadena = "insert into LOS_BORBOTONES.Cliente ";
            cadena += "(Cli_Nombre, Cli_Apellido, Cli_Dni, Cli_Direccion, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac, Cli_Ciudad , Cli_CodigoPostal, User_name, Cli_Saldo) ";
            cadena += "values ";
            cadena += "(@nombre, @apellido, @dni, @direccion, @telefono, @mail, @fecha, @ciudad, @codPost, @usuario, 200) ";
            conexion.Open();
            SqlCommand comandoNuevo = new SqlCommand(cadena, conexion);
            comandoNuevo.Parameters.AddWithValue("@nombre", NombreTB.Text);
            comandoNuevo.Parameters.AddWithValue("@apellido", ApellidoTB.Text);
            comandoNuevo.Parameters.AddWithValue("@dni", dni);
            comandoNuevo.Parameters.AddWithValue("@direccion", DireccionTB.Text);
            comandoNuevo.Parameters.AddWithValue("@telefono", TelefonoTB.Text);
            comandoNuevo.Parameters.AddWithValue("@mail", MailTB.Text);
            comandoNuevo.Parameters.AddWithValue("@fecha", fecha);
            comandoNuevo.Parameters.AddWithValue("@ciudad", CiudadTB.Text);
            comandoNuevo.Parameters.AddWithValue("@codPost", CodPostTB.Text);
            comandoNuevo.Parameters.AddWithValue("@usuario", DniTB.Text);
            int cant;
            cant = comandoNuevo.ExecuteNonQuery();
            if (cant == 1)
            {
                generarUsuario(DniTB.Text);

            }
            else
            {
                MessageBox.Show("El cliente ya se encuentra registrado, intente nuevamente...");
            }
            conexion.Close();


            
        }

        private void DniTB_Validated(object sender, EventArgs e)
        {
            if (DniTB.Text.Trim() == "")
            {
                ClienteEP.SetError(DniTB, "Ingrese el Dni...");
                DniTB.Focus();
            }
        }
    }
}
