using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;
using System;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the chemical repository.
    /// </summary>
    public interface IChemicalRepository : IRepository<Chemical>
    {
        List<Chemical> GetByProductId(Guid? productId);
    }
}