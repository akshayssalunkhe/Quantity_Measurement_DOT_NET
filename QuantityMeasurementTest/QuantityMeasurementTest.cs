using NUnit.Framework;
using QuantityMeasurementProblem;

namespace QuantityMeasurementTest
{
    public class QuantityMeasurementTest
    {
        QuantityMeasurement quantityMeasurement; 


        [SetUp]
        public void Setup()
        {
            quantityMeasurement = new QuantityMeasurement();

        }

        [Test]
        public void GivenZeroFeetAndZeroFeet_IfEqual_ThenShouldReturnTrue()
        {
            double feetValueOne = quantityMeasurement.ReturnFeet(0.0);
            double feetValueTwo = quantityMeasurement.ReturnFeet(0.0);
            Assert.AreEqual(feetValueOne, feetValueTwo);
        }

        [Test]
        public void GivenDifferentFeetValues_IfNotEqual_ShouldReturnTrue()
        {
            double feetValueOne = quantityMeasurement.ReturnFeet(0.0);
            double feetValueTwo = quantityMeasurement.ReturnFeet(1.0);
            Assert.AreNotEqual(feetValueOne, feetValueTwo);
        }
    }
}