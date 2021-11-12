using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace CalculatorLibraryTest
{
    [TestFixture]
    class CalculatorTest_NUnit
    {
        [TestCase(3,1,2)]
        [TestCase(3,2,1)]
        public void Add_TestMethod1(int check,int a,int b)
        {
            var calculator = new Calculator();
            
            var result = calculator.Add(a, b);
            Assert.AreEqual(check, result);
        }
        [TestCase(-1, 1, 2)]
        [TestCase(1, 2, 1)]
        public void Sub_TestMethod1(int check, int a, int b)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Sub(a,b);
            Assert.AreEqual(check, result);
        }
        [TestCase(2, 1, 2)]
        [TestCase(2, 2, 1)]
        public void Mul_TestMethod1(int check, int a, int b)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Mul(a,b);
            Assert.AreEqual(check, result);
        }
        [TestCase(0, 1, 2)]
        [TestCase(2, 2, 1)]
        public void Div_TestMethod1(int check, int a, int b)
        {
            Calculator calculator = new Calculator();
            int result = calculator.Div(a,b);
            Assert.AreEqual(check, result);
        }
    }
}
