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
    public partial class RestaurarProveedor : Form
    {
        public RestaurarProveedor()
        {
            InitializeComponent();
            seleccionar(ProvBorradoCB);
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");

        public void seleccionar(ComboBox combo)
        {
            combo.Items.Clear();
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT u.User_name FROM LOS_BORBOTONES.Usuario u JOIN LOS_BORBOTONES.Proveedor p ON (u.User_name = p.User_name) where u.Habilitado = 0", conexion);
            SqlDataReader data = comando.ExecuteReader();
            while (data.Read())
            {
                combo.Items.Add(data[0].ToString());
            }
            conexion.Close();
            combo.Items.Insert(0, "Elegir usuario...");
            combo.SelectedIndex = 0;
        }

        public String[] captar(String unNombre)
        {
            conexion.Open();
            SqlCommand comando2 = new SqlCommand("SELECT p.Provee_RS FROM LOS_BORBOTONES.Usuario u JOIN LOS_BORBOTONES.Proveedor p ON (u.User_name = p.User_name) where u.User_name = @nombre", conexion);
            comando2.Parameters.AddWithValue("@nombre", unNombre);
            SqlDataReader data2 = comando2.ExecuteReader();
            String[] resultado = null;
            while (data2.Read())
            {
                String[] valores = {
                data2[0].ToString()
                };
                resultado = valores;
            }
            conexion.Close();
            return resultado;
        }

        private void ProvBorradoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProvBorradoCB.SelectedIndex > 0)
            {
                String[] valor = captar(ProvBorradoCB.Text);
                RaSoTB.Text = valor[0];

            }

        }

        public void habilitar(String unUsuario)
        {
            conexion.Open();
            SqlCommand comando3 = new SqlCommand("UPDATE LOS_BORBOTONES.Usuario SET Habilitado = 1 WHERE User_name = @usuario", conexion);
            comando3.Parameters.AddWithValue("@usuario", unUsuario);
            int cant;
            cant = comando3.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("El usuario ha sido habilitado...");


            }
            conexion.Close();
            seleccionar(ProvBorradoCB);
            RaSoTB.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            habilitar(ProvBorradoCB.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
