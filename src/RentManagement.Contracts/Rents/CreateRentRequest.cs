namespace RentManagement.Contracts.Subscriptions
{
    public record CreateRentRequest(
        int SubscriptionType,
        Guid AdminId
    );
}
