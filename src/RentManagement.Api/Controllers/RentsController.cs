using Microsoft.AspNetCore.Mvc;
using RentManagement.Application.Services;
using RentManagement.Contracts.Subscriptions;

namespace RentManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RentsController : ControllerBase
    {
        private readonly IRentService subscriptionsService;

        public RentsController(IRentService subscriptionsService)
        {
            this.subscriptionsService = subscriptionsService;
        }

        [HttpPost]
        public IActionResult CreateSubscription(CreateRentRequest request)
        {
            var subscriptionId = subscriptionsService.CreateSubscription(
                request.SubscriptionType.ToString(),
                request.AdminId);
            var response = new RentResponse(
                subscriptionId,
                request.SubscriptionType);

            return Ok(response);
        }
    }
}
