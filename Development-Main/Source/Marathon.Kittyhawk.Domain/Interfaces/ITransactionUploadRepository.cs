using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    public interface ITransactionUploadRepository : IRepository<TransactionUpload>
    {
        List<TransactionUpload> GetAll(int? numberOfRecords);
        List<TransactionUpload> GetByDataSource(string source, string activityIndicator, int? daysOfHistory);
        TransactionUpload GetUnpublished(Guid transactionUploadId);
        List<TransactionUpload> GetByTransferDate(DateTime start, DateTime end);
        List<TransactionUpload> GetByErrorMessage(string source, string message);
        List<TransactionUpload> GetByParams(string source, string facility, string origin, string destination,
            string commodity, string product, string customer, string supplier, string shipper,
            string carrier, DateTime? minTransferStart, DateTime? maxTransferEnd, int? numberOfRecords);
        List<TransactionUploadError> GetErrors(string source, string commodity);
        TransactionUpload GetByTransSeqNo(string transSeqNo);
        List<TransactionUpload> GetMoveToHistory(int days);
        List<TransactionUpload> GetByGroupId(Guid? transactionUploadGroupId);
    }
}
