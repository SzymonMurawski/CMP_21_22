using System;
using System.Collections.Generic;
using System.Text;

namespace NumericalIntegration
{
    interface IFunction
    {
        double GetValueAtX(double x);
    }
}
