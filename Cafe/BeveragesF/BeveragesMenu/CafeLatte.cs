using Cafe.BeveragesMenu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    class CafeLatte : IBeverage
    {
        readonly string size;
        readonly int price;
        public CafeLatte(BeverageSize size)
        {
            if (size == BeverageSize.S)
            {
                this.size = "Small";
                this.price = 30;
            }
            else
            {
                this.size = "Large";
                this.price = 40;
            }
        }
        public string GetDescription()
        {
            return this.size + " cafe Latte ordered!";
        }

        public double GetPrice()
        {
            return this.price;
        }
    }
}
