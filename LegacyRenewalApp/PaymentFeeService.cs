namespace LegacyRenewalApp
{
    public interface IPaymentFeeStrategy
    {
        bool CanHandle(string paymentMethod);
        decimal Calculate(decimal baseAmount);
    }
}