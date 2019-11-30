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
    public partial class NuevoRol : Form
    {
        public NuevoRol()
        {
            InitializeComponent();
        }

        private void NuevoRol_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gD2C2019DataSet1.Funcionalidad' Puede moverla o quitarla según sea necesario.
            this.funcionalidadTableAdapter.Fill(this.gD2C2019DataSet1.Funcionalidad);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
