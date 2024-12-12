namespace SistemaRegistroEstudiantes
{
    partial class FormAgregarEditar
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.RadioButton rbtnBecado;
        private System.Windows.Forms.RadioButton rbtnRegular;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblGrado;
        private System.Windows.Forms.Label lblEstado;

        /// <summary>
        /// Limpiar recursos.
        /// </summary>
        /// <param name="disposing">True si se deben liberar los recursos administrados; false de lo contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Inicialización de los componentes del formulario.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.rbtnBecado = new System.Windows.Forms.RadioButton();
            this.rbtnRegular = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblGrado = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Label: lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 15);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";

            // TextBox: txtNombre
            this.txtNombre.Location = new System.Drawing.Point(80, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 22);
            this.txtNombre.TabIndex = 1;

            // Label: lblEdad
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(12, 50);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 17);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";

            // TextBox: txtEdad
            this.txtEdad.Location = new System.Drawing.Point(80, 47);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(50, 22);
            this.txtEdad.TabIndex = 3;

            // Label: lblGrado
            this.lblGrado.AutoSize = true;
            this.lblGrado.Location = new System.Drawing.Point(12, 85);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(51, 17);
            this.lblGrado.TabIndex = 4;
            this.lblGrado.Text = "Grado:";

            // ComboBox: cmbGrado
            this.cmbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Items.AddRange(new object[] {
            "Primero",
            "Segundo",
            "Tercero"});
            this.cmbGrado.Location = new System.Drawing.Point(80, 82);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(121, 24);
            this.cmbGrado.TabIndex = 5;

            // Label: lblEstado
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(12, 125);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(56, 17);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";

            // RadioButton: rbtnBecado
            this.rbtnBecado.AutoSize = true;
            this.rbtnBecado.Location = new System.Drawing.Point(80, 123);
            this.rbtnBecado.Name = "rbtnBecado";
            this.rbtnBecado.Size = new System.Drawing.Size(76, 21);
            this.rbtnBecado.TabIndex = 7;
            this.rbtnBecado.TabStop = true;
            this.rbtnBecado.Text = "Becado";
            this.rbtnBecado.UseVisualStyleBackColor = true;

            // RadioButton: rbtnRegular
            this.rbtnRegular.AutoSize = true;
            this.rbtnRegular.Location = new System.Drawing.Point(162, 123);
            this.rbtnRegular.Name = "rbtnRegular";
            this.rbtnRegular.Size = new System.Drawing.Size(76, 21);
            this.rbtnRegular.TabIndex = 8;
            this.rbtnRegular.TabStop = true;
            this.rbtnRegular.Text = "Regular";
            this.rbtnRegular.UseVisualStyleBackColor = true;

            // Button: btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(80, 170);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 30);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // FormAgregarEditar
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblGrado);
            this.Controls.Add(this.cmbGrado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.rbtnBecado);
            this.Controls.Add(this.rbtnRegular);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FormAgregarEditar";
            this.Text = "Agregar/Editar Estudiante";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
