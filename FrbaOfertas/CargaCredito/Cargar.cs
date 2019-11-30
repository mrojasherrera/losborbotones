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
    public partial class Cargar : Form
    {
        public Cargar()
        {
            InitializeComponent();
            TipoPagoCB.DropDownStyle = ComboBoxStyle.DropDownList;
            cargarCB(TipoPagoCB);
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

         SqlConnection conexion = new SqlConnection("Data Source=localhost\\SQLSERVER2012;Initial Catalog=GD2C2019;Persist Security Info=True;User ID=gdCupon2019;Password=gd2019");

         //CARGAR COMBO BOX CON TIPOS DE PAGO
         public void cargarCB(ComboBox combo)
         {
             conexion.Open();
             SqlCommand comandoCB = new SqlCommand("SELECT Tipo_Pago_Desc FROM LOS_BORBOTONES.TipoDePago", conexion);
             SqlDataReader dataCB = comandoCB.ExecuteReader();
             while (dataCB.Read())
             {
                 combo.Items.Add(dataCB[0].ToString());
             }
             conexion.Close();
             combo.Items.Insert(0, "Elegir una opción...");
             combo.SelectedIndex = 0;
         }




         private void Monto_ModifiedChanged(object sender, EventArgs e)
         {
             MessageBox.Show("el monto cambio");
         }

         private void textBox1_DoubleClick(object sender, EventArgs e)
         {
             BuscarDniCliente 
         }
    }
}
