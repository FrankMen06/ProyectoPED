using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedProyectoAvance.modelosBD
{
    [Table("Citas", Schema = "dbo")]
    public class Cita
    {
        [Key]
        public int CitaID { get; set; }

        public int PacienteID { get; set; }
        public int EmpleadoID { get; set; }
        public DateTime FechaHora { get; set; }
        public string Descripcion { get; set; }

        [ForeignKey("PacienteID")]
        public Pacientes? Paciente { get; set; }

        [ForeignKey("EmpleadoID")]
        public Empleados? Empleado { get; set; }


    }
}
