using System.Collections.Generic;

using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    public interface ISalesForecastRepository : IRepository<SalesForecast>
    {
        Marathon.Kittyhawk.Domain.DTO.SalesForecastSummary GetSalesForecastSummary(List<string> validTransportModes, List<string> invalidProductCodes);
        Marathon.Kittyhawk.Domain.DTO.SalesForecastSummary GetSalesForecastSummary(List<SalesForecast> salesForecast);
        List<SalesForecast> GetByErrorMessage(string message);
        List<SalesForecast> GetErroredRecords();
        List<SalesForecastError> GetErrors();        
        List<SalesForecast> GetSalesForecastforPublishing(List<string> validTransportModes, List<string> invalidProductCodes);
        void SetPublishStatus(List<SalesForecast> salesForecast);
        List<SalesForecast> GetRelatedSalesForecastRecords(SalesForecast forecast);
        List<SalesForecast> GetSalesForecastDataToPurge(int days);
    }
}
