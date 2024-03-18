using System;
using System.IO;
using System.Windows.Forms;

namespace PagoCondominios
{
    public partial class Propiedad : Form
    {
        public Propiedad()
        {
            InitializeComponent();
            CargarPropietarios(); // Llama al método para cargar los propietarios en el ComboBox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numeroCasa = textBoxNCasa.Text;
            string dpi = comboBoxDPI.SelectedItem?.ToString();
            string cuotaMantenimiento = textBoxCuotaMan.Text;

            if (string.IsNullOrEmpty(numeroCasa) || string.IsNullOrEmpty(dpi) || string.IsNullOrEmpty(cuotaMantenimiento))
            {
                MessageBox.Show("Por favor ingrese todos los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GuardarPropiedad(numeroCasa, dpi, cuotaMantenimiento);
            MessageBox.Show("Propiedad guardada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CargarPropietarios()
        {
            if (!File.Exists("propietarios.txt"))
                return;

            string[] lineas = File.ReadAllLines("propietarios.txt");
            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');
                if (datos.Length > 0)
                {
                    comboBoxDPI.Items.Add(datos[0]); // Agrega el DPI al ComboBox
                }
            }
        }

        private void GuardarPropiedad(string numeroCasa, string dpi, string cuotaMantenimiento)
        {
            using (StreamWriter writer = new StreamWriter("Propiedades.txt", true))
            {
                writer.WriteLine($"{numeroCasa},{dpi},{cuotaMantenimiento}");
            }
        }
    }
}
