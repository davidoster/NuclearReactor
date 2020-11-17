using NuclearReactor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuclearReactor
{
    class Program
    {
        static void Main(string[] args)
        {

            CoffeeBase coffeeBase = new CoffeeBase("Workers",2.14m);
            //CoffeeBase coffeeBase1 = new CoffeeBase(new CoffeeBase("Workers", 2.14m)); DON'T TRY THIS AT HOME
            //List<CoffeeBase> categories = new List<CoffeeBase>();
            //categories.Add(coffeeBase1);

            Coffee coffee2 = new Coffee("Workers",  2.14m, 0.72m, "Working Crazy");
            Coffee coffee = new Coffee(coffeeBase.BaseName, coffeeBase.BasePrice, 0.72m, "Working Crazy");
            Console.WriteLine($"Coffee for {coffee.BaseName} {coffee.CoffeeName} " +
                              $"{coffee.BasePrice} {coffee.UnitPrice} = {coffee.CalculateTotalPrice()}");
            

        }
    }
}
