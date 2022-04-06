using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.Interface_Segregation_Principle
{
    class OrderProcessing_I
    {
        public OrderValidates OrderValidate = new OrderValidates();
        public IOrderSave orderSaver;
        public OrderNotificationSenders OrderNotificationSender = new OrderNotificationSenders();

        public OrderProcessing_I(IOrderSave orderSaver)
        {
            this.orderSaver = orderSaver;
        }

        public void Process()
        {
            OrderValidate.Validate();
            orderSaver.Save();
            OrderNotificationSender.Sendnotification();
        }
    }
    class OrderValidates
    {
        public void Validate()
        {
            Console.WriteLine("Validation Occur...!");
        }
    }

    class OrderNotificationSenders
    {
        public void Sendnotification()
        {
            Console.WriteLine("Notification Send..!");
        }
    }
}
