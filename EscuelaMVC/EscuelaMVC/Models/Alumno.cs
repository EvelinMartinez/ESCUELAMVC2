using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EscuelaMVC.Models
{
    [Table("Alumnos")]
    public class Alumno
    {
        [Key]
        public int pkAlumno { get; set; }

        [Required(ErrorMessage ="Se requiere el noombre del alumno")]
        public string sNombre { get; set; }

        [Required(ErrorMessage ="Se requiere Apellido del Alumno")]
        public string sApellido { get; set; }

        [Required(ErrorMessage = "Se requiere Grupo del Alumno")]
        public string sGrupo { get; set; }

        public string sImagen { get; set; }

        public Boolean bStatus { get; set; }

        public Alumno()
        {
            this.bStatus = true;
        }

    }
}