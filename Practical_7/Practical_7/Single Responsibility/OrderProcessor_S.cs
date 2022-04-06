using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7
{
    //Single Responsibility Principle
    class OrderProcessor_S
    {
        public OrderValidate OrderValidate=new OrderValidate();
        public OrderSaver OrderSaver=new OrderSaver();
        public OrderNotificationSender OrderNotificationSender=new OrderNotificationSender();
        public OrderProcessor_S()
        {
            Console.WriteLine("Order Processor Called..!!");
        }


        //called each Responsibility
        public void Process()
        {
            OrderValidate.Validate();
            OrderSaver.Save();
            OrderNotificationSender.Sendnotification();
        }
    }

    //validate
    //save
    //notify

    /// <summary>
    /// All class has a each Responsibility so we declare separate class 
    /// </summary>

    class OrderValidate
    {
        public void Validate()
        {
            Console.WriteLine("Validation Occur...!");
        }
    }

    class OrderSaver
    {
        public void Save()
        {
            Console.WriteLine("Order is Saved..!");
        }
    }

    class OrderNotificationSender
    {
        public void Sendnotification()
        {
            Console.WriteLine("Notification Send..!");
        }
    }
}
