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

namespace FrbaOfertas.Facturar
{
    public partial class FacturarProv : Form
    {
        public FacturarProv()
        {
            InitializeComponent();
            cargarDatos();
        }
        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");
        
        public void cargarDatos()
        {
            String cadena;
            cadena = "SELECT p.Provee_RS 'Razón Social', p.Provee_CUIT CUIT, p.Provee_Mail Email ";
            cadena += "FROM LOS_BORBOTONES.Proveedor p JOIN LOS_BORBOTONES.Usuario u ON (p.User_name = u.User_name) ";
            cadena += "WHERE u.Habilitado = 1 ";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            ProvDGV.DataSource = dataSet.Tables[0];
        }

        
        private void BuscarProvTB_TextChanged(object sender, EventArgs e)
        {
            if (BuscarProvTB.Text != "")
            {
                ProvDGV.CurrentCell = null;
                //oculta las filas
                foreach (DataGridViewRow r in ProvDGV.Rows)
                {
                    r.Visible = false;
                }
                //muestra la busqueda
                foreach (DataGridViewRow r in ProvDGV.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(BuscarProvTB.Text.ToUpper()) == 0)
                        {
                            ProvDGV.ClearSelection();
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

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FacturarBtn_Click(object sender, EventArgs e)
        {
            String dni = ProvDGV.CurrentRow.Cells[1].Value.ToString();
            DateTime desde = DesdeDTP.Value;
            DateTime hasta = HastaDTP.Value;
            Facturar.EmitirFac emitir = new Facturar.EmitirFac(dni, desde, hasta);
            emitir.ShowDialog();

        }
    }
}
