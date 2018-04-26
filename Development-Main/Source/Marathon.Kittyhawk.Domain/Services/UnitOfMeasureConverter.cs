using System;
using Marathon.Kittyhawk.Domain.Entities;

namespace Marathon.Kittyhawk.Domain.Services
{
    /// <summary>
    /// Static service class containing UnitOfMeasure helper methods.
    /// </summary>
    public static class UnitOfMeasureConverter
    {
        /// <summary>
        /// Converts the current value to gallons.  Starting unit must be specified.
        /// </summary>
        /// <param name="value">Current value</param>
        /// <param name="startingUnit">Starting unit</param>
        /// <returns>Value in gallons</returns>
        public static double ToGallons(this double value, string startingUnit)
        {
            switch (startingUnit)
            {
                case UnitOfMeasure.Barrels:
                    value = BarrelsToGallons(value);
                    break;
                case UnitOfMeasure.Tons:
                    value = TonsToGallons(value);
                    break;
                case UnitOfMeasure.Pounds:
                    value = PoundsToGallons(value);
                    break;
                case UnitOfMeasure.MMBTU:
                    value = MMBTUToGallons(value);
                    break;
                default:
                    break;
            }

            return value;
        }

        /// <summary>
        /// Converts the current value to barrels.  Starting unit must be specified.
        /// </summary>
        /// <param name="value">Current value</param>
        /// <param name="startingUnit">Starting unit</param>
        /// <returns>Value in barrels</returns>
        public static double ToBarrels(this double value, string startingUnit)
        {
            switch (startingUnit)
            {
                case UnitOfMeasure.Gallons:
                    value = GallonsToBarrels(value);
                    break;
                case UnitOfMeasure.Tons:
                    value = TonsToBarrels(value);
                    break;
                case UnitOfMeasure.Pounds:
                    value = PoundsToBarrels(value);
                    break;
                default:
                    break;
            }

            return value;
        }

        /// <summary>
        /// Converts the current value to tons.  Starting unit must be specified.
        /// </summary>
        /// <param name="value">Current value</param>
        /// <param name="startingUnit">Starting unit</param>
        /// <returns>Value in tons</returns>
        public static double ToTons(this double value, string startingUnit)
        {
            switch (startingUnit)
            {
                case UnitOfMeasure.Gallons:
                    value = GallonsToTons(value);
                    break;
                case UnitOfMeasure.Barrels:
                    value = BarrelsToTons(value);
                    break;
                case UnitOfMeasure.Pounds:
                    value = PoundsToTons(value);
                    break;
                default:
                    break;
            }

            return value;
        }

        /// <summary>
        /// Converts the current value to pounds.  Starting unit must be specified.
        /// </summary>
        /// <param name="value">Current value</param>
        /// <param name="startingUnit">Starting unit</param>
        /// <returns>Value in pounds</returns>
        public static double ToPounds(this double value, string startingUnit)
        {
            switch (startingUnit)
            {
                case UnitOfMeasure.Gallons:
                    value = GallonsToPounds(value);
                    break;
                case UnitOfMeasure.Barrels:
                    value = BarrelsToPounds(value);
                    break;
                case UnitOfMeasure.Tons:
                    value = TonsToPounds(value);
                    break;
                default:
                    break;
            }

            return value;
        }

        /// <summary>
        /// Converts the current value to MMBTU.  Starting unit must be specified.
        /// </summary>
        /// <param name="value">Current value</param>
        /// <param name="startingUnit">Starting unit</param>
        /// <returns>Value in MMBTU</returns>
        public static double ToMMBTU(this double value, string startingUnit)
        {
            switch (startingUnit)
            {
                case UnitOfMeasure.Gallons:
                    value = GallonsToMMBTU(value);
                    break;
                default:
                    break;
            }

            return value;
        }

        /// <summary>
        /// Converts from specific gravity to API gravity.
        /// </summary>
        /// <param name="gravity">Specific Gravity</param>
        /// <returns>API gravity</returns>
        public static double? ToAPIGravity(this double? gravity)
        {
            if (gravity == null)
                return null;

            return (141.5 / gravity.Value) - 131.5;
        }

        /// <summary>
        /// Converts from specific gravity to API gravity.
        /// </summary>
        /// <param name="gravity">Specific Gravity</param>
        /// <returns>API gravity</returns>
        public static double ToAPIGravity(this double gravity)
        {
            return (141.5 / gravity) - 131.5;
        }

