using Practical_7.Open_Closed_Principle;
using System;
using Practical_7.Interface_Segregation_Principle;
using Practical_7.Dependency_Inversion_Principle;
using static Practical_7.Liskov_Substitution_Principle.Demo;

namespace Practical_7
{
    class Program
    {
        static void Main(string[] args)
        {
             OrderProcessor_S orderProcessor = new OrderProcessor_S();
            //Called Single Responsibility Principle
            Console.WriteLine("Single Responsibility Principle");
            orderProcessor.Process();

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\n");
            //Open-Closed Principle
            IOrderSaver observer =new DbOrderSavers();
            OrderProcessor_O orderProcessor_O = new OrderProcessor_O(observer);
            Console.WriteLine("Open-Closed Principle");
            orderProcessor_O.Process();

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\n");
            //Liskov Substitution Principle
            ReadParameters readParameters = new ReadParametersFromXML();
            Console.WriteLine("Liskov Substitution Principle");
            Console.WriteLine(readParameters.GetDbConnString());
            readParameters = new ReadParametersFromJSON();
            Console.WriteLine(readParameters.GetDbConnString());

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\n");
            //Interface Segregation Principle (ISP)
            IOrderSave orderSave = new DbOrderSaveService();
            OrderProcessing_I orderProcessor_I = new OrderProcessing_I(orderSave);
            Console.WriteLine("Interface Segregation Principle (ISP)");
            orderProcessor_I.Process();

            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("\n");
            //Dependency Inversion Principle (DIP)
            IService service = new DbOrderService();
            OrderProcesser orderProcesser = new OrderProcesser(service);
            Console.WriteLine("Dependency Inversion Principle (DIP)");
            orderProcesser.Process();
        }
    }
}
