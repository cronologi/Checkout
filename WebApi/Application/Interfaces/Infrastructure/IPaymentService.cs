using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces.Infrastructure
{
    public interface IPaymentNotificationService
    {
        void NotifyOrderOcurred(int productId, int quantity);
    }
}
