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
            lblNombre.Text = $"Bienvenio Dr. {nombreDoctor}";
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

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            administrarPacientes administrarPacientes = new administrarPacientes( doctorId,  nombreDoctor, _context, false);
            administrarPacientes.Show();
        }
    }
}
