using System;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the movement transaction repository.
    /// </summary>
    public interface IMovementTransactionRepository : IRepository<MovementTransaction>
    {
        MovementTransaction GetByTransactionHeaderKeyAndChildProduct(int transactionHeaderKey, Guid? childProduct);
    }
}
