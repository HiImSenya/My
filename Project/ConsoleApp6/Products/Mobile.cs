using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Mobile : Product
    {
        public int Charge { get; private set; }

        public Mobile(string name, int price, string manufacturer, int charge)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Charge = charge;
            Price = price;
        }
    }
}
