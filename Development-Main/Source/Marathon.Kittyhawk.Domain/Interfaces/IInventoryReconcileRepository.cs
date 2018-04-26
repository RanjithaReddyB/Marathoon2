using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the inventory reconcile repository.
    /// </summary>
    public interface IInventoryReconcileRepository : IRepository<InventoryReconcile>
    {
        InventoryReconcile GetByInventoryReconcileKey(int inventoryReconcileKey);
    }
}
