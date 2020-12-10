using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    class NullObject : IBeverage
    {
        public string GetDescription()
        {
            return "Error! No beverage of this type!";
        }

        public double GetPrice()
        {
            return 0;
        }
    }
}
