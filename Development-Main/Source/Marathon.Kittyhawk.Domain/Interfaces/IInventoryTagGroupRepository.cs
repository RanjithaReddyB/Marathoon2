using System.Collections.Generic;
using System.Linq;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the inventory tag group repository.
    /// </summary>
    public interface IInventoryTagGroupRepository : IRepository<InventoryTagGroup>
    {
        List<InventoryTagGroup> GetByDataSource(string dataSourceName);
    }
}
