using Practical_7.Open_Closed_Principle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7
{
    class OrderProcessor_O
    {
        public OrderValidates OrderValidate = new OrderValidates();
        public IOrderSaver orderSaver;
        public OrderNotificationSenders OrderNotificationSender = new OrderNotificationSenders();
        /// <summary>
        /// Interface initialized
        /// </summary>
        /// <param name="orderSaver"></param>
        public OrderProcessor_O(IOrderSaver orderSaver)
        {
            this.orderSaver = orderSaver;
            Console.WriteLine("Order Processor Called..!!");
        }
        public void Process()
        {
            //method called
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
    //interface inherited
    class DbOrderSavers : IOrderSaver
    {
        public void Save()
        {
            Console.WriteLine("Order is Saved in DataBase..!");
        }
    }
    //interface inherited
    class CacheOrderSavers : IOrderSaver
    {
        public void Save()
        {
            Console.WriteLine("Order is Saved in Cached..!");
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
