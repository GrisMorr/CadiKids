using Cadi.Models;
using Cadi.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cadi.DataAccess
{
    public class GrupoDetailRepository : Repository<GrupoDetail, int>, IGrupoDetailRepository
    {
        public GrupoDetailRepository(string connectionString) : base(connectionString)
        {
        }
    }
}
