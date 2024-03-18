using System;
using System.IO;
using System.Windows.Forms;

namespace PagoCondominios
{
    public partial class DatosPropietarios : Form
    {
        public DatosPropietarios()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dataGridViewDatosGenerales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonMDatos_Click(object sender, EventArgs e)
        {
            MostrarTodosDatos();
        }

        private void CargarDatos()
        {

        }

        private void MostrarTodosDatos()
        {
            dataGridViewDatosGenerales.Rows.Clear();

            if (File.Exists("propietarios.txt"))
            {
                string[] lineasPropietarios = File.ReadAllLines("propietarios.txt");
                foreach (string linea in lineasPropietarios)
                {
                    string[] datosPropietario = linea.Split(',');
                    if (datosPropietario.Length >= 3)
                    {
                        string nombre = datosPropietario[1];
                        string apellido = datosPropietario[2];
                        string dpi = datosPropietario[0];
                        string numeroCasa = ObtenerNumeroCasa(dpi);
                        string cuotaMantenimiento = ObtenerCuotaMantenimiento(numeroCasa);

                        dataGridViewDatosGenerales.Rows.Add(nombre, apellido, numeroCasa, cuotaMantenimiento);
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontró el archivo de propietarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ObtenerNumeroCasa(string dpi)
        {
            if (File.Exists("Propiedades.txt"))
            {
                string[] lineasPropiedades = File.ReadAllLines("Propiedades.txt");
                foreach (string linea in lineasPropiedades)
                {
                    string[] datosPropiedad = linea.Split(',');
                    if (datosPropiedad.Length >= 2 && datosPropiedad[1] == dpi)
                    {
                        return datosPropiedad[0];
                    }
                }
            }
            return "Número de Casa no encontrado";
        }

        private string ObtenerCuotaMantenimiento(string numeroCasa)
        {
            if (File.Exists("Propiedades.txt"))
            {
                string[] lineasPropiedades = File.ReadAllLines("Propiedades.txt");
                foreach (string linea in lineasPropiedades)
                {
                    string[] datosPropiedad = linea.Split(',');
                    if (datosPropiedad.Length >= 4 && datosPropiedad[0] == numeroCasa)
                    {
                        return datosPropiedad[3]; // Retorna la cuota de mantenimiento
                    }
                }
            }
            return "Cuota de Mantenimiento no encontrada";
        }

        private void DatosPropietarios_Load(object sender, EventArgs e)
        {

        }

        private void buttonOrden_Click(object sender, EventArgs e)
        {
            OrdenarCuotasMantenimiento();
        }

        private void OrdenarCuotasMantenimiento()
        {
            dataGridViewDatosGenerales.Sort(dataGridViewDatosGenerales.Columns[3], System.ComponentModel.ListSortDirection.Descending);
        }
    }
}
