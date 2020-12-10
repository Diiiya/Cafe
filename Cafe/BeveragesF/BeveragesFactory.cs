using Cafe.BeveragesMenu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    class BeveragesFactory
    {
        public IBeverage CreateBeverage(string beverageType, BeverageSize beverageSize)
        {
            if (beverageType == "tea")
            {
                return new Tea();
            }
            else if (beverageType == "cappuccino")
            {
                return new Cappuccino(beverageSize);
            }
            else if (beverageType == "cafe latte")
            {
                return new CafeLatte(beverageSize);
            }
            else
            {
                return new NullObject();
            }
            
        }
    }
}
