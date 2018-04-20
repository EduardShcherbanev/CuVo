using System;
using System.Collections.Generic;
using System.Text;
using CustomVocabulary.Data;

namespace DBRepository.Interfaces
{
    public interface IRepositoryContextFactory
    {
        ApplicationDbContext CreateDbContext(string connectionString);
    }
}
