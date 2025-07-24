namespace SimpleCalculatorApplication.Tests
{

    [TestFixture]
    public class CalculationLogicTests
    {
        [Test]
        public void TokenizeCalculation_EmptyInput()
        {
            List<String> result = CalculationLogic.TokenizeCalculation("");
            List<String> expected = new List<String>();

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
