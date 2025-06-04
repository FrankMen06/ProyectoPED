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
            ((System.ComponentModel.ISupportInitialize)dtGPacientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(435, 44);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 0;
            label1.Text = "Listado de Pacientes";
            // 
            // dtGPacientes
            // 
            dtGPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGPacientes.Location = new Point(84, 118);
            dtGPacientes.Name = "dtGPacientes";
            dtGPacientes.Size = new Size(937, 435);
            dtGPacientes.TabIndex = 1;
            // 
            // PacientesList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1110, 650);
            Controls.Add(dtGPacientes);
            Controls.Add(label1);
            Name = "PacientesList";
            Text = "PacientesList";
            ((System.ComponentModel.ISupportInitialize)dtGPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtGPacientes;
    }
}