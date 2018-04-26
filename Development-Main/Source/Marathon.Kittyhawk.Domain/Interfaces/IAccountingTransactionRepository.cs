using Marathon.Kittyhawk.Domain.Entities;
using System;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the accounting transaction repository.
    /// </summary>
    public interface IAccountingTransactionRepository : IRepository<AccountingTransaction>
    {
        AccountingTransaction GetByAccountDetailKeyAccountCodeKeyAccountCodeLogKeyAndChildProduct(int accountDetailKey, int? accountCodeKey, int? accountCodeLogKey, Guid? childProduct);
    }
}
