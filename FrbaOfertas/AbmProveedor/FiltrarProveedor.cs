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
    public partial class FiltrarProveedor : Form
    {
        public FiltrarProveedor()
        {
            InitializeComponent();
            cargarDatos();
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        
        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarDatos()
        {
            String cadena;
            cadena = "SELECT p.Provee_RS RazónSocial, p.Provee_CUIT CUIT, p.Provee_Mail Email ";
            cadena += "FROM LOS_BORBOTONES.Proveedor p JOIN LOS_BORBOTONES.Usuario u ON (p.User_name = u.User_name) ";
            cadena += "WHERE u.Habilitado = 1 ";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            ProveeDGV.DataSource = dataSet.Tables[0];
        }

        private void BusquedaTB_TextChanged(object sender, EventArgs e)
        {
            if (BusquedaTB.Text != "")
            {
                ProveeDGV.CurrentCell = null;
                //oculta las filas
                foreach (DataGridViewRow r in ProveeDGV.Rows)
                {
                    r.Visible = false;
                }
                //muestra la busqueda
                foreach (DataGridViewRow r in ProveeDGV.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(BusquedaTB.Text.ToUpper()) == 0)
                        {
                            ProveeDGV.ClearSelection();
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                cargarDatos();
            }
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {

            String cuit = ProveeDGV.CurrentRow.Cells[1].Value.ToString();
            SqlCommand comandoEliminar = new SqlCommand("UPDATE LOS_BORBOTONES.Usuario SET Habilitado = 0 WHERE User_name = @cuit", conexion);
            comandoEliminar.Parameters.AddWithValue("@cuit", cuit);
            conexion.Open();
            int cant;
            cant = comandoEliminar.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se eliminó exitosamente al proveedor...");

            }
            conexion.Close();
            ProveeDGV.Refresh();
            ProveeDGV.Parent.Refresh();
            cargarDatos();
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            String proveedor = ProveeDGV.CurrentRow.Cells[1].Value.ToString();
            AbmProveedor.ModificarProveedor modificar = new ModificarProveedor(proveedor);
            modificar.ShowDialog();
        }
    }
}
