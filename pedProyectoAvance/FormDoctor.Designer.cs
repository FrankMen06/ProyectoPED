namespace pedProyectoAvance
{
    partial class FormDoctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtGrdVCitas = new DataGridView();
            lblNombre = new Label();
            datePickFecha = new DateTimePicker();
            btnCerrar = new Button();
            btnCita = new Button();
            btnNuevoPaciente = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGrdVCitas).BeginInit();
            SuspendLayout();
            // 
            // dtGrdVCitas
            // 
            dtGrdVCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrdVCitas.Location = new Point(191, 239);
            dtGrdVCitas.Name = "dtGrdVCitas";
            dtGrdVCitas.RowHeadersWidth = 51;
            dtGrdVCitas.Size = new Size(1123, 549);
            dtGrdVCitas.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Tahoma", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(532, 57);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(133, 45);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "label1";
            // 
            // datePickFecha
            // 
            datePickFecha.Location = new Point(264, 176);
            datePickFecha.Name = "datePickFecha";
            datePickFecha.Size = new Size(250, 27);
            datePickFecha.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(629, 820);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(290, 67);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar Sesion";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnCita
            // 
            btnCita.Location = new Point(881, 150);
            btnCita.Name = "btnCita";
            btnCita.Size = new Size(166, 63);
            btnCita.TabIndex = 4;
            btnCita.Text = "Agendar Cita";
            btnCita.UseVisualStyleBackColor = true;
            // 
            // btnNuevoPaciente
            // 
            btnNuevoPaciente.Location = new Point(1106, 150);
            btnNuevoPaciente.Name = "btnNuevoPaciente";
            btnNuevoPaciente.Size = new Size(166, 63);
            btnNuevoPaciente.TabIndex = 5;
            btnNuevoPaciente.Text = "Nuevo Paciente";
            btnNuevoPaciente.UseVisualStyleBackColor = true;
            btnNuevoPaciente.Click += button1_Click;
            // 
            // FormDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1530, 942);
            Controls.Add(btnNuevoPaciente);
            Controls.Add(btnCita);
            Controls.Add(btnCerrar);
            Controls.Add(datePickFecha);
            Controls.Add(lblNombre);
            Controls.Add(dtGrdVCitas);
            Name = "FormDoctor";
            Text = "FormDoctor";
            ((System.ComponentModel.ISupportInitialize)dtGrdVCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtGrdVCitas;
        private Label lblNombre;
        private DateTimePicker datePickFecha;
        private Button btnCerrar;
        private Button btnCita;
        private Button btnNuevoPaciente;
    }
}