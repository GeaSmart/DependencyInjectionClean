namespace RentManagement.Contracts.Subscriptions
{
    public record RentResponse(
        Guid Id,
        int SubscriptionType
    );
}
