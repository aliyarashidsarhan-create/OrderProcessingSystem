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
    }
}
