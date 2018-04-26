using System;
using System.Collections.Generic;
using System.Linq;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the activity repository.
    /// </summary>
    public interface IActivityRepository : IRepository<Activity>
    {
        Activity GetLastRun(string dataSourceName);
        List<Activity> GetByDataSource(string dataSourceName, string activityType);
        List<Activity> GetByDateRange(DateTime start, DateTime? end);
        List<Activity> GetRecentActivity(string type);
        Dictionary<DateTime, Tuple<int, double>> GetRecordsAddedOverTime(
            DateTime startDate, string dataType, string sourceName, string sourceSystem);
        List<Activity> GetToPurge();
    }
}
