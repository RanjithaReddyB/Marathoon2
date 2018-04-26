using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the inventory subledger repository.
    /// </summary>
    public interface IInventorySubledgerRepository : IRepository<InventorySubledger>
    {
        InventorySubledger GetByInventorySubledgerKey(int inventorySubledgerKey);
    }
}
