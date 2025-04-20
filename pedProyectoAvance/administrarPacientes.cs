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
    public partial class administrarPacientes : Form
    {
        private bool ruta;
        private int doctorId;
        private string nombreDoctor;
        private readonly dbContext _context;

        public administrarPacientes(int? doctorId, string? nombreDoctor, dbContext context, bool ruta)
        {
            this.ruta = ruta;
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
            if (this.ruta == true)
            {
                this.Hide();
                administradorOptions administradorOptions = new administradorOptions(_context);
                administradorOptions.Show();
            }
            else
            {
                this.Hide();
                FormDoctor formDoctor= new FormDoctor(doctorId, nombreDoctor, _context);
                formDoctor.Show();
            }
        }
    }
}
