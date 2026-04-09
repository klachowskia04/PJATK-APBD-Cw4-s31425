namespace LegacyRenewalApp
{
    public interface SubscriptionPlanDataSource
    {
        SubscriptionPlan GetByCode(string code);
    }
}