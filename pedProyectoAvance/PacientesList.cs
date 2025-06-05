using pedProyectoAvance.Contexto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pedProyectoAvance.modelosBD;

namespace pedProyectoAvance
{
    public partial class PacientesList : Form
    {
        private readonly dbContext _context;
        Dictionary<int, Pacientes> pacientesDict = new Dictionary<int, Pacientes>();

        public PacientesList(dbContext context)
        {
            _context = context;
            InitializeComponent();

            var listPacientes = _context.Pacientes.ToList();

            pacientesDict.Clear();
            foreach (var paciente in listPacientes)
            {
                pacientesDict[paciente.PacienteID] = paciente;
            }

            // Mostrar en la grilla
            dtGPacientes.DataSource = null;
            dtGPacientes.DataSource = listPacientes;

        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            this.Hide();
            administrarPacientes adminPaciente = new administrarPacientes(null, null, _context, true);
            adminPaciente.Show();

        }
    }

}
