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

namespace FrbaOfertas.AbmProveedor
{
    public partial class NuevoProveedor : Form
    {
        public NuevoProveedor()
        {
            InitializeComponent();
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        
        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            RaSoTB.Text = String.Empty;
            CuitTB.Text = String.Empty;
            MailTB.Text = String.Empty;
            TelefonoTB.Text = String.Empty;
            DirTB.Text = String.Empty;
            CodPosTB.Text = String.Empty;
            CiudadTB.Text = String.Empty;
            RubroTB.Text = String.Empty;
            NomConTB.Text = String.Empty;
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void generarRolUsuario(String usuario)
        {

            String cadena = "INSERT INTO Los_Borbotones.Rol_Usuario ";
            cadena += "(User_name, Rol_Id) ";
            cadena += "VALUES ";
            cadena += "(@usuario, 3)";
            SqlCommand comandoNuevo = new SqlCommand(cadena, conexion);
            comandoNuevo.Parameters.AddWithValue("@usuario", usuario);
            int cant;
            cant = comandoNuevo.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se registró correctamente, su usuario y contraseña es su CUIT...");

            }
        }

        public void generarUsuario(String usuario) {
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
            conexion.Open();
            String cadena = "INSERT INTO LOS_BORBOTONES.Proveedor ";
            cadena += "(Provee_RS, Provee_Dom, Provee_Ciudad, Provee_Telefono, Provee_CUIT, Provee_Rubro, Provee_Mail, Provee_Cod_postal, Provee_Nombre_Contacto, User_name) ";
            cadena += "VALUES ";
            cadena += "(@rs, @dir, @ciudad, @telefono, @cuit, @rubro, @mail, @codPost, @nombre, @cuit)";
            SqlCommand comandoNuevo = new SqlCommand(cadena, conexion);
            comandoNuevo.Parameters.AddWithValue("@rs", RaSoTB.Text);
            comandoNuevo.Parameters.AddWithValue("@dir", DirTB.Text);
            comandoNuevo.Parameters.AddWithValue("@ciudad", CiudadTB.Text);
            comandoNuevo.Parameters.AddWithValue("@telefono", TelefonoTB.Text);
            comandoNuevo.Parameters.AddWithValue("@cuit", CuitTB.Text);
            comandoNuevo.Parameters.AddWithValue("@rubro", RubroTB.Text);
            comandoNuevo.Parameters.AddWithValue("@mail", MailTB.Text);
            comandoNuevo.Parameters.AddWithValue("@codPost", CodPosTB.Text);
            comandoNuevo.Parameters.AddWithValue("@nombre", NomConTB.Text);
            int cant;
            cant = comandoNuevo.ExecuteNonQuery();
            if (cant == 1)
            {
                generarUsuario(CuitTB.Text);
            }
            else
            {
                MessageBox.Show("El Proveedor ya se encuentra registrado, intente nuevamente...");
            }
            conexion.Close();
        }

        private void RaSoTB_Validated(object sender, EventArgs e)
        {
            if (RaSoTB.Text.Trim() == "")
            {
                ProveedorEP.SetError(RaSoTB, "Ingrese la Razón social...");
                RaSoTB.Focus();
            }
        }

        private void CuitTB_Validated(object sender, EventArgs e)
        {
            if (CuitTB.Text.Trim() == "")
            {
                ProveedorEP.SetError(CuitTB, "Ingrese el CUIT...");
                CuitTB.Focus();
            }
        }
    }
}
