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
        /// Method to return feet.
        /// </summary>
        /// <param name="feet"></param>
        /// <returns>Feet value.</returns>
        public double ReturnFeet(double feet) => feet;

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
    }
}
