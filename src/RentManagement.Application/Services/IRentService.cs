namespace RentManagement.Application.Services
{
    public interface IRentService
    {
        Guid CreateSubscription(string subscriptionType, Guid adminId);
    }
}
