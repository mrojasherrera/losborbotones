using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.PantallaUsuarios
{
    public partial class PantallaAdmin : Form
    {
        public PantallaAdmin(String unAdm)
        {
            InitializeComponent();
            AdmTB.Text = unAdm;
        }


        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FrbaOfertas.Login login = new FrbaOfertas.Login();
            login.Show();
        }

        private void ClienteBtn_Click(object sender, EventArgs e)
        {
            AbmCliente.AccionesCliente abmCliente = new AbmCliente.AccionesCliente();
            abmCliente.ShowDialog(); 
        }

        private void ProveedorBtn_Click(object sender, EventArgs e)
        {
            AbmProveedor.AccionesProveedor proveedor = new AbmProveedor.AccionesProveedor();
            proveedor.ShowDialog();
        }

        private void RolBtn_Click(object sender, EventArgs e)
        {
            AbmRol.AccionesRol rol = new AbmRol.AccionesRol();
            rol.ShowDialog();
        }

        private void CreditoBtn_Click(object sender, EventArgs e)
        {
            CargaCredito.Cargar cargar = new CargaCredito.Cargar();
            cargar.ShowDialog();
        }

        private void FacturarBtn_Click(object sender, EventArgs e)
        {
            Facturar.FacturarProv facturar = new Facturar.FacturarProv();
            facturar.ShowDialog();
        }

        private void EstadisticoBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
