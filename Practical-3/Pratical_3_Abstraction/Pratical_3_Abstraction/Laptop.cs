using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratical_3_Abstraction
{
    class Laptop
    {
        /// <summary>
        /// declared private variable
        /// </summary>
        private string brand;
        private string model;
        //getter setter method
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        //getter setter method
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        /// <summary>
        /// print following brand and model
        /// </summary>
        public void LaptopDetails()
        {

            Console.WriteLine("Brand: " + brand);

            Console.WriteLine("Model: " + model);
        }

        private void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }
    }
}
