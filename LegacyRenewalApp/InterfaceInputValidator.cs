namespace LegacyRenewalApp
{
    public interface InterfaceInputValidator
    {
        void Validate(int customerId, string planCode, int seatCount, string paymentMethod);
    }
}