using System;

namespace Practical_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //object initialize and Constructor called automatically
            Customer_Account customer_Account = new Customer_Account("Sarvesh Patel;", 215064114320);
           
            //assign customer bank name
            customer_Account.bank_name = "State Bank of India";
            
            //called print method for display customer data
            customer_Account.printInfo();
        }
    }
}
