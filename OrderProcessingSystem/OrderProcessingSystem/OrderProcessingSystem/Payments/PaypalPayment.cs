using System.Windows.Forms;

namespace OrderProcessingSystem.Payments
{
    public class PaypalPayment : Payment
    {
        public override void Pay(double amount)
        {
            MessageBox.Show(
                $"Paypal Payment Completed\nAmount: ${amount}"
            );
        }
    }
}