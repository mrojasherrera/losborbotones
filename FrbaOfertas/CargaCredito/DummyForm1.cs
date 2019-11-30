using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace FrbaOfertas.CargaCredito
{
    public partial class DummyForm1 : Form
    {
        public DummyForm1()
        {
            InitializeComponent();
        }

        private void btnFechaSistema_Click(object sender, EventArgs e)
        {
            var unaFecha = Properties.Settings.Default.fechaSistema;
            btnFechaSistema.Text = unaFecha;

        }
    }
}(
