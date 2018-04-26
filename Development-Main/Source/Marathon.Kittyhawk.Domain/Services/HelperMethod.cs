using Marathon.Kittyhawk.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Marathon.Kittyhawk.Domain.Services
{
    public static class HelperMethod
    {
        /// <summary>
        /// Calculates the net quantity delta between the last reading and the current reading.
        /// </summary>
        /// <param name="current">Current reading</param>
        /// <param name="last">Last reading</param>
        /// <returns>Net quantity difference, or null</returns>
        public static double? GetFlow(Entities.Inventory current, Entities.Inventory last)
        {
            if (current == null || last == null)
                return null;
            else if (current.NetQuantity == null || last.NetQuantity == null)
                return null;
            else
                return current.NetQuantity.Value - last.NetQuantity.Value;
        }

        /// <summary>
        /// Calculates the measurement timespan (in hours) between the last reading and the current reading.
        /// </summary>
        /// <param name="current">Current reading</param>
        /// <param name="last">Last reading</param>
        /// <returns>Measurement timespan, or null</returns>
        public static double? GetFlowTimeSpan(Entities.Inventory current, Entities.Inventory last, string dataSource = null)
        {
            if (current == null || last == null)
                return null;
            else if (current.MeasurementDateTime == null || last.MeasurementDateTime == null)
                return null;
            else
            {
                if (dataSource == null)
                    return Math.Round((current.MeasurementDateTime.Value - last.MeasurementDateTime.Value).TotalHours);
                else
                    return Math.Round((current.MeasurementDateTime.Value - last.MeasurementDateTime.Value).TotalHours,2);
            }
                
        }

        /// <summary>
        /// Gets the match status value based on the rules set in the Match Status table
        /// </summary>
        /// <param name="sortedMatchStatusList">Match status list sorted by row number</param>
        /// <param name="commodity">Commodity</param>
        /// <param name="productId">Product Id</param>
        /// <param name="facilityId">Facility Id</param>
        /// <param name="originId">Origin Id</param>
        /// <param name="destinationId">Destination Id</param>
        /// <param name="locationTypes">Location types</param>
        /// <param name="originLocationTypes">Origin location types</param>
        /// <param name="destinationLocationTypes">Destination Location types</param>
        /// <param name="issuedById">Issued By Id</param>
        /// <param name="supplierId">Supplier Id</param>
        /// <param name="customerId">Customer Id</param>
        /// <param name="carrierId">Carrier Id</param>
        /// <param name="movementType">Movement Type</param>
        /// <returns>Match Status</returns>
        public static string GetMatchStatus(List<MatchStatus> sortedMatchStatusList, string commodity, Guid? productId, Guid? facilityId, Guid? originId,
                                     Guid? destinationId, string locationTypes, string originLocationTypes,
                                     string destinationLocationTypes, Guid? issuedById, Guid? supplierId,
                                     Guid? customerId, Guid? carrierId, string movementType)
        {
            foreach (var matchStatus in sortedMatchStatusList)
            {
                if ((matchStatus.Commodity == null || matchStatus.Commodity == commodity) &&
                    (matchStatus.ProductId == null || matchStatus.ProductId == productId) &&
                    (matchStatus.FacilityId == null || matchStatus.FacilityId == facilityId) &&
                    (matchStatus.OriginId == null || matchStatus.OriginId == originId) &&
                    (matchStatus.DestinationId == null || matchStatus.DestinationId == destinationId) &&
                    (matchStatus.LocationType == null || locationTypes.Contains(matchStatus.LocationType)) &&
                    (matchStatus.OriginLocationType == null || originLocationTypes.Contains(matchStatus.OriginLocationType)) &&
                    (matchStatus.DestinationLocationType == null || destinationLocationTypes.Contains(matchStatus.DestinationLocationType)) &&
                    (matchStatus.IssuedById == null || matchStatus.IssuedById == issuedById) &&
                    (matchStatus.SupplierId == null || matchStatus.SupplierId == supplierId) &&
                    (matchStatus.CustomerId == null || matchStatus.CustomerId == customerId) &&
                    (matchStatus.CarrierId == null || matchStatus.CarrierId == carrierId) &&
                    (matchStatus.MovementType == null || matchStatus.MovementType == movementType))
                {
                    return matchStatus.Status;
                }
            }
            return string.Empty;
        }
    }
}
