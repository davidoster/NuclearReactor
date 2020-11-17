using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuclearReactor.Models
{
    class Coffee : CoffeeBase
    {
        private decimal _unitprice;

        public decimal UnitPrice
        {
            get { return _unitprice; }
            set { _unitprice = value; }
        }


        public Coffee(string BaseName, decimal BasePrice, decimal UnitPrice, string CoffeeName) : base(BaseName, BasePrice)
        {
            this.CoffeeName = CoffeeName;
            this.UnitPrice = UnitPrice;
        }

        public decimal CalculateTotalPrice()
        {
            return (this.BasePrice + this.UnitPrice);
        }
    }
}
