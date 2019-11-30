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

namespace FrbaOfertas.ComprarOferta
{
    public partial class Ofertas : Form
    {
        public Ofertas(String usuario)
        {
            InitializeComponent();
            UsuarioTB.Text = usuario;
            saldo(usuario);
            cargarDatos();
        }

        SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");

        public void saldo(String unCliente)
        {
            conexion.Open();
            string cadena = "SELECT Cli_Saldo FROM LOS_BORBOTONES.Cliente WHERE Cli_Dni = @cliente ";
            SqlCommand comandoSaldo = new SqlCommand(cadena, conexion);
            comandoSaldo.Parameters.AddWithValue("@cliente", unCliente);
            SqlDataAdapter data = new SqlDataAdapter(comandoSaldo);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            DisponibleTB.Text = tabla.Rows[0][0].ToString();

            conexion.Close();
        }

        public void cargarDatos()
        {
            conexion.Open();
            String cadena;
            cadena = "SELECT o.Oferta_Descripcion Descripción, o.Oferta_Codigo Código,  p.Provee_RS 'Razón Social', ";
            cadena += "o.Oferta_Precio_Ficticio 'Precio Lista', o.Oferta_Precio 'Precio Oferta', o.Oferta_Cantidad Disponible, ";
            cadena += "o.Oferta_Cantidad_Compra 'Límite por Cliente'";
            cadena += "FROM LOS_BORBOTONES.Oferta o JOIN LOS_BORBOTONES.Proveedor p ON (o.Provee_CUIT = p.Provee_CUIT) ";
            cadena += "WHERE o.Oferta_Cantidad > 0 ";
            cadena += "ORDER BY 1 ";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataSet dataSet = new DataSet();
            data.Fill(dataSet);
            OfertaDGV.DataSource = dataSet.Tables[0];
            conexion.Close();
        }

        private void BuscarTB_TextChanged(object sender, EventArgs e)
        {
            if (BuscarTB.Text != "")
            {
                OfertaDGV.CurrentCell = null;
                //oculta las filas
                foreach (DataGridViewRow r in OfertaDGV.Rows)
                {
                    r.Visible = false;
                }
                //muestra la busqueda
                foreach (DataGridViewRow r in OfertaDGV.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(BuscarTB.Text.ToUpper()) == 0)
                        {
                            OfertaDGV.ClearSelection();
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

        public int cantComprada(string cliente, String oferta) {
            int cant = 0;
            String cadena = "SELECT COUNT(Oferta_Codigo) FROM LOS_BORBOTONES.Cupon WHERE Cli_Dni = @cliente and Oferta_Codigo = @oferta";
            SqlCommand comandoCant = new SqlCommand(cadena, conexion);
            comandoCant.Parameters.AddWithValue("@cliente", cliente);
            comandoCant.Parameters.AddWithValue("@oferta", oferta);
            SqlDataAdapter dataCant = new SqlDataAdapter(comandoCant);
            DataTable tablaCant = new DataTable();
            dataCant.Fill(tablaCant);
            cant = Convert.ToInt32(tablaCant.Rows[0][0].ToString());
            return cant;

        }

        private void ComprarBtn_Click(object sender, EventArgs e)
        {
            conexion.Open();
            String oferta = OfertaDGV.CurrentRow.Cells[1].Value.ToString();
            int cantidad = Convert.ToInt32(CantNUD.Value);
            int permitido = Convert.ToInt32(OfertaDGV.CurrentRow.Cells[6].Value.ToString());
            int comprado = cantComprada(UsuarioTB.Text, oferta);
            
            //evaluar que lo comprado sea menor o igual a la cantidad permitida
            if (comprado < permitido)
            {
                int cantComprar = permitido - comprado; //cantidad que puedo comprar
                if (cantidad <= cantComprar)//evaluo que la cantidad a comprar sea menor o iguala lo que puedo comprar
                {
                    int precio = Convert.ToInt32(OfertaDGV.CurrentRow.Cells[4].Value.ToString());
                    int disponible = Convert.ToInt32(DisponibleTB.Text);
                    if (disponible >= precio){
                        String cadena = "INSERT INTO LOS_BORBOTONES.Cupon ";
                        cadena += "(Oferta_Codigo, Cli_Dni) "; //FALTARIA AGREGAR LAS FECHAS*****
                        cadena += "VALUES ";
                        cadena += "(@oferta, @cliente) ";
                        SqlCommand comandoCompra = new SqlCommand(cadena, conexion);
                        comandoCompra.Parameters.AddWithValue("@cliente", UsuarioTB.Text);
                        comandoCompra.Parameters.AddWithValue("@oferta", oferta);
                        int cant;
                        cant = comandoCompra.ExecuteNonQuery();
                        if (cant == 1)
                        {
                            MessageBox.Show("Muchas gracias por su compra...");
                            saldo(UsuarioTB.Text);

                        }
                    }
                    else
                    {
                        MessageBox.Show("No cuentas con el saldo suficiente para realizar esta compra...");
                    }

                }
                else
                {
                    MessageBox.Show("La cantidad a comprar excede el límite permitido por cliente...");
                }

            }
            else
            {
                MessageBox.Show("Excediste el límite de compra por cliente...");
            }

            conexion.Close();
        }
    }
}
