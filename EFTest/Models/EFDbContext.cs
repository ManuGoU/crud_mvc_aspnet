using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFTest.Models
{
    public class EFDbContext:DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
    }
}