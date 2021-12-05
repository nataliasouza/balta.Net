using PraticaPOO_Balta.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaPOO_Balta.ContentContext
{   
    public abstract class BaseContent : Notifiable
    {
        public Guid Id { get; set; }

        public BaseContent()
        {
            Id = Guid.NewGuid();
        }
        
    }
}
