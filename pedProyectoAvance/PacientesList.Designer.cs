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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            label1 = new System.Windows.Forms.Label();
            dtGPacientes = new System.Windows.Forms.DataGridView();
            btnAgregarPaciente = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dtGPacientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI Historic", 11.52F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.Location = new System.Drawing.Point(567, 62);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(208, 28);
            label1.TabIndex = 0;
            label1.Text = "Listado de Pacientes";
            // 
            // dtGPacientes
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtGPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtGPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dtGPacientes.DefaultCellStyle = dataGridViewCellStyle2;
            dtGPacientes.Location = new System.Drawing.Point(132, 169);
            dtGPacientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtGPacientes.Name = "dtGPacientes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dtGPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtGPacientes.RowHeadersWidth = 51;
            dtGPacientes.Size = new System.Drawing.Size(1162, 580);
            dtGPacientes.TabIndex = 1;
            // 
            // btnAgregarPaciente
            // 
            btnAgregarPaciente.Location = new System.Drawing.Point(1103, 108);
            btnAgregarPaciente.Name = "btnAgregarPaciente";
            btnAgregarPaciente.Size = new System.Drawing.Size(179, 54);
            btnAgregarPaciente.TabIndex = 2;
            btnAgregarPaciente.Text = "Agregar Paciente";
            btnAgregarPaciente.UseVisualStyleBackColor = true;
            btnAgregarPaciente.Click += btnAgregarPaciente_Click;
            // 
            // button1
            // 
            button1.AccessibleName = "btnVolver";
            button1.Location = new System.Drawing.Point(464, 756);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(159, 46);
            button1.TabIndex = 3;
            button1.Text = "Volver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AccessibleName = "btnSalir";
            button2.Location = new System.Drawing.Point(798, 756);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(159, 46);
            button2.TabIndex = 4;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PacientesList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(1431, 946);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAgregarPaciente);
            Controls.Add(dtGPacientes);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Text = "PacientesList";
            ((System.ComponentModel.ISupportInitialize)dtGPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        #endregion

        private Label label1;
        private DataGridView dtGPacientes;
        private Button btnAgregarPaciente;
    }
}