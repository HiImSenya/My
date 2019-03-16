using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Computer : Product
    {
     public int Power{get;private set;}

        public Computer(string name, int price, string manufacturer, int power)
        {
            Name = name;
            Price = price;
            Power = power;
            Price = price;
        }


    }
}
