using PraticaPOO_Balta.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaPOO_Balta.SubscriptionContext
{
    public class User : BaseContent
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
