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
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtGrdVCitas).BeginInit();
            SuspendLayout();
            // 
            // dtGrdVCitas
            // 
            dtGrdVCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrdVCitas.Location = new Point(50, 227);
            dtGrdVCitas.Name = "dtGrdVCitas";
            dtGrdVCitas.RowHeadersWidth = 51;
            dtGrdVCitas.Size = new Size(897, 354);
            dtGrdVCitas.TabIndex = 0;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(50, 89);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(277, 44);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Bienvenido Dr.";
            // 
            // datePickFecha
            // 
            datePickFecha.Location = new Point(50, 194);
            datePickFecha.Name = "datePickFecha";
            datePickFecha.Size = new Size(297, 27);
            datePickFecha.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.LightCoral;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(50, 610);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(184, 42);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar Sesion";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnCita
            // 
            btnCita.BackColor = Color.CornflowerBlue;
            btnCita.FlatStyle = FlatStyle.Flat;
            btnCita.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCita.ForeColor = Color.White;
            btnCita.Location = new Point(768, 171);
            btnCita.Name = "btnCita";
            btnCita.Size = new Size(179, 38);
            btnCita.TabIndex = 4;
            btnCita.Text = "Agendar Cita";
            btnCita.UseVisualStyleBackColor = false;
            btnCita.Click += btnCita_Click;
            // 
            // btnNuevoPaciente
            // 
            btnNuevoPaciente.BackColor = Color.MediumSeaGreen;
            btnNuevoPaciente.FlatStyle = FlatStyle.Flat;
            btnNuevoPaciente.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoPaciente.ForeColor = Color.White;
            btnNuevoPaciente.Location = new Point(583, 171);
            btnNuevoPaciente.Name = "btnNuevoPaciente";
            btnNuevoPaciente.Size = new Size(179, 38);
            btnNuevoPaciente.TabIndex = 5;
            btnNuevoPaciente.Text = "Nuevo Paciente";
            btnNuevoPaciente.UseVisualStyleBackColor = false;
            btnNuevoPaciente.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 171);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 6;
            label1.Text = "Fecha:";
            // 
            // label4
            // 
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(-4, 0);
            label4.Name = "label4";
            label4.Size = new Size(1022, 51);
            label4.TabIndex = 7;
            label4.Text = "Hospital Don Bosco";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1017, 700);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnNuevoPaciente);
            Controls.Add(btnCita);
            Controls.Add(btnCerrar);
            Controls.Add(datePickFecha);
            Controls.Add(lblNombre);
            Controls.Add(dtGrdVCitas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDoctor";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label1;
        private Label label4;
    }
}