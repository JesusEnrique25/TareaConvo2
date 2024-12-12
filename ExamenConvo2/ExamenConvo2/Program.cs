using System;
using System.Windows.Forms;

namespace SistemaRegistroEstudiantes
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Habilitar estilos visuales
            Application.EnableVisualStyles();

            // Configurar el renderizado de texto compatible
            Application.SetCompatibleTextRenderingDefault(false);

            // Ejecutar el formulario principal
            Application.Run(new Form1());
        }
    }
}
