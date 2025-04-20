using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pedProyectoAvance.modelosBD;
[Table("Estado", Schema = "dbo")]

public class Estado
{
    [Key]
    public int EstadoID { get; set; }

    public string TipoEstado { get; set; }
}