using Cst20Tests;

namespace Cst20TestsTesting
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calc;

        [TestInitialize]
        public void Init()
        {
            _calc = new Calculator();
        }

        [TestMethod]
        public void TestAddition()
        {
            Assert.AreEqual(2, _calc.Addition(1, 1));
            Assert.AreEqual(0, _calc.Addition(-1, 1));
            Assert.AreEqual(100, _calc.Addition(80, 20));
            Assert.AreEqual(-5, _calc.Addition(-1, -4));
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Assert.AreEqual(9, _calc.Subtraction(10, 1));
            Assert.AreEqual(0, _calc.Subtraction(0, 0));
            Assert.AreEqual(-100, _calc.Subtraction(0, 100));
            Assert.AreEqual(-2, _calc.Subtraction(2, 4));
        }

        [TestMethod]
        public void TestDivision()
        {
            Assert.AreEqual(1, _calc.Division(1, 1));
            Assert.AreEqual(0, _calc.Division(0, 1)); ;
            Assert.AreEqual(-10, _calc.Division(100, -10));
            Assert.AreEqual(4, _calc.Division(-4, -1));
            Assert.ThrowsException<ArgumentException>(() => _calc.Division(5, 0));
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentException))]
        public void TestDivisionZero()
        {
            _calc.Division(5, 0);
        }
    }
}