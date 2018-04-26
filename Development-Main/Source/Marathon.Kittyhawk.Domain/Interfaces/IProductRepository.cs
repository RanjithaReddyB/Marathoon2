using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the product repository.
    /// </summary>
    public interface IProductRepository : IRepository<Product>
    {
        Product GetBySRAID(int ID);
        Product GetByName(string name);
        Product GetByAbbreviation(string abbreviation);
        Product GetByRefinedCommodityCode(string refinedCommodityCode);
    }
}
