using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the IBEX transaction repository.
    /// </summary>
    public interface IIBEXTransactionRepository : IRepository<IBEXTransaction>
    {
        List<IBEXTransaction> GetAll(int? numberOfRecords);
        List<IBEXTransaction> GetUnpublished();
        List<IBEXTransaction> GetErroredRecords();
        List<IBEXTransaction> GetRecentInventories();
        List<IBEXTransaction> GetByBusinessMonth(string businessMonth, bool? isSales, List<string> controlCodes);
        List<IBEXTransaction> GetMoveToHistory();
        List<IBEXTransaction> GetByErrorMessage(string message);
        List<IBEXTransaction> GetByParams(string commodity, string rptLoc, string refLoc,
            List<string> controlCodes, int? numberOfRecords);
        List<IBEXTransactionError> GetErrors();
    }
}
