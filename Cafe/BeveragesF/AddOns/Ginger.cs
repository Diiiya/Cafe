using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe.AddOns
{
    public class Ginger : Additions
    {
        public Ginger(IBeverage bevarage) : base(bevarage)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + ginger";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 10;
        }
    }
}
