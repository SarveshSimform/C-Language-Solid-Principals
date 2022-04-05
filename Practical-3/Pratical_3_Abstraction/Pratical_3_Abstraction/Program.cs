using System;

namespace Pratical_3_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialized object
            Laptop laptop = new Laptop();
            //assign private variables value by setter
            laptop.Brand = "Lenovo";
            laptop.Model = "legion 5";
            //print following output
            laptop.LaptopDetails();
        }
    }
}
