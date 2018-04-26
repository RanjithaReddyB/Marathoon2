using System;
using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Services
{
    /// <summary>
    /// Static service class that contains validation logic for bulk transfers.
    /// </summary>
    public static class BulkTransferValidator
    {
        /// <summary>
        /// Validates a single bulk transfer entity.
        /// </summary>
        /// <param name="entity">Bulk transfer</param>
        /// <returns>Validated bulk transfer</returns>
        public static BulkTransfer Validate(this BulkTransfer entity)
        {
            if (entity.ScheduledQuantity != null)
                entity.ScheduledQuantity = Math.Round(entity.ScheduledQuantity.Value, 2);
            if (entity.GrossQuantity != null)
                entity.GrossQuantity = Math.Round(entity.GrossQuantity.Value, 2);
            if (entity.NetQuantity != null)
                entity.NetQuantity = Math.Round(entity.NetQuantity.Value, 2);
            if (entity.Temperature != null)
                entity.Temperature = Math.Round(entity.Temperature.Value, 2);
            if (entity.RVP != null)
                entity.RVP = Math.Round(entity.RVP.Value, 2);

            if (entity.TransferStart != null && entity.TransferEnd != null)
            {
                if (entity.TransferStart.Value > entity.TransferEnd.Value)
                {
                    entity.IsDirty = true;
                    entity.ErrorStatus += "Transfer start date is after transfer end date;";
                }
            }

            if (entity.TransportType == null)
            {
                entity.IsDirty = true;
                entity.ErrorStatus += "No transport type was provided;";
            }

            if (entity.GrossQuantity != null && entity.NetQuantity != null)
            {
                if ((entity.GrossQuantity.Value > 0 && entity.NetQuantity.Value < 0) ||
                    (entity.GrossQuantity.Value < 0 && entity.NetQuantity.Value > 0))
                {
                    entity.ErrorStatus += "Sign for gross and net quantity does not match;";
                }
            }

            return entity;
        }

        /// <summary>
        /// Validates a collection of bulk transfer entites.
        /// </summary>
        /// <param name="entites">Bulk transfers</param>
        /// <returns>Validated bulk transfers</returns>
        public static List<BulkTransfer> Validate(this List<BulkTransfer> entites)
        {
            foreach (var entity in entites)
            {
                entity.Validate();
            }

            return entites;
        }
    }
}
