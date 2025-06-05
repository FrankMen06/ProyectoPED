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

            if (dtGPacientes.Columns["PacienteID"] != null)
            {
                dtGPacientes.Columns["PacienteID"].Visible = false;
            }

            dtGPacientes.EnableHeadersVisualStyles = false;
            dtGPacientes.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dtGPacientes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtGPacientes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dtGPacientes.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dtGPacientes.DefaultCellStyle.BackColor = Color.White;
            dtGPacientes.DefaultCellStyle.ForeColor = Color.Black;
            dtGPacientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dtGPacientes.RowHeadersVisible = false;
            dtGPacientes.BorderStyle = BorderStyle.None;
            dtGPacientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtGPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGPacientes.MultiSelect = false;
            dtGPacientes.ReadOnly = true;
            dtGPacientes.BackgroundColor = this.BackColor;
            dtGPacientes.RowsDefaultCellStyle.BackColor = Color.White;
            dtGPacientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;


        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            this.Hide();
            administrarPacientes adminPaciente = new administrarPacientes(null, null, _context, true);
            adminPaciente.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            administradorOptions adminOpt = new administradorOptions(_context);
            adminOpt.Show();
        }
    }

}
