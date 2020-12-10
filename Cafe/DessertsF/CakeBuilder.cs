using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    class CakeBuilder : IBuilder
    {
        Cake cake = new Cake();

        public CakeBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.cake = new Cake();
        }

        public Cake GetCake()
        {
            Cake cake = this.cake;
            this.Reset();

            return cake;
        }
        public void PickBase(CakeBaseEnum cakeBase)
        {
            this.cake.AddPart(cakeBase.ToString() + " base");
        }

        public void PickCream(CakeCreamEnum cakeCream)
        {
            this.cake.AddPart(cakeCream.ToDescriptionString() + " cream");
        }
        public void AddArtDecoration()
        {
            this.cake.AddPart("art decoration");
        }

        public void AddExtraCream()
        {
            this.cake.AddPart("extra cream");
        }

        public void AddFruitsTopping()
        {
            this.cake.AddPart("tropical fruits topping");
        }

        public void AddNutsTopping()
        {
            this.cake.AddPart("almonds topping");
        }

        public void AddPersonalization(string name)
        {
            this.cake.AddPart("add name " + name);
        }

        public void IncludeCandles(int number)
        {
            this.cake.AddPart("add " + number + " candles");
        }

        public void IsSmall(bool isSmall)
        {
            if (isSmall == true)
            {
                this.cake.AddPart("Small cake");
            }
            else
            {
                this.cake.AddPart("Large cake");
            }
        }

    }
}
