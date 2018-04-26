using System;
using System.Collections.Generic;
using System.Linq;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the container repository.
    /// </summary>
    public interface IContainerRepository : IRepository<Container>
    {
        Container GetByName(string name);
        List<Container> GetByLocation(Guid locationID);
    }
}
