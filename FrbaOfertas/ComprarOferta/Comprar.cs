using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.ComprarOferta
{
    public partial class Comprar : Form
    {
        public Comprar(String unCliente)
        {
            InitializeComponent();
            UsuarioTB.Text = unCliente;
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
