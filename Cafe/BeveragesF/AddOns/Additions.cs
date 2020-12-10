using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    public abstract class Additions : IBeverage
    {
        private readonly IBeverage beverage;

        public Additions(IBeverage beverage)
        {
            this.beverage = beverage;
        }
        public virtual string GetDescription()
        {
            return beverage.GetDescription();
        }

        public virtual double GetPrice()
        {
            return beverage.GetPrice();
        }

    }
}
