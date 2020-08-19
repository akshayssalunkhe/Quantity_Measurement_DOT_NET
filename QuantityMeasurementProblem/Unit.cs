/// <summary>
/// Quantity measurement problem.
/// </summary>
namespace QuantityMeasurementProblem
    {
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// unit class.
    /// </summary>
    public class Unit
        {
            /// <summary>
            /// Enum For unit type.
            /// </summary>
            public enum UnitType
            {
                /// <summary>
                /// Enum for feet to inch conversion.
                /// </summary>
                FEET_TO_INCH,

                /// <summary>
                /// Enum for inch to feet conversion.
                /// </summary>
                INCH_TO_FEET,

                /// <summary>
                /// Enum for feet to yard conversion.
                /// </summary>
                FEET_TO_YARD,

                /// <summary>
                /// Enum for inch to yard conversion.
                ///  </summary>
                INCH_TO_YARD,

                /// <summary>
                /// Enum for yard to inch conversion.
                /// </summary>
                YARD_TO_INCH,

                /// <summary>
                /// Enum for yard to feet conversion.
                /// </summary>
                YARD_TO_FEET,

                /// <summary>
                /// Enum for inch to centimeter conversion.
                /// </summary>
                INCH_TO_CENTIMETER,

                /// <summary>
                /// Enum for feet unit type.
                /// </summary>
                FEET,

                /// <summary>
                /// Enum for inch unit type.
                /// </summary>
                INCH,

                /// <summary>
                /// Enum for gallon to litres.
                /// </summary>
                GALLON_TO_LITRES,

                /// <summary>
                /// Enum for gallon.
                /// </summary>
                GALLON,

               /// <summary>
               /// Enum for litres.
               /// </summary>
                LITRE,

               /// <summary>
               /// Enum for litres.
               /// </summary>
                LITRE_TO_GALLON,

               /// <summary>
               /// Enum for litre to millilitre conversion.
               /// </summary>
                LITRE_TO_MILLILITRE,

               /// <summary>
               /// Enum for millilitre to litre conversion.
               /// </summary>
                MILLILITRE_TO_LITRE,

                /// <summary>
                /// Enum for kilogram to gram conversion.
                /// </summary>
                KILOGRAM_TO_GRAM,

                /// <summary>
                /// Enum for tonne to kilogram conversion.
                /// </summary>
                TONNE_TO_KILOGRAM,

                /// <summary>
                /// Enum for gram to kilogram conversion.
                /// </summary>
                GRAM_TO_KILOGRAM,

                /// <summary>
                /// Enum for celsius unit type.
                /// </summary>
                CELSIUS,

               /// <summary>
               /// Enum for celsius unit type.
               /// </summary>
                FAHRENHEIT,
        }

        /// <summary>
        /// Function to get value of enum.
        /// </summary>
        /// <param name=unitType>
        /// <returns> converted value.</returns></param>
        /// <returns> selected unit conversion</returns>
            public double GetValue(UnitType unitType)
            {
                return unitType switch
                {
                    UnitType.FEET_TO_INCH => 1 * 12.0,
                    UnitType.INCH_TO_FEET => 1 / 12.0,
                    UnitType.FEET_TO_YARD => 1 / 3.0,
                    UnitType.INCH_TO_YARD => 1 / 36.0,
                    UnitType.YARD_TO_INCH => 1 * 36.0,
                    UnitType.YARD_TO_FEET => 1 * 3.0,
                    UnitType.INCH_TO_CENTIMETER => 1 * 2.5,
                    UnitType.FEET => 1.0,
                    UnitType.INCH => 1.0,
                    UnitType.GALLON => 1.0,
                    UnitType.LITRE => 1.0,
                    UnitType.GALLON_TO_LITRES => 1 * 3.78,
                    UnitType.LITRE_TO_GALLON => 1 / 3.78,
                    UnitType.LITRE_TO_MILLILITRE => 1 * 1000.0,
                    UnitType.MILLILITRE_TO_LITRE => 1 / 1000.0,
                    UnitType.KILOGRAM_TO_GRAM => 1 * 1000.0,
                    UnitType.TONNE_TO_KILOGRAM => 1 * 1000.0,
                    UnitType.GRAM_TO_KILOGRAM => 1 / 1000.0,
                    _ => 0.0,
                };
            }
        }
}
