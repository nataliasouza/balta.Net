using PraticaPOO_Balta.NotificationContext;
using System;

namespace PraticaPOO_Balta.SharedContext
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
