﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyExchangeCalculator
{
    interface ICalculator
    {
        int ConvertToUSD(int rupee); 
        int Add(int a, int b);
    }
}
