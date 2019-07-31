using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadi.Models
{
    public class Tutor
    {
        [ExplicitKey]
        public string IdTutor { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Foto { get; set; }
        public string Direccion { get; set; }
    }
}
