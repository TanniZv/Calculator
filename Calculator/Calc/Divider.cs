﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Calc
{
    class Divider:ICalc 
    {
       public double DoMath(double tmp1, double tmp2)
        {
            return tmp1 / tmp2;
        }
    }
}