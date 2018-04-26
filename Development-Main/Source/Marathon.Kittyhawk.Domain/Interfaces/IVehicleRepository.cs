using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the vehicle repository.
    /// </summary>
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        Vehicle GetBySRAID(int ID);
        Vehicle GetByName(string name);
    }
}
