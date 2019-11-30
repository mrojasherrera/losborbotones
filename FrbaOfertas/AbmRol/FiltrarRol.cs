using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmRol
{
    public partial class FiltrarRol : Form
    {
        public FiltrarRol()
        {
            InitializeComponent();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            AbmRol.RolEncontrado encontrado = new AbmRol.RolEncontrado();
            encontrado.Show();
        }
    }
}
