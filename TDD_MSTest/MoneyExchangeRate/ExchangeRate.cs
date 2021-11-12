using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyExchangeRate
{
    class ExchangeRate : IUSDExchangeRate
    {
        public int TodayUSDExchangeRate()
        {
            return 70;
        }
    }
}
