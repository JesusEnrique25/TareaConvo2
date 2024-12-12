
using ExamenConvo2;
using SistemaRegistroEstudiantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


public partial class Form1 : Form
{
    private List<Estudiante> estudiantes = new List<Estudiante>();

    public Form1()
    {
        InitializeComponent();
        CargarEstudiantesIniciales();
        ActualizarTabla();
    }

    private void CargarEstudiantesIniciales()
    {
        estudiantes.Add(new Estudiante { Nombre = "Juan Pérez", Edad = 18, Grado = "Primero", Estado = "Becado" });
        estudiantes.Add(new Estudiante { Nombre = "Ana Gómez", Edad = 20, Grado = "Segundo", Estado = "Regular" });
    }


    private void ActualizarTabla()
    {
        dgvEstudiantes.DataSource = null;
        dgvEstudiantes.DataSource = estudiantes;
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        var form = new FormAgregarEditar();
        if (form.ShowDialog() == DialogResult.OK)
        {
            estudiantes.Add(form.Estudiante);
            ActualizarTabla();
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (dgvEstudiantes.SelectedRows.Count > 0)
        {
            var estudiante = dgvEstudiantes.SelectedRows[0].DataBoundItem as Estudiante;
            estudiantes.Remove(estudiante);
            ActualizarTabla();
        }
        else
        {
            MessageBox.Show("Selecciona un estudiante para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEstadisticas_Click(object sender, EventArgs eventArgs)
    {
        var promedioEdad = estudiantes.Average(est => est.Edad); // Cambiar 'e' por 'est'
        var totalPorGrado = estudiantes.GroupBy(est => est.Grado).ToDictionary(g => g.Key, g => g.Count());
        var porcentajeBecados = (double)estudiantes.Count(est => est.Estado == "Becado") / estudiantes.Count * 100;

        string estadisticas = $"Promedio de edad: {promedioEdad:F2}\n" +
                              "Total por grado:\n" + string.Join("\n", totalPorGrado.Select(g => $"{g.Key}: {g.Value}")) +
                              $"\nPorcentaje de becados: {porcentajeBecados:F2}%";

        MessageBox.Show(estadisticas, "Estadísticas", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
}

