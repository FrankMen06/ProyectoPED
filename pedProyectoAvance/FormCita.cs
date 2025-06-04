using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using pedProyectoAvance.Contexto;
using pedProyectoAvance.modelosBD;

namespace pedProyectoAvance
{
    public partial class FormCita : Form
    {
        private readonly dbContext _context;
        private readonly int _doctorId;
        private string nombreDoctor;
        private Dictionary<int, string> _pacientes = new();

        public FormCita(dbContext context, int doctorId, string? nombreDoctor)
        {
            InitializeComponent();
            _context = context;
            _doctorId = doctorId;
            this.nombreDoctor = nombreDoctor;
        }

     

        private void CargarPacientes()
        {
            _pacientes = _context.Pacientes
            .ToDictionary(p => p.PacienteID, p => p.NombreCompleto ?? "(Sin nombre)");

            //MessageBox.Show(string.Join(",", _pacientes.Values));

        }

        private void ActualizarLista(Dictionary<int, string> fuente)
        {
            lstPacientes.DataSource = new BindingSource(fuente.ToList(), null);
        }

        private void txtBuscarPaciente_TextChanged(object sender, EventArgs e)
        {

            string texto = txtBuscarPaciente.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(texto))
            {
                ActualizarLista(_pacientes);
                return;
            }

            var filtrados = _pacientes
                .Where(p => (p.Value ?? "").ToLower().Contains(texto))
                .ToDictionary(p => p.Key, p => p.Value ?? "(Sin nombre)");


            ActualizarLista(filtrados);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (lstPacientes.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un paciente.", "Validación");
                return;
            }

            var seleccionado = (KeyValuePair<int, string>)lstPacientes.SelectedItem;
            int pacienteId = seleccionado.Key;
            DateTime fecha = dtpFechaHora.Value;
            string descripcion = txtDescripcion.Text.Trim();

            if (fecha <= DateTime.Now)
            {
                MessageBox.Show("La fecha debe ser futura.");
                return;
            }

            bool existeConflicto = _context.Cita.Any(c =>
                c.EmpleadoID == _doctorId &&
                c.FechaHora == fecha);

            if (existeConflicto)
            {
                MessageBox.Show("Ya existe una cita agendada para esa hora.");
                return;
            }

            Cita nueva = new()
            {
                PacienteID = pacienteId,
                EmpleadoID = _doctorId,
                FechaHora = fecha,
                Descripcion = descripcion
            };

            _context.Cita.Add(nueva);
            _context.SaveChanges();

            MessageBox.Show("Cita guardada correctamente.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDoctor formDoctor = new FormDoctor(_doctorId, nombreDoctor, _context);
            formDoctor.Show();
        }

        private void FormCita_Load_1(object sender, EventArgs e)
        {
            CargarPacientes();
            lstPacientes.DisplayMember = "Value";
            lstPacientes.ValueMember = "Key";
            ActualizarLista(_pacientes);
        }
    }
}
