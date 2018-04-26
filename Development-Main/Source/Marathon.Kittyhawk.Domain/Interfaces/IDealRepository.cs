using Marathon.Kittyhawk.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    /// <summary>
    /// Interface for the deal repository.
    /// </summary>
    public interface IDealRepository : IRepository<Deal>
    {
        List<Guid?> GetTheirCompanyIdsByTemplateProductAndLocation(string template, string status, Guid? productId, Guid? locationId, DateTime? transferDate);
        List<Guid?> GetTheirCompanyIdsByTemplatesProductAndLocation(string template1, string template2, string status, Guid? productId, Guid? locationId, DateTime? transferDate);
        List<Deal> GetByTemplateProductLocationAndSupplyDemand(string template, string status, Guid? productId, Guid? locationId, string supplyDemand, DateTime? transferDate);
        List<Deal> GetByTemplateCompanyProductLocationAndSupplyDemand(string template, string status, Guid? theirCompanyId, Guid? productId, Guid? locationId, DateTime? transferDate, string supplyDemand);
        List<Deal> GetByTemplateCompanyProductOriginDestinationAndTransportMethod(string template, string status, Guid? theirComapanyId, Guid? productId, Guid? originId, Guid? destinationId, string transportType, DateTime? transferDate);
        Deal GetByDealHeaderKeyAndDealDetailKey(int dealHeaderKey, int dealDetailKey);
        Deal GetByDealDetailID(int dealDetailID);
    }
}
