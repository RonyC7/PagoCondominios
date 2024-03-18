using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoCondominios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPropietario_Click(object sender, EventArgs e)
        {
            Propietario propietario = new Propietario();
            propietario.ShowDialog();
        }

        private void buttonPropiedad_Click(object sender, EventArgs e)
        {
            Propiedad propiedad = new Propiedad();
            propiedad.ShowDialog();
        }

        private void buttonDatosPropietario_Click(object sender, EventArgs e)
        {
            DatosPropietarios datosPropietarios = new DatosPropietarios();
            datosPropietarios.ShowDialog();
        }
    }
}
