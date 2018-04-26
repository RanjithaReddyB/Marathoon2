using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the month-end inventory repository.
    /// </summary>
    public interface IMonthEndInventoryRepository : IRepository<MonthEndInventory>
    {
        MonthEndInventory GetByInventorySubledgerKey(int inventorySubledgerKey);
    }
}
