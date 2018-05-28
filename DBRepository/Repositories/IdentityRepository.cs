using System;
using System.Collections.Generic;
using System.Text;
using CuVo.DBRepository.Interfaces;

namespace CuVo.DBRepository.Repositories
{
    public class IdentityRepository : BaseRepository, IIdentityRepository
    {
        public IdentityRepository(string connectionString, IRepositoryContextFactory contextFactory) : base(
            connectionString, contextFactory)
        {
        }
    }
}
