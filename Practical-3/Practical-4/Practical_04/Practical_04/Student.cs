using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_04
{
    enum Options
    {
        Aggregate = 1,
        MinMark = 2,
        MaximumMark = 3,
        Grade = 4
    }

    class Student
    {
        public string Name;
        public decimal [] Marks=new decimal[5];
        public static decimal AverageMarks;

        //calculate average
        public decimal CalculateAverageMarks()
        {
            for(int i=0; i< Marks.Length; i++)
            {
                AverageMarks += Marks[i];
            }
            return AverageMarks/Marks.Length;
        }
        string res = "";
        public string CalculateGrade(decimal avg)
        {
            bool falg = true;
            
            while (falg)
            {

                Console.WriteLine("**********************************************************");
                Console.WriteLine("a 1 - Aggregate: Displays the Name: Average marks ");
                Console.WriteLine("b 2 - MinMark: Displays the minimum marks of the student");
                Console.WriteLine("c 3 - MaximumMark: Displays the maximum mark");
                Console.WriteLine("d 4 - Grade: Displays grade");
                Console.WriteLine("Select any one number");
                Console.WriteLine("**********************************************************");
                int num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case (int)Options.Aggregate:
                        Console.Clear();
                        Console.WriteLine("The name of student is " + Name + " and his Average is " + avg+"\n");  
                        break;

                    case (int)Options.MinMark:
                        Console.Clear();
                        Console.WriteLine("The Minimum marks of the student is " + Marks.Min()+ "\n"); 
                        break;
                    case (int)Options.MaximumMark:
                        Console.Clear();
                        Console.WriteLine("The Maximum marks of the student is " + Marks.Max()+ "\n");
                        break;
                    case (int)Options.Grade:
                        if (avg > 90)
                        {
                            Console.Clear();
                            Console.WriteLine("Garde A" + "\n");
                        }
                        else if (avg < 80)
                        {
                            Console.Clear();
                            Console.WriteLine("Garde B" + "\n");
                        }
                        else if (avg > 70)
                        {
                            Console.Clear();
                            Console.WriteLine("Garde C" + "\n");
                        }
                        else if (avg < 70)
                        {
                            Console.Clear();
                            Console.WriteLine("Garde D" + "\n");

                        }
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("wrong option chosen"+ "\n");
                        falg = false;
                        break;
                }                                
            }
            return res;
        }
    }
}
