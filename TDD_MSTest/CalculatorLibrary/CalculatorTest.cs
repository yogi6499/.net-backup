using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TDD
{
    [TestClass]
    class CalculatorTest
    {
        [TestMethod]
        public void AddCalculatoe_Example_Success()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(1, 2);
            Assert.Equals(3, result);
        }

    }
}
