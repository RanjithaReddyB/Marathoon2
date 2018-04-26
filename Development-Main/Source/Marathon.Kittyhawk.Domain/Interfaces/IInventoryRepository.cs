using System;
using System.Collections.Generic;
using System.Linq;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the inventory repository.
    /// </summary>
    public interface IInventoryRepository : IRepository<Inventory>
    {
        List<Inventory> GetAll(int? numberOfRecords);
        List<Inventory> GetByDataSource(string source, int? daysOfHistory);
        List<Inventory> GetUnpublished(string source);
        List<Inventory> GetByMeasurementDate(DateTime start, DateTime end);
        List<Inventory> GetMoveToHistory(int days);
        List<Inventory> GetByErrorMessage(string source, string message);
        List<Inventory> GetByParams(string source, string facility, string company, string commodity,
            string product, DateTime? start, DateTime? end, int? numberOfRecords);
        List<InventoryError> GetErrors(string source, string commodity);
    }
}
