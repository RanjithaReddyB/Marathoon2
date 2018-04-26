using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the movement transaction value repository.
    /// </summary>
    public interface IMovementTransactionValueRepository : IRepository<MovementTransactionValue>
    {
        MovementTransactionValue GetByTransactionDetailKey(int transactionDetailKey);
    }
}
