using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorLibraryTest
{
    [TestClass]
    public class MSUnitTest1
    {
        [TestMethod]
        public void Add_TestMethod1()
        {
            var calculator = new Calculator();
            var result=calculator.Add(1, 2);
            Assert.AreEqual(3, result);
        }
        [TestMethod]
        public void Sub_TestMethod1()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Sub(2, 1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void Mul_TestMethod1()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Mul(1, 2);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void Div_TestMethod1()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Div(2,1);
            Assert.AreEqual(2, result);
        }
    }
}
