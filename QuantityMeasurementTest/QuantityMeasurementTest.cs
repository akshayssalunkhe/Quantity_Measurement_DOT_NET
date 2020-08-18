// <copyright file="QuantityMeasurementTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using QuantityMeasurementProblem;

    /// <summary>
    /// Test Class.
    /// </summary>
    public class QuantityMeasurementTest
    {
        /// <summary>
        /// Creating Instance Of Main Class.
        /// </summary>
        private QuantityMeasurement quantityMeasurement;

        /// <summary>
        /// Set up for tests.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.quantityMeasurement = new QuantityMeasurement();
        }

        /// <summary>
        /// Test case to equate zero.
        /// </summary>
        [Test]
        public void GivenZeroFeetAndZeroFeet_IfEqual_ThenShouldReturnTrue()
        {
            double feetValueOne = this.quantityMeasurement.ReturnFeet(0.0);
            double feetValueTwo = this.quantityMeasurement.ReturnFeet(0.0);
            Assert.AreEqual(feetValueOne, feetValueTwo);
        }

        /// <summary>
        /// Test case to equate zero and One.
        /// </summary>
        [Test]
        public void GivenDifferentFeetValues_IfNotEqual_ThenShouldReturnTrue()
        {
            double feetValueOne = this.quantityMeasurement.ReturnFeet(0.0);
            double feetValueTwo = this.quantityMeasurement.ReturnFeet(1.0);
            Assert.AreNotEqual(feetValueOne, feetValueTwo);
        }

        /// <summary>
        /// Test case to equate null.
        /// </summary>
        [Test]
        public void GivenNullValueForFeet_IfEqual_ThenShouldReturnFalse()
        {
            bool equals = this.quantityMeasurement.Equals(null);
            Assert.IsFalse(equals);
        }
    }
}