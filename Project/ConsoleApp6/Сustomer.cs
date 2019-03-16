using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
      class Customer
    {
        public string Name { get;   set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Adress { get;  set; }
        public double Balance { get; private set; } = 10000;
        public double Spent { get; private set; }        //сколько человек всего купил товара(надо для скидки)
        public string Email { get; set; }


        public void ReduceBalance(double price)
        {
            Balance -= price;
            Spent += price;
        }

       
       
    }
}
