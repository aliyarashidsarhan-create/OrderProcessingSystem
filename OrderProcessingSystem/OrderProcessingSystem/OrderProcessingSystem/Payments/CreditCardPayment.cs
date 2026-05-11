using System.Windows.Forms;

namespace OrderProcessingSystem.Payments
{
    public class CreditCardPayment : Payment
    {
        public override void Pay(double amount)
        {
            MessageBox.Show(
                $"Credit Card Payment Completed\nAmount: ${amount}"
            );
        }
    }
}