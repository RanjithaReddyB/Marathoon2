using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon.Kittyhawk.Domain.DTO
{

    /// <summary>
    /// SalesForecast DTO class representing the List<forecast summary> object  used for sending the forecast data to SAP PI service
    /// </summary>
    public class SalesForecastSummary
    {
        public List<SalesForecast> SalesForecast { get; set; }       
        
    }
}
