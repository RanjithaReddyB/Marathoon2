using System;
using System.Collections.Generic;
using System.Linq;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the bulk transfer repository.
    /// </summary>
    public interface IBulkTransferRepository : IRepository<BulkTransfer>
    {
        List<BulkTransfer> GetAll(int? numberOfRecords);
        List<BulkTransfer> GetByDataSource(string source, string activityIndicator, int? daysOfHistory);
        List<BulkTransfer> GetUnpublished(string source);
        List<BulkTransfer> GetByTransferDate(DateTime start, DateTime end);
        List<BulkTransfer> GetRailTracMoveToHistory(int days);
        List<BulkTransfer> GetNonRailTracMoveToHistory(int days);
        List<BulkTransfer> GetByErrorMessage(string source, string message);
        List<BulkTransfer> GetByParams(string source, string facility, string origin, string destination,
            string commodity, string product, string customer, string supplier, string shipper,
            string carrier, DateTime? minTransferStart, DateTime? maxTransferEnd, int? numberOfRecords);
        List<BulkTransferError> GetErrors(string source, string commodity);
    }
}
