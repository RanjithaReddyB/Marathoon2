using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the IBEX transaction history repository.
    /// </summary>
    public interface IIBEXTransactionHistoryRepository : IRepository<IBEXTransactionHistory>
    {
        List<IBEXTransactionHistory> GetAll(int? numberOfRecords);
        List<IBEXTransactionHistory> GetByBusinessMonth(string businessMonth, bool? isSales, List<string> controlCodes);
        List<IBEXTransactionHistory> GetToPurge(int years);
        List<IBEXTransactionHistory> GetByParams(string commodity, string rptLoc, string refLoc,
            List<string> controlCodes, int? numberOfRecords);
    }
}
