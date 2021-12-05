using PraticaPOO_Balta.SharedContext;
using System.Collections.Generic;
using System.Linq;

namespace PraticaPOO_Balta.SubscriptionContext
{
    public class Student : BaseContent
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);

        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
    }
}
