using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Tablet : Product
    {
        public int Diagonale { get; private set; }
        public Tablet(string name, int price, string manufacturer, int diagonale)
            {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            Diagonale = diagonale;
            Price = price;
        }

    }
}
