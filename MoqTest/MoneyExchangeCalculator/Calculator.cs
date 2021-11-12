using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyExchangeCalculator
{
    public class Calculator : ICalculator
    {
        private readonly IUSDExchangeRate iUSDExchangeRate;
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int ConvertToUSD(int rupee)
        {
            throw new NotImplementedException();
        }
    }
}
