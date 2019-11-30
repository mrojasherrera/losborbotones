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
    public partial class ModificarCliente : Form
    {
        public ModificarCliente(int usuario)
        {
            InitializeComponent();
            buscarClienteBD(usuario);
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        
        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbmCliente.BuscarCliente buscar = new BuscarCliente();
            buscar.ShowDialog();
        }
        public void buscarClienteBD(int dniCli) {

            conexion.Open();
            string cadena;
            cadena = "select Cli_Nombre, Cli_Apellido, Cli_Mail, Cli_Telefono, Cli_Direccion, Cli_Ciudad, Cli_CodigoPostal, Cli_Fecha_Nac ";
            cadena += "from LOS_BORBOTONES.Cliente where Cli_Dni = @dni";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.Parameters.AddWithValue("@dni", dniCli);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            if (tabla.Rows.Count == 1)
            { 
                NombreTB.Text = tabla.Rows[0][0].ToString();
                ApellidoTB.Text = tabla.Rows[0][1].ToString();
                DniTB.Text = dniCli.ToString();
                MailTB.Text = tabla.Rows[0][2].ToString();
                TelefonoTB.Text = tabla.Rows[0][3].ToString();
                DireccionTB.Text = tabla.Rows[0][4].ToString();
                CiudadTB.Text = tabla.Rows[0][5].ToString();
                CodPostTB.Text = tabla.Rows[0][6].ToString();
                FechNacTB.Text = tabla.Rows[0][7].ToString();
            
            }
            conexion.Close();
                  

        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string cadena;
            cadena = "UPDATE LOS_BORBOTONES.Cliente ";
            cadena += "SET Cli_Nombre = @nombre, ";
            cadena += "Cli_Apellido = @apellido, ";
            cadena += "Cli_Dni = @dni, ";
            cadena += "Cli_Mail = @mail, ";
            cadena += "Cli_Telefono = @telefono, ";
            cadena += "Cli_Direccion = @direccion, ";
            cadena += "Cli_Ciudad = @ciudad, ";
            cadena += "Cli_CodigoPostal = @codPost, ";
            cadena += "Cli_Fecha_Nac = @fecha ";
            cadena += "WHERE Cli_Dni = @dni";

            SqlCommand comando2 = new SqlCommand(cadena, conexion);
            comando2.Parameters.AddWithValue("@nombre", NombreTB.Text);
            comando2.Parameters.AddWithValue("@apellido", ApellidoTB.Text);
            comando2.Parameters.AddWithValue("@dni", Convert.ToInt32(DniTB.Text));
            comando2.Parameters.AddWithValue("@mail", MailTB.Text);
            comando2.Parameters.AddWithValue("@telefono",TelefonoTB.Text);
            comando2.Parameters.AddWithValue("@direccion", DireccionTB.Text);
            comando2.Parameters.AddWithValue("@ciudad", CiudadTB.Text);
            comando2.Parameters.AddWithValue("@codPost", CodPostTB.Text);
            comando2.Parameters.AddWithValue("@fecha", FechNacTB.Text);

            int cant;
            cant = comando2.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se actualizo correctamente el cliente...");

            }
            conexion.Close();
            
        }

    }
}
