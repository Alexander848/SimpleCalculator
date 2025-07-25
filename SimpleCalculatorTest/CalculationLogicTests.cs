using System;
using NUnit.Framework;

namespace SimpleCalculatorApplication.Tests
{

    [TestFixture]
    public class CalculationLogicTests
    {
        [Test]
        public void TokenizeCalculation_EmptyInput()
        {
            String actual = CalculationLogic.CalculateMathematicalInput("");
            String expected = "";

            Assert.That(expected.Equals(actual));
        }
    }
}
