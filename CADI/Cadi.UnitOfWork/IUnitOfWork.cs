using Cadi.Repositories;


namespace Cadi.UnitOfWork
{
    public interface IUnitOfWork
    {
        IAlumnoRepository Alumno { get; }
        IAsistenciaAlumnoRepository AsistenciaAlumno { get; }

        IGrupoDetailRepository GrupoDetail { get; }

        ITutorRepository Tutor { get; }
    }
}
