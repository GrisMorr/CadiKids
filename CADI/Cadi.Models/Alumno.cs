using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Cadi.Models
{
    
    public class alumno
    {
       
        [ExplicitKey]
        public string idalumno { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public DateTime? fechaNacimiento { get; set; }
        public string foto { get; set; }
        public int pago { get; set; }
        public int estado { get; set; }

    }
}
