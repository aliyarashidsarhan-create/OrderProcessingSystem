using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem
{
    internal class OrderItem
    {
        public string ProductName { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public OrderItem(string productName, double price, int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public double GetTotal()
        {
            return Price * Quantity;
        }
    }
}
