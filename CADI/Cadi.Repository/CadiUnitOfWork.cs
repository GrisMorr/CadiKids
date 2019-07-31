using Cadi.Models;
using Cadi.Repositories;
using Cadi.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadi.DataAccess
{
    public class CadiUnitOfWork : IUnitOfWork
    {
        public CadiUnitOfWork(string connectionString)
        {
            Alumno = new AlumnoRepository(connectionString);
            AsistenciaAlumno = new AsistenciaAlumnoRepository(connectionString);
            GrupoDetail = new GrupoDetailRepository(connectionString);
            Tutor = new TutorRepository(connectionString);
        }

        public IAlumnoRepository Alumno { get; private set; }
        public IAsistenciaAlumnoRepository AsistenciaAlumno { get; private set; }

        public IGrupoDetailRepository GrupoDetail { get; private set; }

        public ITutorRepository Tutor { get; private set; }
    }
}
