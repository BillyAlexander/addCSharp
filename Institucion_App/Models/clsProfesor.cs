using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion_App.Models
{
    class clsProfesor : clsPersona
    {
        public string materia { get; set; }

        public override string construir_resumen()
        {
            return $"{nombre},{materia},{edad}";
        }
    }
}
