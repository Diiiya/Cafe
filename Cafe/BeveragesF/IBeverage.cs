using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    public interface IBeverage
    {
        string GetDescription();
        double GetPrice(); 
    }
}
