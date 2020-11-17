using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuclearReactor.Models
{
    class CoffeeBase : Naming
    {
        private decimal _baseprice;

        public decimal BasePrice
        {
            get { return _baseprice; }
            set { _baseprice = value; }
        }

        public CoffeeBase(string BaseName, decimal BasePrice)
        {
            this.BaseName = BaseName;
            //this.CoffeeName = CoffeeName;
            this.BasePrice = BasePrice;
        }

        //public CoffeeBase(CoffeeBase coffeeBase)
        //{
        //    this.BaseName = coffeeBase.BaseName;
        //    this.BasePrice = coffeeBase.BasePrice;
        //}


    }
}
