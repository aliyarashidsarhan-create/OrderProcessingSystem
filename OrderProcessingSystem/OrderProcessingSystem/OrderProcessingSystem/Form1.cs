using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderProcessingSystem
{
    public partial class Form1 : Form
    {
        Order order1 = new Order(1);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(1, "Yahia", "yahia@email.com");

            Product laptop = new ElectronicsProduct(1, "Laptop", 1000, 5);

            Order order = new Order(1001, customer);

            order.AddProduct(laptop, 1);

            Payment payment = new CashPayment();

            order.SetPayment(payment);

            order.ProcessOrder();

            MessageBox.Show("Order Processed Successfully");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            double price = Convert.ToDouble(txtPrice.Text);
            int quantity = Convert.ToInt32(txtQuantity.Text);

            OrderItem item = new OrderItem(name, price, quantity);

            order1.AddProduct(item);

            lstOrder.Items.Add(name + " - " + quantity + " x " + price);

            MessageBox.Show("Item Added");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double total = order1.CalculateTotalPrice();

            MessageBox.Show("Total Price = " + total);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }
    }
}
