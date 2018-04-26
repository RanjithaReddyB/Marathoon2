using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the transfer value repository.
    /// </summary>
    public interface ITransferValueRepository : IRepository<TransferValue>
    {
        TransferValue GetByPlannedTransferValueKey(int plannedTransferValueKey);
    }
}