        /// <summary>
        /// Converts from API gravity to specific gravity.
        /// </summary>
        /// <param name="gravity">API Gravity</param>
        /// <returns>Specific gravity</returns>
        public static double? ToSpecificGravity(this double? gravity)
        {
            if (gravity == null)
                return null;

           return 141.5 / (gravity.Value + 131.5);
        }

        /// <summary>
        /// Converts from API gravity to specific gravity.
        /// </summary>
        /// <param name="gravity">API Gravity</param>
        /// <returns>Specific gravity</returns>
        public static double ToSpecificGravity(this double gravity)
        {
            return 141.5 / (gravity + 131.5);
        }

        /// <summary>
        /// Convert gallons to barrels.
        /// </summary>
        /// <param name="gallons">Starting value</param>
        /// <returns>Converted value</returns>
        private static double GallonsToBarrels(double gallons)
        {
            return gallons / 42.0;
        }

        /// <summary>
        /// Convert barrels to gallons.
        /// </summary>
        /// <param name="barrels">Starting value</param>
        /// <returns>Converted value</returns>
        private static double BarrelsToGallons(double barrels)
        {
            return barrels * 42.0;
        }

        /// <summary>
        /// Convert gallons to tons.
        /// </summary>
        /// <param name="gallons">Starting value</param>
        /// <returns>Converted value</returns>
        private static double GallonsToTons(double gallons)
        {
            return gallons / 307.86;
        }

        /// <summary>
        /// Convert tons to gallons.
        /// </summary>
        /// <param name="tons">Starting value</param>
        /// <returns>Converted value</returns>
        private static double TonsToGallons(double tons)
        {
            return tons * 307.86;
        }

        /// <summary>
        /// Convert barrels to tons.
        /// </summary>
        /// <param name="barrels">Starting value</param>
        /// <returns>Converted value</returns>
        private static double BarrelsToTons(double barrels)
        {
            return barrels / 7.33;
        }

        /// <summary>
        /// Convert tons to barrels.
        /// </summary>
        /// <param name="tons">Starting value</param>
        /// <returns>Converted value</returns>
        private static double TonsToBarrels(double tons)
        {
            return tons * 7.33;
        }

        /// <summary>
        /// Convert pounds to tons.
        /// </summary>
        /// <param name="pounds">Starting value</param>
        /// <returns>Converted value</returns>
        private static double PoundsToTons(double pounds)
        {
            return pounds / 2000;
        }

        /// <summary>
        /// Convert tons to pounds.
        /// </summary>
        /// <param name="tons">Starting value</param>
        /// <returns>Converted value</returns>
        private static double TonsToPounds(double tons)
        {
            return tons * 2000;
        }

        /// <summary>
        /// Convert pounds to gallons.
        /// </summary>
        /// <param name="pounds">Starting value</param>
        /// <returns>Converted value</returns>
        private static double PoundsToGallons(double pounds)
        {
            return pounds / 8.345;
        }

        /// <summary>
        /// Convert gallons to pounds.
        /// </summary>
        /// <param name="gallons">Starting value</param>
        /// <returns>Converted value</returns>
        private static double GallonsToPounds(double gallons)
        {
            return gallons * 8.345;
        }

        /// <summary>
        /// Convert pounds to barrels.
        /// </summary>
        /// <param name="pounds">Starting value</param>
        /// <returns>Converted value</returns>
        private static double PoundsToBarrels(double pounds)
        {
            return pounds / 294;
        }

        /// <summary>
        /// Convert barrels to pounds.
        /// </summary>
        /// <param name="barrels">Starting value</param>
        /// <returns>Converted value</returns>
        private static double BarrelsToPounds(double barrels)
        {
            return barrels * 294;
        }

        /// <summary>
        /// Convert MMBTU to gallons.
        /// </summary>
        /// <param name="pounds">Starting value</param>
        /// <returns>Converted value</returns>
        private static double MMBTUToGallons(double MMBTU)
        {
            return MMBTU * 6.72;
        }

        /// <summary>
        /// Convert gallons to MMBTU.
        /// </summary>
        /// <param name="gallons">Starting value</param>
        /// <returns>Converted value</returns>
        private static double GallonsToMMBTU(double gallons)
        {
            return gallons / 6.72;
        }
    }
}
