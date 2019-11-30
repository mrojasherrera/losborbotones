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
    public partial class PantallaProveedor : Form
    {
        public PantallaProveedor(String unProveedor)
        {
            InitializeComponent();
            ProveedorTB.Text = unProveedor;
            usuario();
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        
        public void usuario() 
        {
            conexion.Open();
            String proveedor = ProveedorTB.Text.ToString();
            SqlCommand comando = new SqlCommand("select Provee_RS from LOS_BORBOTONES.Usuario u join LOS_BORBOTONES.Proveedor p on (u.User_name = p.User_name) where u.User_name = @proveedor", conexion);
            comando.Parameters.AddWithValue("proveedor", proveedor);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            RsTB.Text = tabla.Rows[0][0].ToString();
        
        }

        private void OfertaBtn_Click(object sender, EventArgs e)
        {
            CrearOferta.NuevaOferta oferta = new CrearOferta.NuevaOferta();
            oferta.Show();
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FrbaOfertas.Login login = new FrbaOfertas.Login();
            login.Show();
        }

     
    }
}
