using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.AddOns
{
    public class Lemon : Additions
    {
        public Lemon(IBeverage bevarage) : base(bevarage)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + lemon";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 8;
        }
    }
}
