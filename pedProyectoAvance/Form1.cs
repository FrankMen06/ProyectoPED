using pedProyectoAvance.Contexto;
using pedProyectoAvance.modelosBD;

namespace pedProyectoAvance;

public partial class Form1 : Form
{
    private readonly dbContext _context;

    public Form1(dbContext context)
    {
        _context = context;
        InitializeComponent();

    }

    public static class SesionUsuarios
    {
        public static int EmpleadoID { get; set; }
        public static int TipoEmpleado { get; set; }
        public static string NombreCompleto { get; set; }
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnIngresar_Click(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string password = txtPassword.Text;
        _context.TipoEmpleados.ToList();
        _context.Estado.ToList();
        var response = _context.Empleados.Where(a => usuario == a.Usuario && password == a.Password).FirstOrDefault();

        if (response != null)
        {
            //MessageBox.Show("Contacto eliminado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SesionUsuarios.EmpleadoID = response.EmpleadoID;
            SesionUsuarios.TipoEmpleado = response.TipoEmpleadoID;
            SesionUsuarios.NombreCompleto = response.NombreCompleto;

            if (SesionUsuarios.TipoEmpleado == 2)
            {
                // Redirigir a la ventana de administrador
                administradorOptions administradorOptions = new administradorOptions(_context);
                administradorOptions.Show();
            }
            else if (SesionUsuarios.TipoEmpleado == 1)
            {
                // Redirigir a la ventana de médico
                FormDoctor formDoctor = new FormDoctor(SesionUsuarios.EmpleadoID, SesionUsuarios.NombreCompleto, _context);
                formDoctor.Show();
            }

            this.Hide();
        }
        else
        {
            MessageBox.Show("No se encontró el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}