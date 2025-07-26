
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
        [Test]
        public void TokenizeCalculation_SingleDigit()
        {
            String actual = CalculationLogic.CalculateMathematicalInput("4");
            String expected = "4";

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TokenizeCalculation_MultipleDigits()
        {
            String actual = CalculationLogic.CalculateMathematicalInput("2354798");
            String expected = "2354798";

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TokenizeCalculation_CalculationEverySignAndMultDivBeforeAddMinRule()
        {
            String actual = CalculationLogic.CalculateMathematicalInput("40-(6+2*3)/3");
            String expected = "36";

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TokenizeCalculation_MultBeforeAdd()
        {
            String actual = CalculationLogic.CalculateMathematicalInput("2+4*3");
            String expected = "14";

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TokenizeCalculation_SubBeforeDiv()
        {
            String actual = CalculationLogic.CalculateMathematicalInput("24-8/4");
            String expected = "22";

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TokenizeCalculation_SingleLetter()
        {
            String actual = CalculationLogic.CalculateMathematicalInput("d");
            String expected = "error";

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TokenizeCalculation_DigitAndLetterInCalculation()
        {
            String actual = CalculationLogic.CalculateMathematicalInput("3+a");
            String expected = "error";

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TokenizeCalculation_Questionmark()
        {
            String actual = CalculationLogic.CalculateMathematicalInput("?");
            String expected = "error";

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TokenizeCalculation_Linebreak()
        {
            String actual = CalculationLogic.CalculateMathematicalInput("\n");
            String expected = "error";

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TokenizeCalculation_OtherLinebreak()
        {
            String actual = CalculationLogic.CalculateMathematicalInput("\r");
            String expected = "error";

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TokenizeCalculation_MoreOpeningBracketsThanClosing()
        {
            String actual = CalculationLogic.CalculateMathematicalInput("(1+(2*3)");
            String expected = "error";

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TokenizeCalculation_MoreClosingBracketsThanOpening()
        {
            String actual = CalculationLogic.CalculateMathematicalInput("7*5+(1+1))");
            String expected = "error";

            Assert.That(actual, Is.EqualTo(expected));
        }
        [Test]
        public void TokenizeCalculation_TwoOperatorsSideBySide()
        {
            String actual = CalculationLogic.CalculateMathematicalInput("1+*2");
            String expected = "error";

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
