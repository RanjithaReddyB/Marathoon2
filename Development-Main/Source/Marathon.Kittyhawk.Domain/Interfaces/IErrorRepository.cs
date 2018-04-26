using System;
using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the error repository.
    /// </summary>
    public interface IErrorRepository : IRepository<Error>
    {
        List<Error> GetByDateRange(DateTime start, DateTime? end);
        List<Error> GetToPurge();
    }
}
