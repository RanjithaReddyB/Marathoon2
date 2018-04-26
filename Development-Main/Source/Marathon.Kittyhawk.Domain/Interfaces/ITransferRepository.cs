using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the transfer repository.
    /// </summary>
    public interface ITransferRepository : IRepository<Transfer>
    {
        Transfer GetByPlannedTransferKey(int plannedTransferKey);
    }
}
