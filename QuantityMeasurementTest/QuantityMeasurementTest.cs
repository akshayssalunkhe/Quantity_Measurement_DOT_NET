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
            double feetValueOne = this.quantityMeasurement.GetConvertUnitValue(0.0, Unit.UnitType.FEET_TO_INCH);
            double feetValueTwo = this.quantityMeasurement.GetConvertUnitValue(0.0, Unit.UnitType.FEET_TO_INCH);
            Assert.AreEqual(feetValueOne, feetValueTwo);
        }

        /// <summary>
        /// Test case to equate zero and One.
        /// </summary>
        [Test]
        public void GivenDifferentFeetValues_IfNotEqual_ThenShouldReturnTrue()
        {
            double feetValueOne = this.quantityMeasurement.GetConvertUnitValue(0.0, Unit.UnitType.FEET_TO_INCH);
            double feetValueTwo = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.FEET_TO_INCH);
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
            double inchValueOne = this.quantityMeasurement.GetConvertUnitValue(0.0, Unit.UnitType.INCH_TO_FEET);
            double inchValueTwo = this.quantityMeasurement.GetConvertUnitValue(0.0, Unit.UnitType.INCH_TO_FEET);
            Assert.AreEqual(inchValueOne, inchValueTwo);
        }

        /// <summary>
        /// Test Case to check Given 0 Inch And 1 Inch Should Return NotEqual.
        /// </summary>
        [Test]
        public void Given0InchAnd1Inch_IfNotEqual_ThenShouldReturnTrue()
        {
            double inchValueOne = this.quantityMeasurement.GetConvertUnitValue(0.0, Unit.UnitType.INCH_TO_FEET);
            double inchValueTwo = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.INCH_TO_FEET);
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
        /// Test case to check feet to inch conversion.
        /// </summary>
        [Test]
        public void GivenFeetValueConvertToInch_ThenShouldReturnEqual()
        {
            double actualInchValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.FEET_TO_INCH);
            Assert.AreEqual(12.0, actualInchValue);
        }

        /// <summary>
        /// Test method to check three feet equals to one yard.
        /// </summary>
        [Test]
        public void GivenFeetValueConvertToYard_ThenShouldReturnEqual()
        {
            double actualYardValue = this.quantityMeasurement.GetConvertUnitValue(3.0, Unit.UnitType.FEET_TO_YARD);
            Assert.AreEqual(1.0, actualYardValue);
        }

        /// <summary>
        /// Test method to check one inch is not equal to one yard.
        /// </summary>
        [Test]
        public void GivenInchValueConvertToYard_ThenShouldReturnNotEqual()
        {
            double actualYardValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.INCH_TO_YARD);
            Assert.AreNotEqual(1.0, actualYardValue);
        }

        /// <summary>
        /// Test method to check one yard is equal to thirty six inch.
        /// </summary>
        [Test]
        public void GivenYardValueConvertToInch_ThenShouldReturnEqual()
        {
            double actualYardValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.YARD_TO_INCH);
            Assert.AreEqual(36.0, actualYardValue);
        }

        /// <summary>
        /// Test method to check one yard is equal to three feet.
        /// </summary>
        [Test]
        public void GivenYardValueConvertToFeet_ThenShouldReturnEqual()
        {
            double actualYardValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.YARD_TO_FEET);
            Assert.AreEqual(3.0, actualYardValue);
        }

        /// <summary>
        /// Test method to check two inch is equal to five centimeter.
        /// </summary>
        [Test]
        public void GivenInchValueToConvertToCentimeter_ThenShouldReturnEqual()
        {
            double actualCentimeterValue = this.quantityMeasurement.GetConvertUnitValue(2.0, Unit.UnitType.INCH_TO_CENTIMETER);
            Assert.AreEqual(5.0, actualCentimeterValue);
        }

        /// <summary>
        /// Test method to check one inch is not equal to one centimeter.
        /// </summary>
        [Test]
        public void GivenInchValueToConvertToCentimeter_ThenShouldReturnNotEqual()
        {
            double actualCentimeterValue = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.INCH_TO_CENTIMETER);
            Assert.AreNotEqual(1.0, actualCentimeterValue);
        }

        /// <summary>
        /// Test method to check two inch plus two inch equal to four inch.
        /// </summary>
        [Test]
        public void GivenTwoInchLength_WhenAdd_ThenShouldReturnResult()
        {
            double firstInchValue = this.quantityMeasurement.GetConvertUnitValue(2.0, Unit.UnitType.INCH);
            double secondInchValue = this.quantityMeasurement.GetConvertUnitValue(2.0, Unit.UnitType.INCH);
            double addition = this.quantityMeasurement.GetAddition(firstInchValue, secondInchValue);
            Assert.AreEqual(4.0, addition);
        }

        /// <summary>
        /// Test method to check one gallon equals to three point seven eight litre.
        /// </summary>
        [Test]
        public void GivenOneGallonVolumeConvertToLitres_ThenShouldReturnEquals()
        {
            double actualVolume = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.GALLON_TO_LITRES);
            Assert.AreEqual(3.78, actualVolume);
        }

        /// <summary>
        /// Test method to check one litre equals to thousand millilitre.
        /// </summary>
        [Test]
        public void GivenOneLitreVolumeConvertToMilliLitre_ThenShouldReturnEqual()
        {
            double actualVolume = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.LITRE_TO_MILLILITRE);
            Assert.AreEqual(1000.0, actualVolume);
        }

        /// <summary>
        /// Test method to check addition of one gallon and three point seven eight litres equal to seven point five seven litres.
        /// </summary>
        [Test]
        public void GivenOneGallonAndOneLitreValue_WhenAdded_ThenShouldReturnResultInLitres()
        {
            double firstVolume = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.GALLON_TO_LITRES);
            double secondVolume = this.quantityMeasurement.GetConvertUnitValue(3.785, Unit.UnitType.LITRE);
            double addition = this.quantityMeasurement.GetAddition(firstVolume, secondVolume);
            Assert.AreEqual(7.57, addition, 0.1);
        }

        /// <summary>
        /// Test method to check addition of one litre and thousand millilitres equal to two litres.
        /// </summary>
        [Test]
        public void GivenOneLitreAndOneMillilitreValue_WhenAdded_ThenShouldReturnResultInLitres()
        {
            double firstVolume = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.LITRE);
            double secondVolume = this.quantityMeasurement.GetConvertUnitValue(1000.0, Unit.UnitType.MILLILITRE_TO_LITRE);
            double addition = this.quantityMeasurement.GetAddition(firstVolume, secondVolume);
            Assert.AreEqual(2.0, addition);
        }

        /// <summary>
        /// Test method to check one kilogram is equal to thousand gram.
        /// </summary>
        [Test]
        public void GivenOneKilogramToConvertInGrams_ThenShouldReturnEqual()
        {
            double actualWeight = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.KILOGRAM_TO_GRAM);
            Assert.AreEqual(1000.0, actualWeight);
        }

        /// <summary>
        /// Test method to check one tonne is equal to thousand kilogram.
        /// </summary>
        [Test]
        public void GivenOneTonneToConvertToKilogram_ThenShouldReturnEqual()
        {
            double actualWeight = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.TONNE_TO_KILOGRAM);
            Assert.AreEqual(1000.0, actualWeight);
        }

        /// <summary>
        /// Test method to check addition of one tonne and thousand gram is equal to one thousand and one kilogram.
        /// </summary>
        [Test]
        public void GivenTonneAndGram_WhenAdded_ThenShouldReturnResult_InKilogram()
        {
            double firstWeight = this.quantityMeasurement.GetConvertUnitValue(1.0, Unit.UnitType.TONNE_TO_KILOGRAM);
            double secondWeight = this.quantityMeasurement.GetConvertUnitValue(1000.0, Unit.UnitType.GRAM_TO_KILOGRAM);
            double addition = this.quantityMeasurement.GetAddition(firstWeight, secondWeight);
            Assert.AreEqual(1001.0, addition);
        }

        /// <summary>
        /// Test method to check celcius to fahrenheit conversion.
        /// </summary>
        [Test]
        public void GivenCelciusToConvertFahrenheit_ThenShouldReturnEqual()
        {
            double celciusValue = this.quantityMeasurement.GetConvertUnitValue(100.0, Unit.UnitType.CELSIUS);
            Assert.AreEqual(212.0, celciusValue);
        }

        /// <summary>
        /// Test method to check fahrenheit to celcius conversion.
        /// </summary>
        [Test]
        public void GivenFahrenheitToConvertCelsius_ThenShouldReturnEqual()
        {
            double fahrenheitValue = this.quantityMeasurement.GetConvertUnitValue(212.0, Unit.UnitType.FAHRENHEIT);
            Assert.AreEqual(100.0, fahrenheitValue);
        }
    }
}