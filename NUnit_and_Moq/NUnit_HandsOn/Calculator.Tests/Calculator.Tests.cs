using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private SimpleCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new SimpleCalculator();
        }

        [TearDown]
        public void TearDown()
        {
            calculator.AllClear();
        }

        [Test]
        [TestCase(10, 20, 30)]
        [TestCase(15, 5, 20)]
        [TestCase(-10, 10, 0)]
        public void AdditionTest(double a, double b, double expected)
        {
            double result = calculator.Addition(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(20, 5, 15)]
        [TestCase(15, 5, 10)]
        public void SubtractionTest(double a, double b, double expected)
        {
            double result = calculator.Subtraction(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(10, 2, 20)]
        [TestCase(5, 5, 25)]
        public void MultiplicationTest(double a, double b, double expected)
        {
            double result = calculator.Multiplication(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(20, 4, 5)]
        [TestCase(100, 10, 10)]
        public void DivisionTest(double a, double b, double expected)
        {
            double result = calculator.Division(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void DivisionByZeroTest()
        {
            Assert.Throws<System.ArgumentException>(() =>
            {
                calculator.Division(10, 0);
            });
        }

        [Ignore("Sample Ignore Test")]
        [Test]
        public void IgnoreTest()
        {
            Assert.Fail();
        }
    }
}