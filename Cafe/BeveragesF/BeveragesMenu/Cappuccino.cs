using Cafe.BeveragesMenu;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    class Cappuccino : IBeverage
    {
        readonly string size;
        readonly int price;
        public Cappuccino(BeverageSize size)
        {
            if(size == BeverageSize.S)
            {
                this.size = "Small";
                this.price = 30;
            } else
            {
                this.size = "Large";
                this.price = 40;
            }
        }
        public string GetDescription()
        {
            return this.size + " cappuccino ordered!";
        }

        public double GetPrice()
        {
            return this.price;
        }
    }
}
