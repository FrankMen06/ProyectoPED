using pedProyectoAvance.Contexto;
using pedProyectoAvance.modelosBD;
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

namespace pedProyectoAvance
{
    public partial class PacientesList : Form
    {
        private readonly dbContext _context;
        Dictionary<int, Paciente> pacientesDict = new Dictionary<int, Paciente>();

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
