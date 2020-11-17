using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuclearReactor.Models
{
    class Naming
    {
        private string _name;

        public string BaseName
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _coffeename;

        public string CoffeeName
        {
            get { return _coffeename; }
            set { _coffeename = value; }
        }

    }
}
