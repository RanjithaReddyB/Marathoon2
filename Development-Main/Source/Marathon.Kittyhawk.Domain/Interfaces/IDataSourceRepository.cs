using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the data source repository.
    /// </summary>
    public interface IDataSourceRepository : IRepository<DataSource>
    {
        DataSource GetByName(string name);
    }
}
