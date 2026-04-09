namespace LegacyRenewalApp
{
    public interface BillingService
    {
        void SaveInvoice(RenewalInvoice invoice);
        void SendEmail(string email, string subject, string body);
    }
}