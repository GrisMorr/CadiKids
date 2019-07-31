using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadi.Models
{
    public class asistenciaAlumnoD
    {
        [ExplicitKey]
        public string idalumno { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }

        public string fechaNacimiento { get; set; }

        public string foto { get; set; }

        public int pago { get; set; }
        public int idMateria { get; set; }
        public string nombreMateria { get; set; }
      
        public string inicioMateria { get; set; }
       
        public int asistenciaHoy { get; set; }

    }
}
