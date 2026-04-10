namespace LegacyRenewalApp
{
    public class PlanSupportFeeService : SupportFeeService
    {
        public bool CanHandle(string planCode)
        {
            return planCode == "START";
        }

        public decimal Calculate(string planCode)
        {
            return 250m;
        }
    }
}