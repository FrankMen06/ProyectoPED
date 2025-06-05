namespace pedProyectoAvance
{
    partial class FormCita
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
            txtBuscarPaciente = new TextBox();
            lstPacientes = new ListBox();
            label2 = new Label();
            dtpFechaHora = new DateTimePicker();
            label3 = new Label();
            txtDescripcion = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F);
            label1.Location = new Point(13, 84);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Paciente";
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarPaciente.Location = new Point(151, 84);
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.Size = new Size(250, 27);
            txtBuscarPaciente.TabIndex = 1;
            txtBuscarPaciente.TextChanged += txtBuscarPaciente_TextChanged;
            // 
            // lstPacientes
            // 
            lstPacientes.DisplayMember = "Value";
            lstPacientes.FormattingEnabled = true;
            lstPacientes.Location = new Point(151, 117);
            lstPacientes.Name = "lstPacientes";
            lstPacientes.Size = new Size(250, 184);
            lstPacientes.TabIndex = 2;
            lstPacientes.ValueMember = "Key";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F);
            label2.Location = new Point(13, 336);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 3;
            label2.Text = "Fecha y Hora";
            // 
            // dtpFechaHora
            // 
            dtpFechaHora.CustomFormat = "yyyy-MM-dd HH:mm";
            dtpFechaHora.Format = DateTimePickerFormat.Custom;
            dtpFechaHora.Location = new Point(151, 336);
            dtpFechaHora.Name = "dtpFechaHora";
            dtpFechaHora.Size = new Size(250, 27);
            dtpFechaHora.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.Location = new Point(13, 401);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 5;
            label3.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(151, 401);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(250, 168);
            txtDescripcion.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.MediumSeaGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(46, 607);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(164, 36);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(216, 607);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(164, 36);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(-1, -2);
            label4.Name = "label4";
            label4.Size = new Size(440, 51);
            label4.TabIndex = 9;
            label4.Text = "Agendar Cita";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormCita
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(433, 692);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(label3);
            Controls.Add(dtpFechaHora);
            Controls.Add(label2);
            Controls.Add(lstPacientes);
            Controls.Add(txtBuscarPaciente);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCita";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCita";
            Load += FormCita_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBuscarPaciente;
        private ListBox lstPacientes;
        private Label label2;
        private DateTimePicker dtpFechaHora;
        private Label label3;
        private TextBox txtDescripcion;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label label4;
    }
}