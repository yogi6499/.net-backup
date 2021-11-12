using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyExchangeCalculator
{
    class Calculator : ICalculator
    {

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int ConvertToUSD(int rupee)
        {
            
            return Convert.ToInt32(rupee / );
        }
    }
}
