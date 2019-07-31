using Cadi.Models;
using Cadi.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadi.DataAccess
{
    public class TutorRepository : Repository<Tutor, string>, ITutorRepository
    {
        public TutorRepository(string connectionString) : base(connectionString)
        {
        }
    }
}
