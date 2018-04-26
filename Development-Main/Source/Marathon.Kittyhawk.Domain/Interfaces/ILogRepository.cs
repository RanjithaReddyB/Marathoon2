using System;
using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the log repository.
    /// </summary>
    public interface ILogRepository : IRepository<Log>
    {
        List<Log> GetByDateRange(DateTime start, DateTime? end);
        List<Log> GetToPurge();
        Dictionary<DateTime, Tuple<int, double, double>> GetSummaryLogData(
            string type, string level, DateTime start, DateTime end);
    }
}
