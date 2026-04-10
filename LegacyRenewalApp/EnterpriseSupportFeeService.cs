namespace LegacyRenewalApp
{
    public class EnterprisePlanSupportFeeStrategy : SupportFeeService
    {
        public bool CanHandle(string planCode)
        {
            return planCode == "ENTERPRISE";
        }

        public decimal Calculate(string planCode)
        {
            return 700m;
        }
    }
}