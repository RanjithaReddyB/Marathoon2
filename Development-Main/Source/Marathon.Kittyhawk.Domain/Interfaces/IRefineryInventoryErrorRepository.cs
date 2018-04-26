using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the refinery inventory error repository.
    /// </summary>
    public interface IRefineryInventoryErrorRepository : IRepository<RefineryInventoryError>
    {
        List<RefineryInventoryError> GetByProcessID(string processID);
        List<RefineryInventoryError> GetToPurge();
    }
}
