using NUnit.Framework;

namespace FancyCalc.Tests
{
    [TestFixture]
    public class FancyCalculatorTests
    {
        [Test]
        public void AddTest()
        {
            var calc = new FancyCalc();
            double expected = 4;
            var actual = calc.Add(2, 2);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SubtractTest()
        {
            var calc = new FancyCalc();
            double expected = 0;
            var actual = calc.Subtract(1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 3, ExpectedResult = 9)]
        public double MultiplyTest(int a, int b)
        {
            var calc = new FancyCalc();
            return calc.Multiply(a, b);
        }
    }
}