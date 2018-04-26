using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the time transaction repository.
    /// </summary>
    public interface ITimeTransactionRepository : IRepository<TimeTransaction>
    {
        TimeTransaction GetByTimeTransactionKeyAndTimeTransactionLogKey(int timeTransactionKey, int? timeTransactionLogKey);
    }
}
