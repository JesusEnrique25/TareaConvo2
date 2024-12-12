
using ExamenConvo2;
using System;
using System.Windows.Forms;

namespace SistemaRegistroEstudiantes
{
    public partial class FormAgregarEditar : Form
    {
        public Estudiante Estudiante { get; private set; }

        public FormAgregarEditar(Estudiante estudiante = null)
        {
            InitializeComponent();
            if (estudiante != null)
            {
                txtNombre.Text = estudiante.Nombre;
                txtEdad.Text = estudiante.Edad.ToString();
                cmbGrado.SelectedItem = estudiante.Grado;
                if (estudiante.Estado == "Becado")
                    rbtnBecado.Checked = true;
                else
                    rbtnRegular.Checked = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Estudiante = new Estudiante
                {
                    Nombre = txtNombre.Text,
                    Edad = int.Parse(txtEdad.Text),
                    Grado = cmbGrado.SelectedItem.ToString(),
                    Estado = rbtnBecado.Checked ? "Becado" : "Regular"
                };
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtEdad.Text, out int edad) || edad < 6 || edad > 30)
            {
                MessageBox.Show("La edad debe estar entre 6 y 30 años.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cmbGrado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un grado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void FormAgregarEditar_Load(object sender, EventArgs e)
        {

        }
    }
}
