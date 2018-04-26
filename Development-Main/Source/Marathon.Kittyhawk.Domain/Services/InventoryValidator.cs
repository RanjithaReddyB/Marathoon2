using System;
using System.Collections.Generic;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Services
{
    /// <summary>
    /// Static service class that contains validation logic for inventories.
    /// </summary>
    public static class InventoryValidator
    {
        /// <summary>
        /// Validates a single inventory entity.
        /// </summary>
        /// <param name="entity">Inventory</param>
        /// <returns>Validated inventory</returns>
        public static Inventory Validate(this Inventory entity)
        {
            if (entity.GrossQuantity != null)
                entity.GrossQuantity = Math.Round(entity.GrossQuantity.Value, 2);
            if (entity.NetQuantity != null)
                entity.NetQuantity = Math.Round(entity.NetQuantity.Value, 2);
            if (entity.Temperature != null)
                entity.Temperature = Math.Round(entity.Temperature.Value, 2);
            if (entity.Gravity != null)
                entity.Gravity = Math.Round(entity.Gravity.Value, 2);
            if (entity.Level != null)
                entity.Level = Math.Round(entity.Level.Value, 2);
            if (entity.RemainingFill != null)
                entity.RemainingFill = Math.Round(entity.RemainingFill.Value, 2);
            if (entity.AvailableQuantity != null)
                entity.AvailableQuantity = Math.Round(entity.AvailableQuantity.Value, 2);
            if (entity.Flow != null)
                entity.Flow = Math.Round(entity.Flow.Value, 2);
            if (entity.FlowTimeSpan != null)
                entity.FlowTimeSpan = Math.Round(entity.FlowTimeSpan.Value, 2);
            if (entity.RVP != null)
                entity.RVP = Math.Round(entity.RVP.Value, 2);
            if (entity.Ethanol != null)
                entity.Ethanol = Math.Round(entity.Ethanol.Value, 2);
            if (entity.Viscosity != null)
                entity.Viscosity = Math.Round(entity.Viscosity.Value, 2);

            return entity;
        }

        /// <summary>
        /// Validates a collection of inventory entites.
        /// </summary>
        /// <param name="entites">Inventories</param>
        /// <returns>Validated inventories</returns>
        public static List<Inventory> Validate(this List<Inventory> entites)
        {
            foreach (var entity in entites)
            {
                entity.Validate();
            }

            return entites;
        }
    }
}
