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
    public partial class ModificarProveedor : Form
    {
        public ModificarProveedor(String usuario)
        {
            InitializeComponent();
            buscarProvvedor(usuario);
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        
        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbmProveedor.FiltrarProveedor filtrar = new FiltrarProveedor();
            filtrar.ShowDialog();
        }
        public void buscarProvvedor(String usuario) {
            conexion.Open();
            String cadena = "SELECT Provee_RS, Provee_Dom, Provee_Ciudad, Provee_Telefono, Provee_CUIT, Provee_Rubro, Provee_Mail, Provee_Cod_postal, Provee_Nombre_Contacto ";
            cadena += "FROM LOS_BORBOTONES.Proveedor ";
            cadena += "WHERE Provee_CUIT = @usuario";
            SqlCommand comandoBuscar = new SqlCommand(cadena, conexion);
            comandoBuscar.Parameters.AddWithValue("@usuario", usuario);
            SqlDataAdapter dataBuscar = new SqlDataAdapter(comandoBuscar);
            DataTable tablaBuscar = new DataTable();
            dataBuscar.Fill(tablaBuscar);
            if (tablaBuscar.Rows.Count == 1)
            {
                RSTB.Text = tablaBuscar.Rows[0][0].ToString();
                DirTB.Text = tablaBuscar.Rows[0][1].ToString();
                CiudadTB.Text = tablaBuscar.Rows[0][2].ToString();
                TelfTB.Text = tablaBuscar.Rows[0][3].ToString();
                CuitTB.Text = usuario;
                RubroTB.Text = tablaBuscar.Rows[0][5].ToString();
                MailTB.Text = tablaBuscar.Rows[0][6].ToString();
                CodPostTB.Text = tablaBuscar.Rows[0][7].ToString();
                NombreTB.Text = tablaBuscar.Rows[0][8].ToString();
            
            
            }
            conexion.Close();
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            conexion.Open();

            String cadena = "UPDATE LOS_BORBOTONES.Proveedor ";
            cadena += "SET Provee_RS = @rs, ";
            cadena += "Provee_Dom = @dir, ";
            cadena += "Provee_Ciudad = @ciudad, ";
            cadena += "Provee_Telefono = @telefono, ";
            cadena += "Provee_CUIT = @cuit, ";
            cadena += "Provee_Rubro = @rubro,  ";
            cadena += "Provee_Mail = @mail, ";
            cadena += "Provee_Cod_postal = @codPost, ";
            cadena += "Provee_Nombre_Contacto = @nombre";
            cadena += "WHERE Provee_CUIT = @cuit";

            SqlCommand comandoMod = new SqlCommand(cadena, conexion);
            comandoMod.Parameters.AddWithValue("@rs", RSTB.Text);
            comandoMod.Parameters.AddWithValue("@dir", DirTB.Text);
            comandoMod.Parameters.AddWithValue("@ciudad", CiudadTB.Text);
            comandoMod.Parameters.AddWithValue("@telefono", TelfTB.Text);
            comandoMod.Parameters.AddWithValue("@cuit", CuitTB.Text);
            comandoMod.Parameters.AddWithValue("@rubro", RubroTB.Text);
            comandoMod.Parameters.AddWithValue("@mail", MailTB.Text);
            comandoMod.Parameters.AddWithValue("@codPost", CodPostTB.Text);
            comandoMod.Parameters.AddWithValue("@nombre", NombreTB.Text);
            int cant;
            cant = comandoMod.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se actualizo correctamente el proveedor...");

            }
            conexion.Close();
        }
    }
}
