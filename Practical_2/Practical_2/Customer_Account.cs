using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_2
{
    class Customer_Account
    {
        /// <summary>
        /// Object initialize than Constructor called.
        /// </summary>
        /// <param name="customer_name"></param>
        /// <param name="customer_accountNo"></param>
        public Customer_Account(string customer_name, long customer_accountNo)
        {
            this.customer_name = customer_name;
            this.customer_accountNo = customer_accountNo;
        }
        public string bank_name { get; set; }
        public string customer_name { get; set; }
        public long customer_accountNo { get; private set;}
        
        /// <summary>
        /// return type is void nothing to return only print initialize value
        /// </summary>
        public void printInfo()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("Bank Name: "+bank_name);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Customer Account No: "+customer_accountNo);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Customer Name: "+customer_name);
            Console.WriteLine("****************************************************");
        }
       
    }
}
