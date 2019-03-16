using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Product : IProduct
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        public double GetDiscountPrice(Customer customer)
        {
            if (customer.Spent < 300)
            {
                return Price;
            }
            if (customer.Spent < 1000)
            {
                return Price * 0.9;
            }
            return Price * 0.8;
        }
        
}

    interface IProduct
    {
        double Price { get; set; }
        string Name { get; set; }
        string Manufacturer { get; set; }
        double GetDiscountPrice(Customer customer);

    }
   

}
