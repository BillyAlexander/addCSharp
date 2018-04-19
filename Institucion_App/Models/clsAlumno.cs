using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion_App.Models
{
    class clsAlumno : clsPersona
    {
        public string email { get; set; }
        public string nickname { get; set; }

        public override string construir_resumen()
        {
            return $"{nombre},{nickname}";
        }
    }
}
