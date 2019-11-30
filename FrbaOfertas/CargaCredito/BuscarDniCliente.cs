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

namespace FrbaOfertas.CargaCredito
{
    public partial class BuscarDniCliente : Form
    {
        public BuscarDniCliente()
        {
            InitializeComponent();
            CargarDatosDni();
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");

        public void CargarDatosDni()
        {
            String cadena;
            cadena = "SELECT c.Cli_Nombre Cliente, c.Cli_Apellido Apellido, c.Cli_Dni Dni, c.Cli_Mail Email ";
            cadena += "FROM LOS_BORBOTONES.Cliente c JOIN LOS_BORBOTONES.Usuario u ON (c.User_name = u.User_name) ";
            cadena += "WHERE u.Habilitado = 1 ";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            ClienteDniDGV.DataSource = dataSet.Tables[0];
        }




    }
}
