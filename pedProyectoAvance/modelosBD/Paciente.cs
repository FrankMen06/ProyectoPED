using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedProyectoAvance.modelosBD;
[Table("Pacientes", Schema = "dbo")]

public class Paciente
{
    [Key]
    public int PacienteID { get; set; }
    public string DUI{ get; set;}
    public string NombreCompleto{ get; set;}
    public string Telefono{ get; set;}
    public string Sexo{ get; set;}
    public int Edad{ get; set;}
    public int TipoSangre { get; set;}
    public decimal Estatura { get; set;}
    public decimal Peso { get; set;}
}

