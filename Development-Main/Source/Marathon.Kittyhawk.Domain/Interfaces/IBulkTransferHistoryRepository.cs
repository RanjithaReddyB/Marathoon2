using System;
using System.Collections.Generic;
using System.Linq;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the bulk transfer history repository.
    /// </summary>
    public interface IBulkTransferHistoryRepository : IRepository<BulkTransferHistory>
    {
        List<BulkTransferHistory> GetAll(int? numberOfRecords);
        List<BulkTransferHistory> GetByDataSource(string source, string activityIndicator, int? daysOfHistory);
        List<BulkTransferHistory> GetByTransferDate(DateTime start, DateTime end);
        List<BulkTransferHistory> GetToPurge(int years);
        List<BulkTransferHistory> GetByParams(string source, string facility, string origin, string destination,
            string commodity, string product, string customer, string supplier, string shipper,
            string carrier, DateTime? minTransferStart, DateTime? maxTransferEnd, int? numberOfRecords);
    }
}
