using Microsoft.Data.SqlClient;
using pedProyectoAvance.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;


namespace pedProyectoAvance
{
    public partial class FormDoctor : Form
    {
        private int doctorId;
        private string nombreDoctor;
        private readonly dbContext _context;


        public FormDoctor(int doctorId, string nombreDoctor, dbContext context)
        {
            _context = context;
            InitializeComponent();

            this.doctorId = doctorId;
            this.nombreDoctor = nombreDoctor;
            lblNombre.Text = $"Bienvenido Dr. {nombreDoctor}";
            datePickFecha.ValueChanged += dateTimePickerFecha_ValueChanged;
            CargarCitas(DateTime.Now);
        }

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = datePickFecha.Value.Date;
            CargarCitas(fechaSeleccionada);
        }

        private void CargarCitas(DateTime fechaFiltro)
        {
            DateTime inicio = fechaFiltro.Date;
            DateTime fin = inicio.AddDays(1);

            var citas = _context.Cita
            .Include(c => c.Paciente)
            .Where(c => c.EmpleadoID == doctorId &&
                        c.FechaHora >= inicio && c.FechaHora < fin)
            .OrderBy(c => c.FechaHora)
            .Select(c => new
            {
                Fecha = c.FechaHora.ToString("yyyy-MM-dd HH:mm"),
                Paciente = c.Paciente.NombreCompleto,
                Descripcion = c.Descripcion
            })
            .ToList();

            dtGrdVCitas.DataSource = citas;
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            administrarPacientes administrarPacientes = new administrarPacientes(doctorId, nombreDoctor, _context, false);
            administrarPacientes.Show();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            this.Hide();
            using var form = new FormCita(_context, doctorId, nombreDoctor);
            if (form.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Cita registrada con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
