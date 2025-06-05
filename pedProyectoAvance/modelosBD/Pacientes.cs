using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedProyectoAvance.modelosBD
{
    [Table("Pacientes", Schema = "dbo")]
    public class Pacientes
    {
        [Key]
        public int PacienteID { get; set; }

        [MaxLength(20)]
        public string? DUI { get; set; }

        [MaxLength(250)]
        public string? NombreCompleto { get; set; }

        [MaxLength(20)]
        public string? Telefono { get; set; }

        [MaxLength(10)]
        public string? Sexo { get; set; }

        public int? Edad { get; set; }

        [MaxLength(5)]
        public string? TipoSangre { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal? Estatura { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal? Peso { get; set; }
    }
}
