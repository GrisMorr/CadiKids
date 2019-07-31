using Cadi.Models;
using Cadi.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadi.DataAccess
{
    public class AsistenciaAlumnoRepository : Repository<asistenciaAlumnoD, string>, IAsistenciaAlumnoRepository
    {
        public AsistenciaAlumnoRepository(string connectionString) : base(connectionString)
        {
        }
    }
}
