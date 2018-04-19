using Institucion_App.Models;
using System.Data.Entity;

namespace Institucion_App.DataAccess
{
    class clsInstitucionDB: DbContext
    {
        public DbSet<clsProfesor> profesores { get; set; }
        public DbSet<clsAlumno> alumnos { get; set; }
    }
}
