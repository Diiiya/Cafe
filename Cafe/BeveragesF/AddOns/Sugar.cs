using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.AddOns
{
    public class Sugar : Additions
    {
        public Sugar(IBeverage bevarage) : base(bevarage)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + sugar";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 5;
        }
    }
}
