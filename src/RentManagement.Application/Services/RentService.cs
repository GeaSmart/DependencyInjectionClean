using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentManagement.Application.Services
{
    public class RentService : IRentService
    {
        public Guid CreateSubscription(string subscriptionType, Guid adminId)
        {
            return Guid.NewGuid();
        }
    }
}
