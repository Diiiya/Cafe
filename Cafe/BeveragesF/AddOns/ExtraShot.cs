using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    public class ExtraShot : Additions
    {

        public ExtraShot(IBeverage bevarage) : base(bevarage)
        {

        }

        public override string GetDescription()
        {
            return base.GetDescription() + " + extra coffee shot";
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 5;
        }
    }
}
