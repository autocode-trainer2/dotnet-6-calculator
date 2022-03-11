using NUnit.Framework;
using System.Text; //unused import

namespace FancyCalc.Tests
{
    [TestFixture]
    public class FancyCalculatorTests
    {
        [Test]
        public void AddTest()
        {
        // commented out code
            var calc = new FancyCalc();
            double expected = 4;
            var actual = calc.Add(2, 2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 3, ExpectedResult = 9)]
        public double MultiplyTest(int a, int b)
        {
            int c = 10; //useless variable and commented out code
            var calc = new FancyCalc();
            return calc.Multiply(a, b);
        }
    }
}