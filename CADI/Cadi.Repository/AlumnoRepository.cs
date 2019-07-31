using Cadi.Models;
using Cadi.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadi.DataAccess
{
    public class AlumnoRepository : Repository<alumno, string>, IAlumnoRepository
    {
        public AlumnoRepository(string connectionString) : base(connectionString)
        {
        }
    }
       
}
