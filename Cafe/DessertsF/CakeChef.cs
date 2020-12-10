using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    class CakeChef
    {
        IBuilder cakeChef;

        public IBuilder CakeCreator
        {
           set { cakeChef = value; }
        }

        public void CreateBasicFruitCake()
        {
            this.cakeChef.IsSmall(true);
            this.cakeChef.PickBase(CakeBaseEnum.Vanillia);
            this.cakeChef.PickCream(CakeCreamEnum.Strawberry);            
        }

        public void CreateFancyFruitCake()
        {
            this.cakeChef.IsSmall(false);
            this.cakeChef.PickBase(CakeBaseEnum.Vanillia);
            this.cakeChef.PickCream(CakeCreamEnum.Strawberry);           
            this.cakeChef.AddFruitsTopping();
            this.cakeChef.AddArtDecoration();
            this.cakeChef.AddPersonalization("Lala");
        }

        public void CreateBirthdayCake(string personalization, int candles)
        {
            this.cakeChef.IsSmall(false);
            this.cakeChef.PickBase(CakeBaseEnum.Chocolate);
            this.cakeChef.PickCream(CakeCreamEnum.Vanillia);            
            this.cakeChef.AddArtDecoration();
            this.cakeChef.AddPersonalization(personalization);
            this.cakeChef.IncludeCandles(candles);
        }
    }
}
