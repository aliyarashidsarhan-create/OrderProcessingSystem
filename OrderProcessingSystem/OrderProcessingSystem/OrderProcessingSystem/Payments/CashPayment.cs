using System.Windows.Forms;

namespace OrderProcessingSystem.Payments
{
    public class CashPayment : Payment
    {
        public override void Pay(double amount)
        {
            MessageBox.Show(
                $"Cash Payment Completed\nAmount: ${amount}"
            );
        }
    }
}