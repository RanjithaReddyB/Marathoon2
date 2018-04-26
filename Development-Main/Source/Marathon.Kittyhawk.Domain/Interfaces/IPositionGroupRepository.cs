using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the position group repository.
    /// </summary>
    public interface IPositionGroupRepository : IRepository<PositionGroup>
    {
        PositionGroup GetBySRAID(int ID);
        List<PositionGroup> GetAll(bool loadRelationships);
    }
}
