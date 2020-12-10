using Cafe.AddOns;
using Cafe.BeveragesMenu;
using System;

namespace Cafe
{
    class Program
    {
        static void Main(string[] args)
        {
            BeveragesFactory factory = new BeveragesFactory();

            // Create a small cappuccino with extra shot of coffee
            Console.WriteLine("--- Create a small cappuccino with extra shot of coffee ---");
            IBeverage beverage1 = factory.CreateBeverage("cappuccino", BeverageSize.S);
            Console.WriteLine("Initial: " + beverage1.GetDescription() + " Price: " + beverage1.GetPrice() + "DKK"); 
            Additions beverage1WithAdditions = new ExtraShot(beverage1);
            Console.WriteLine("Final: " + beverage1WithAdditions.GetDescription() + " Price: " + beverage1WithAdditions.GetPrice() + "DKK");
            Console.WriteLine("----");
            Console.WriteLine();

            // Create a tea with ginger and lemon
            Console.WriteLine("--- Create a tea with lemon and ginger ---");
            IBeverage beverage2 = factory.CreateBeverage("tea", BeverageSize.S);
            Console.WriteLine("Initial: " + beverage2.GetDescription() + " Price: " + beverage2.GetPrice() + "DKK");
            Additions beverage2WithAdditions = new Ginger(beverage2);
            beverage2WithAdditions = new Lemon(beverage2WithAdditions);
            Console.WriteLine("Final: " + beverage2WithAdditions.GetDescription() + " Price: " + beverage2WithAdditions.GetPrice() + "DKK");
            Console.WriteLine("----");
            Console.WriteLine();

            // Create invalid drink
            Console.WriteLine("--- Create invalid drink ---");
            IBeverage beverage3 = factory.CreateBeverage("capppuccino", BeverageSize.L);
            Console.WriteLine("Initial: " + beverage3.GetDescription() + " Price: " + beverage3.GetPrice() + "DKK");
            Console.WriteLine("----");
            Console.WriteLine();

            //////////
            ///

            var cakeChef = new CakeChef();

            // Create basic fruit cake
            var fruitCake = new CakeBuilder();
            cakeChef.CakeCreator = fruitCake;
            Console.WriteLine("--- Create basic fruit cake ---");
            cakeChef.CreateBasicFruitCake();
            Console.WriteLine(fruitCake.GetCake().GetParts());
            Console.WriteLine("----");
            Console.WriteLine();

            // Create birthday cake
            var birthdayCake = new CakeBuilder();
            cakeChef.CakeCreator = birthdayCake;
            Console.WriteLine("--- Create birthday cake ---");
            cakeChef.CreateBirthdayCake("Lala", 10);
            Console.WriteLine(birthdayCake.GetCake().GetParts());
            Console.WriteLine("----");
            Console.WriteLine();

        }
    }
}
