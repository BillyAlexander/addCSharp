using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Institucion_App.Models
{
    public abstract class clsPersona
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public short edad { get; set; }
        public string telefono { get; set; }
        public static int contador_personas = 0;

        static clsPersona()
        {
            contador_personas++;
        }

        public string nombre_completo
        {
            //get { return nombre + " " + apellido; }
            //get { return string.Format("{0} {1}", nombre, apellido); }
            get { return $"{nombre} {apellido}"; }
        }

        public abstract string construir_resumen();
    }
}
