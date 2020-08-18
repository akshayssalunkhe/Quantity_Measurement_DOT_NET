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
    }
}