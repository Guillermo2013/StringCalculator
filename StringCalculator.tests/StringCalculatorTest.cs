using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringCalculator.tests
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void IfStringIsEmptyTheSumIsZero()
        {
            var calculator = new Calculator();
            var result = calculator.Add("");
            Assert.AreEqual(0, result, "-Unexpected Result!-");
        }
        [TestMethod]
        public void IfStringIsOneThenTheSumIsOne()
        {
            var calculator = new Calculator();
            var result = calculator.Add("1");
            Assert.AreEqual(1, result, "-Unexpected Result!-");
        }
        [TestMethod]
        public void IfStringIsFiveThenTheSumIsFive()
        {
            var calculator = new Calculator();
            var result = calculator.Add("5");
            Assert.AreEqual(5, result, "-Unexpected Result!-");
        }
        [TestMethod]
        public void IfStringIsOneCommaTwoThenTheSumIsThree()
        {
            var calculator = new Calculator();
            var result = calculator.Add("1,2");
            Assert.AreEqual(3, result, "-Unexpected Result!-");
        }
        [TestMethod]
        public void IfStringIsTwoCommaThreeThenTheSumIsFive()
        {
            var calculator = new Calculator();
            var result = calculator.Add("2,3");
            Assert.AreEqual(5, result, "-Unexpected Result!-");
        }
        [TestMethod]
        public void IfStingIsThreeCommaTwoCommaEightTheSumIsThirteen()
        {
            var calculator = new Calculator();
            var result = calculator.Add("3,2,8");
            Assert.AreEqual(13, result, "-Unexpected Result!-");
        }
        [TestMethod]
        public void IfStingIsThreeCommaTwoNewlineEightTheSumIsThirteen()
        {
            var calculator = new Calculator();
            var result = calculator.Add("3,2\n8");
            Assert.AreEqual(13, result, "-Unexpected Result!-");
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidInputFormat))]
        public void IfStringContainsTwoDelimitersTogeatherThowAnError()
        {
            var calculator = new Calculator();
            var result = calculator.Add("3,2\n,8");
        }
        [TestMethod]
        public void IfStringIsThreeAtFourTheSumIsSeven()
        {
            var calculator = new Calculator();
            var result = calculator.Add("//@\n3@4");
            Assert.AreEqual(7, result, "-Unexpected Result!-");
        }


    }
}
