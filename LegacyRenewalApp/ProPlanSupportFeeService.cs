namespace LegacyRenewalApp
{
    public class ProPlanSupportFeeStrategy : SupportFeeService
    {
        public bool CanHandle(string planCode)
        {
            return planCode == "PRO";
        }

        public decimal Calculate(string planCode)
        {
            return 400m;
        }
    }
}