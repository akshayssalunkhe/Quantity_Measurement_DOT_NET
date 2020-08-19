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
            double feetValueOne = this.quantityMeasurement.GetConvertUnitValue(0.0, Length.LengthUnit.FEET_TO_INCH);
            double feetValueTwo = this.quantityMeasurement.GetConvertUnitValue(0.0, Length.LengthUnit.FEET_TO_INCH);
            Assert.AreEqual(feetValueOne, feetValueTwo);
        }

        /// <summary>
        /// Test case to equate zero and One.
        /// </summary>
        [Test]
        public void GivenDifferentFeetValues_IfNotEqual_ThenShouldReturnTrue()
        {
            double feetValueOne = this.quantityMeasurement.GetConvertUnitValue(0.0, Length.LengthUnit.FEET_TO_INCH);
            double feetValueTwo = this.quantityMeasurement.GetConvertUnitValue(1.0, Length.LengthUnit.FEET_TO_INCH);
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

        /// <summary>
        /// Test case to check reference.
        /// </summary>
        [Test]
        public void GivenReferenceForFeet_IfEqual_ShouldReturnTrue()
        {
            bool equals = this.quantityMeasurement.Equals(this.quantityMeasurement);
            Assert.IsTrue(equals);
        }

        /// <summary>
        /// Test case to check type.
        /// </summary>
        [Test]
        public void GivenTypeOfQuantity_IfEqual_ThenshouldReturnTrue()
        {
            QuantityMeasurement firstQuantity = new QuantityMeasurement();
            QuantityMeasurement secondQuantity = new QuantityMeasurement();
            Assert.AreEqual(firstQuantity, secondQuantity);
        }

        /// <summary>
        /// Test Case to check  0 Inch And 0 Inch Should Return Equal.
        /// </summary>
        [Test]
        public void Given0InchAnd0Inch_IfEqual_ThenShouldReturnTrue()
        {
            double inchValueOne = this.quantityMeasurement.GetConvertUnitValue(0.0, Length.LengthUnit.INCH_TO_FEET);
            double inchValueTwo = this.quantityMeasurement.GetConvertUnitValue(0.0, Length.LengthUnit.INCH_TO_FEET);
            Assert.AreEqual(inchValueOne, inchValueTwo);
        }

        /// <summary>
        /// Test Case to check Given 0 Inch And 1 Inch Should Return NotEqual.
        /// </summary>
        [Test]
        public void Given0InchAnd1Inch_IfNotEqual_ThenShouldReturnTrue()
        {
            double inchValueOne = this.quantityMeasurement.GetConvertUnitValue(0.0, Length.LengthUnit.INCH_TO_FEET);
            double inchValueTwo = this.quantityMeasurement.GetConvertUnitValue(1.0, Length.LengthUnit.INCH_TO_FEET);
            Assert.AreNotEqual(inchValueOne, inchValueTwo);
        }

        /// <summary>
        /// Test Case to check Given Null Values Should Return Equal.
        /// </summary>
        [Test]
        public void GivenNullValueForInch_WhenChecked_ThenShouldReturnFalse()
        {
            bool equals = this.quantityMeasurement.Equals(null);
            Assert.IsFalse(equals);
        }

        /// <summary>
        /// Test Case to check references.
        /// </summary>
        [Test]
        public void GivenReferenceForInch_WhenChecked_ThenShouldReturnTrue()
        {
            bool equals = this.quantityMeasurement.Equals(this.quantityMeasurement);
            Assert.IsTrue(equals);
        }

        /// <summary>
        /// Test Case to check Equal Type.
        /// </summary>
        [Test]
        public void GivenTypeForInch_IfEqual_ThenShouldReturnTrue()
        {
            QuantityMeasurement firstQuantity = new QuantityMeasurement();
            QuantityMeasurement secondQuantity = new QuantityMeasurement();
            Assert.AreEqual(firstQuantity, secondQuantity);
        }

        /// <summary>
        /// Test case to check feet to inch conversion
        /// </summary>
        [Test]
        public void GivenFeetValueConvertToInch_ThenShouldReturnEqual()
        {
            double actualInchValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Length.LengthUnit.FEET_TO_INCH);
            Assert.AreEqual(12.0, actualInchValue);
        }

        /// <summary>
        /// Test method to check three feet equals to one yard.
        /// </summary>
        [Test]
        public void GivenFeetValueConvertToYard_ThenShouldReturnEqual()
        {
            double actualYardValue = this.quantityMeasurement.GetConvertUnitValue(3.0, Length.LengthUnit.FEET_TO_YARD);
            Assert.AreEqual(1.0, actualYardValue);
        }
    }
}