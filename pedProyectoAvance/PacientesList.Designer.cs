namespace pedProyectoAvance
{
    partial class PacientesList
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
            label1 = new Label();
            dtGPacientes = new DataGridView();
            btnAgregarPaciente = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGPacientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(567, 62);
            label1.Name = "label1";
            label1.Size = new Size(308, 41);
            label1.TabIndex = 0;
            label1.Text = "Listado de Pacientes";
            // 
            // dtGPacientes
            // 
            dtGPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGPacientes.Location = new Point(132, 169);
            dtGPacientes.Margin = new Padding(3, 4, 3, 4);
            dtGPacientes.Name = "dtGPacientes";
            dtGPacientes.RowHeadersWidth = 51;
            dtGPacientes.Size = new Size(1162, 580);
            dtGPacientes.TabIndex = 1;
            // 
            // btnAgregarPaciente
            // 
            btnAgregarPaciente.Location = new Point(1103, 108);
            btnAgregarPaciente.Name = "btnAgregarPaciente";
            btnAgregarPaciente.Size = new Size(179, 54);
            btnAgregarPaciente.TabIndex = 2;
            btnAgregarPaciente.Text = "Agregar Paciente";
            btnAgregarPaciente.UseVisualStyleBackColor = true;
            btnAgregarPaciente.Click += btnAgregarPaciente_Click;
            // 
            // PacientesList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1427, 930);
            Controls.Add(btnAgregarPaciente);
            Controls.Add(dtGPacientes);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PacientesList";
            Text = "PacientesList";
            ((System.ComponentModel.ISupportInitialize)dtGPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtGPacientes;
        private Button btnAgregarPaciente;
    }
}