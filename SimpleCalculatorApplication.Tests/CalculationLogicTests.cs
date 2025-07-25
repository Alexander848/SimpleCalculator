using System;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace SimpleCalculatorApplication.Tests
{

    [TestFixture]
    public class CalculationLogicTests
    {
        [Test]
        public void TokenizeCalculation_EmptyInput()
        {
            String result = CalculationLogic.CalculateMathematicalInput("");
            String expected = "";

            ClassicAssert.AreEqual(expected, result);
        }
    }
}
