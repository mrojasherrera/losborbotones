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
    public partial class RolEncontrado : Form
    {
        public RolEncontrado()
        {
            InitializeComponent();
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            AbmRol.ModificarRol modificar = new AbmRol.ModificarRol();
            modificar.Show();
        }
    }
}
