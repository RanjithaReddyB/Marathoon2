using System;
using System.Collections.Generic;
using System.Linq;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the inventory history repository.
    /// </summary>
    public interface IInventoryHistoryRepository : IRepository<InventoryHistory>
    {
        List<InventoryHistory> GetAll(int? numberOfRecords);
        List<InventoryHistory> GetByDataSource(string source, int? daysOfHistory);
        List<InventoryHistory> GetByMeasurementDate(DateTime start, DateTime end);
        List<InventoryHistory> GetToPurge(int years);
        List<InventoryHistory> GetByParams(string source, string facility, string company, string commodity,
            string product, DateTime? start, DateTime? end, int? numberOfRecords);
    }
}
