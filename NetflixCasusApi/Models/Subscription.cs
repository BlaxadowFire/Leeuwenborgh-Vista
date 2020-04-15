using System.Collections.Generic;

namespace NetflixCasusApi.Models
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
