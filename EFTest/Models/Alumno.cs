using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFTest.Models
{
    [Table("Alumnos")]
    public class Alumno
    {
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string Nombres { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Apellidos { get; set; }

    }
}