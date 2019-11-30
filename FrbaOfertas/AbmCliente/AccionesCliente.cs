using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmCliente
{
    public partial class AccionesCliente : Form
    {
        public AccionesCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoBtn_Click(object sender, EventArgs e)
        {
           
            AbmCliente.NuevoCliente nuevo = new AbmCliente.NuevoCliente();
            nuevo.ShowDialog();
        }

        private void RestaurarBtn_Click(object sender, EventArgs e)
        {
            
            AbmCliente.RestaurarCliente restaurar = new AbmCliente.RestaurarCliente();
            restaurar.ShowDialog();
        }

        private void FiltrarBtn_Click(object sender, EventArgs e)
        {
          
            AbmCliente.BuscarCliente buscar = new AbmCliente.BuscarCliente();
            buscar.ShowDialog();
        }
    }
}
