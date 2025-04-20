using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pedProyectoAvance.modelosBD;
[Table("TipoEmpleado", Schema = "dbo")]

public class TipoEmpleado
{
    [Key]
    public int TipoEmpleadoID { get; set; }
    public string Tipo { get; set; }
}