using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    public interface IBuilder
    {
        void PickBase(CakeBaseEnum cakeBase);
        void PickCream(CakeCreamEnum cakeCream);

        void IsSmall(bool isSmall);
        void AddExtraCream();

        void AddFruitsTopping();

        void AddNutsTopping();
        void AddArtDecoration();

        void AddPersonalization(string name);

        void IncludeCandles(int number);
    }
}
