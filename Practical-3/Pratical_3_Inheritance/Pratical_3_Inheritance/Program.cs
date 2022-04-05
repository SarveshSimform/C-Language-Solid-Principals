using System;

namespace Pratical_3_Inheritance
{
    class Sponsor
    {
        protected string owner="Sarvesh Patel";
    }

    class Team:Sponsor
    {
        private string teamName = "BugDemons";
        /// <summary>
        /// return type is string
        /// </summary>
        /// <returns></returns>
        public string printInfo()
        {
            return "Owner Name is "+ owner +" Team Name is "+ teamName+".....";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //created object of class
            Team team = new Team();
            //return printinfo method
            Console.WriteLine("*********************************************");
            Console.WriteLine(team.printInfo());
            Console.WriteLine("*********************************************");
        }
    }
}
