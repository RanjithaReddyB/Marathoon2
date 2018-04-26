using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the unit of measure repository.
    /// </summary>
    public interface IUnitofMeasureRepository : IRepository<UnitofMeasure>
    {
        UnitofMeasure GetByName(string name);
    }
}

