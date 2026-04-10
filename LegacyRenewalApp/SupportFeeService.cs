namespace LegacyRenewalApp;

public interface SupportFeeService
{
    bool CanHandle(string planCode);
    decimal Calculate(string planCode);
}