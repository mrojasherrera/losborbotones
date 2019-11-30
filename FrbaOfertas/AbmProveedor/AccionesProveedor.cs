using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmProveedor
{
    public partial class AccionesProveedor : Form
    {
        public AccionesProveedor()
        {
            InitializeComponent();
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NuevoBtn_Click(object sender, EventArgs e)
        {
            AbmProveedor.NuevoProveedor nuevo = new AbmProveedor.NuevoProveedor();
            nuevo.ShowDialog();
        }

        private void FiltrarBtn_Click(object sender, EventArgs e)
        {
            AbmProveedor.FiltrarProveedor filtrar = new FiltrarProveedor();
            filtrar.ShowDialog();
        }

        private void RestaurarBtn_Click(object sender, EventArgs e)
        {
            AbmProveedor.RestaurarProveedor restaurar = new RestaurarProveedor();
            restaurar.ShowDialog();
        }
    }
}
