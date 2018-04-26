using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the order repository.
    /// </summary>
    public interface IOrderRepository : IRepository<Order>
    {
        Order GetByPlannedMovementKey(int plannedMovementKey);
    }
}
