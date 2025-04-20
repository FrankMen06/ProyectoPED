   using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace pedProyectoAvance.modelosBD;
[Table("Empleados", Schema = "dbo")]
public class Empleados
{
    [Key]
    public int EmpleadoID { get; set; }
    public string DUI { get; set; }
    public string NombreCompleto { get; set; }
    public int Estado { get; set; }
    public int TipoEmpleadoID { get; set; }
    public string Usuario { get; set; }
    public string Password { get; set; }
    public string Especialidad { get; set; }
    
    public Estado? Estados { get; set; }
    public TipoEmpleado? TipoEmpleados { get; set; }
}