using System;
using System.Collections.Generic;
using System.Linq;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the transaction Upload history repository.
    /// </summary>
    public interface ITransactionUploadHistoryRepository : IRepository<TransactionUploadHistory>
    {
        List<TransactionUploadHistory> GetAll(int? numberOfRecords);
        List<TransactionUploadHistory> GetByTransferDate(DateTime start, DateTime end);
        List<TransactionUploadHistory> GetToPurge(int years);
    }
}
