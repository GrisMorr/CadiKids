using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadi.Models
{
    public class GrupoDetail
    {
        [ExplicitKey]
        public int idMateria { get; set; }
        public string nombre { get; set; }
        public string InicioMateria { get; set; }
        public string FinMateria { get; set; }

    }
}
