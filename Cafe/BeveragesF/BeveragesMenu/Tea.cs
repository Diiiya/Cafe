using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.BeveragesMenu
{
    class Tea : IBeverage
    {
        public string GetDescription()
        {
            return "Tea ordered!";
        }

        public double GetPrice()
        {
            return 20;
        }
    }
}
