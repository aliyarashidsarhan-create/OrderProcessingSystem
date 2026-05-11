using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingSystem
{
    internal class Order
    {
        public int OrderId { get; set; }

        public List<OrderItem> Items { get; set; }

        public string Status { get; set; }

        public Order(int orderId)
        {
            OrderId = orderId;

            Items = new List<OrderItem>();

            Status = OrderStatus.Pending;
        }

        // إضافة منتج للطلب
        public void AddProduct(OrderItem item)
        {
            Items.Add(item);
        }

        // حساب الإجمالي
        public double CalculateTotalPrice()
        {
            double total = 0;

            foreach (OrderItem item in Items)
            {
                total += item.GetTotal();
            }

            return total;
        }

        // تغيير الحالة
        public void ChangeStatus(string newStatus)
        {
            Status = newStatus;
        }

        // عرض الطلب
        public void DisplayOrder()
        {
            Console.WriteLine("Order ID: " + OrderId);
            Console.WriteLine("Status: " + Status);

            Console.WriteLine("Items:");

            foreach (OrderItem item in Items)
            {
                Console.WriteLine(item.ProductName + " - " + item.Quantity + " x " + item.Price);
            }

            Console.WriteLine("Total Price: " + CalculateTotalPrice());
        }
    }
}
