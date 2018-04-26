using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Interfaces
{
    public interface ISalesForecastHistoryRepository:IRepository<SalesForecastHistory>
    {
        List<SalesForecastHistory> GetAll(int? numberOfRecords);
        List<SalesForecastHistory> GetSalesForecastHistoryDataToPurge(int days);

    }
}
