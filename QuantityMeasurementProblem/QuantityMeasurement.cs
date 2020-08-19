// <copyright file="QuantityMeasurement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementProblem
{
    /// <summary>
    /// Main Class.
    /// </summary>
    public class QuantityMeasurement
    {
        /// <summary>
        /// Method to return converrted unit value.
        /// </summary>
        /// <param name="unitValue"></param>
        /// <param name="unitType"></param>
        /// <returns>Feet value.</returns>
        public double GetConvertUnitValue(double unitValue, Unit.UnitType unitType)
        {
            return unitValue * new Unit().GetValue(unitType);
        }

        /// <summary>
        /// Overridding Equals Method.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns> boolean. </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            if (this.GetType().Equals(obj.GetType()))
            {
                return true;
            }

            return true;
        }

        /// <summary>
        /// Override Hashcode function.
        /// </summary>
        /// <returns> returns hash code for current object.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        /// <summary>
        /// Function to add two unit values.
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="secondValue"></param>
        /// <returns> Addition of two values. </returns>
        public double GetAddition(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
