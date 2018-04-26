using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the transport repository.
    /// </summary>
    public interface ITransportRepository : IRepository<Transport>
    {
        Transport GetByName(string name);
    }
}
