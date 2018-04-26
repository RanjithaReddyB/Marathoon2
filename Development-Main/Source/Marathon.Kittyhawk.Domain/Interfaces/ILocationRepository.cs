using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the location repository.
    /// </summary>
    public interface ILocationRepository : IRepository<Location>
    {
        Location GetBySRAID(int ID);
        Location GetByName(string name);
        Location GetByLocationUnitCode(string locationUnitCode);
		Location GetByDestinationLocationId(string destinationLocationId);
        Location GetByLocationUnitCodeOrDestinationLocationId(string code);
    }
}
