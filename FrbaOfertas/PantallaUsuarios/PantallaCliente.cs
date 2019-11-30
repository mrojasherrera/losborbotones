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

namespace FrbaOfertas.PantallaUsuarios
{
    public partial class PantallaCliente : Form
    {
        public PantallaCliente(String unCliente)
        {
            InitializeComponent();
            UsuarioTB.Text = unCliente;
            usuario();
        }
        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        public void usuario()
        {
            conexion.Open();
            String cliente = UsuarioTB.Text.ToString();
            SqlCommand comando = new SqlCommand("select c.Cli_Nombre, c.Cli_Apellido from LOS_BORBOTONES.Usuario u join LOS_BORBOTONES.Cliente c on(u.User_name = c.User_name) where u.User_name = @cliente", conexion);
            comando.Parameters.AddWithValue("cliente", cliente);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            NombreTB.Text = tabla.Rows[0][0].ToString();
            ApellidoTB.Text = tabla.Rows[0][1].ToString();
        }

        private void ComprarBtn_Click(object sender, EventArgs e)
        {

            ComprarOferta.Ofertas comprar = new ComprarOferta.Ofertas(UsuarioTB.Text.ToString());
            comprar.ShowDialog();
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FrbaOfertas.Login login = new FrbaOfertas.Login();
            login.Show();
        }
    }
}
