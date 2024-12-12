partial class Form1
{
    private System.Windows.Forms.DataGridView dgvEstudiantes;
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnEstadisticas;

    private void InitializeComponent()
    {
        this.dgvEstudiantes = new System.Windows.Forms.DataGridView();
        this.btnAgregar = new System.Windows.Forms.Button();
        this.btnEliminar = new System.Windows.Forms.Button();
        this.btnEstadisticas = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).BeginInit();
        this.SuspendLayout();
        // 
        // dgvEstudiantes
        // 
        this.dgvEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dgvEstudiantes.Location = new System.Drawing.Point(12, 12);
        this.dgvEstudiantes.Name = "dgvEstudiantes";
        this.dgvEstudiantes.RowHeadersWidth = 51;
        this.dgvEstudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvEstudiantes.Size = new System.Drawing.Size(560, 300);
        this.dgvEstudiantes.TabIndex = 0;
        // 
        // btnAgregar
        // 
        this.btnAgregar.Location = new System.Drawing.Point(12, 330);
        this.btnAgregar.Name = "btnAgregar";
        this.btnAgregar.Size = new System.Drawing.Size(100, 30);
        this.btnAgregar.TabIndex = 1;
        this.btnAgregar.Text = "Agregar";
        this.btnAgregar.UseVisualStyleBackColor = true;
        this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
        // 
        // btnEliminar
        // 
        this.btnEliminar.Location = new System.Drawing.Point(130, 330);
        this.btnEliminar.Name = "btnEliminar";
        this.btnEliminar.Size = new System.Drawing.Size(100, 30);
        this.btnEliminar.TabIndex = 2;
        this.btnEliminar.Text = "Eliminar";
        this.btnEliminar.UseVisualStyleBackColor = true;
        this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
        // 
        // btnEstadisticas
        // 
        this.btnEstadisticas.Location = new System.Drawing.Point(250, 330);
        this.btnEstadisticas.Name = "btnEstadisticas";
        this.btnEstadisticas.Size = new System.Drawing.Size(100, 30);
        this.btnEstadisticas.TabIndex = 3;
        this.btnEstadisticas.Text = "Estadísticas";
        this.btnEstadisticas.UseVisualStyleBackColor = true;
        this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(600, 400);
        this.Controls.Add(this.dgvEstudiantes);
        this.Controls.Add(this.btnAgregar);
        this.Controls.Add(this.btnEliminar);
        this.Controls.Add(this.btnEstadisticas);
        this.Name = "Form1";
        this.Text = "Sistema de Registro de Estudiantes";
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dgvEstudiantes)).EndInit();
        this.ResumeLayout(false);

    }
}


