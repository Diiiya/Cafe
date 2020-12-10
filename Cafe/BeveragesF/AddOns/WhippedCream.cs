using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.AddOns
{
    public class WhippedCream : Additions
    {
        public WhippedCream(IBeverage bevarage) : base(bevarage)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + whipped cream";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 15;
        }
    }
}
