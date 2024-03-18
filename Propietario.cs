using System;
using System.IO;
using System.Windows.Forms;

namespace PagoCondominios
{
    public partial class Propietario : Form
    {
        public Propietario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dpi = textBoxDPI.Text;
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;

            if (string.IsNullOrEmpty(dpi) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Por favor ingrese todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PropietarioExistente(dpi))
            {
                MessageBox.Show("Ya existe un propietario con este DPI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GuardarPropietario(dpi, nombre, apellido);
            MessageBox.Show("Propietario guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool PropietarioExistente(string dpi)
        {
            if (!File.Exists("propietarios.txt"))
                return false;

            string[] lineas = File.ReadAllLines("propietarios.txt");
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');
                if (datos.Length > 0 && datos[0] == dpi)
                {
                    return true;
                }
            }
            return false;
        }

        private void GuardarPropietario(string dpi, string nombre, string apellido)
        {
            using (StreamWriter writer = new StreamWriter("propietarios.txt", true))
            {
                writer.WriteLine($"{dpi},{nombre},{apellido}");
            }
        }
    }
}
