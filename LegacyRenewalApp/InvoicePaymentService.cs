namespace LegacyRenewalApp
{
    public class InvoicePaymentStrategy : IPaymentFeeStrategy
    {
        public bool CanHandle(string paymentMethod)
        {
            return paymentMethod == "INVOICE";
        }

        public decimal Calculate(decimal baseAmount)
        {
            return 0m;
        }
    }
}