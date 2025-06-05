using pedProyectoAvance.Contexto;
using pedProyectoAvance.modelosBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pedProyectoAvance
{
    public partial class administrarPacientes : Form
    {
        private bool admin;
        private int doctorId;
        private string nombreDoctor;
        private readonly dbContext _context;

        public administrarPacientes(int? doctorId, string? nombreDoctor, dbContext context, bool ruta)
        {
            this.admin = ruta;
            _context = context;
            if (doctorId != null && nombreDoctor != null)
            {
                this.doctorId = doctorId ?? 0;
                this.nombreDoctor = nombreDoctor;
            }
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if (this.admin == true)
            {
                this.Hide();
                administradorOptions administradorOptions = new administradorOptions(_context);
                administradorOptions.Show();
            }
            else
            {
                this.Hide();
                FormDoctor formDoctor = new FormDoctor(doctorId, nombreDoctor, _context);
                formDoctor.Show();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDui.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtPeso.Text) ||
                string.IsNullOrWhiteSpace(txtEstatura.Text) ||
                cmbSexo.SelectedIndex == -1 ||
                cmbTipoSangre.SelectedIndex == -1)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que Edad sea número entero
            if (!int.TryParse(txtEdad.Text, out _))
            {
                MessageBox.Show("Edad debe ser un número entero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que Peso sea decimal
            if (!decimal.TryParse(txtPeso.Text, out _))
            {
                MessageBox.Show("Peso debe ser un número decimal (usa punto o coma según tu configuración regional).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que Estatura sea decimal
            if (!decimal.TryParse(txtEstatura.Text, out _))
            {
                MessageBox.Show("Estatura debe ser un número decimal.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pacientes paciente = new Pacientes();

            paciente.DUI = txtDui.Text;
            paciente.NombreCompleto = txtNombre.Text;
            paciente.Telefono = txtTelefono.Text;
            paciente.Sexo = cmbSexo.Text;
            paciente.Edad = int.Parse(txtEdad.Text);
            paciente.TipoSangre = cmbTipoSangre.Text;
            paciente.Estatura = int.Parse(txtEstatura.Text);
            paciente.Peso = int.Parse(txtPeso.Text);
            paciente.Sexo = cmbSexo.Text;

            _context.Pacientes.Add(paciente);
            if (_context.SaveChanges() > 0)
            {
                MessageBox.Show("Se ha registrado el paciente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (doctorId == null)
                {
                    this.Hide();
                    PacientesList pacientesList = new PacientesList(_context);
                    pacientesList.Show();
                }
                else
                {
                    this.Hide();
                    FormDoctor formDoc = new FormDoctor(doctorId, nombreDoctor, _context);
                    formDoc.Show();
                }
            }
        }
    }
}
