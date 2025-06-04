using Microsoft.EntityFrameworkCore;
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
    public partial class administradorOptions : Form
    {
        private readonly dbContext _context;

        public administradorOptions(dbContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PacientesList administrarPacientes = new PacientesList(_context);
            administrarPacientes.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
