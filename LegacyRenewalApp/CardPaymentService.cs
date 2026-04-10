namespace LegacyRenewalApp
{
    public class CardPaymentStrategy : IPaymentFeeStrategy
    {
        public bool CanHandle(string paymentMethod)
        {
            return paymentMethod == "CARD";
        }

        public decimal Calculate(decimal baseAmount)
        {
            return baseAmount * 0.02m;
        }
    }
}