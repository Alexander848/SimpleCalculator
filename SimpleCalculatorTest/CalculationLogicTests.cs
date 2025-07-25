
using SimpleCalculator.Logic;

namespace SimpleCalculator.Test
{

    [TestFixture]
    public class CalculationLogicTests
    {
        [Test]
        public void TokenizeCalculation_EmptyInput()
        {
            String actual = CalculationLogic.CalculateMathematicalInput("");
            String expected = "";

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
