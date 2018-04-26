using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the movement expense repository.
    /// </summary>
    public interface IMovementExpenseRepository : IRepository<MovementExpense>
    {
        MovementExpense GetByMovementExpenseKeyAndMovementExpenseLogKey(int movementExpenseKey, int? movementExpenseLogKey);
    }
}
