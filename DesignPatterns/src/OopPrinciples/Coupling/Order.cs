using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.src.OopPrinciples.Coupling
{
    public class Order
    {
        private readonly INotificationService notificationService;
        public Order(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }
        public void PlaceOrder()
        {
            // Send email notification
            notificationService.SendNotification("Order placed successfully");
        }
    }
}
