using System;
using System.Linq;

namespace Practical_04
{

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            //enter student name
            Console.WriteLine("Enter Student Name");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            
            //loop will iterate until array length
            for (int i=0; i<student.Marks.Length; i++)
            {
                //user enter marks
                Console.WriteLine("Enter Subject No: " + (i+1));
                student.Marks[i]= Convert.ToDecimal(Console.ReadLine());
            }
            
            //this is average calculate function
            var avg= student.CalculateAverageMarks();
            Console.WriteLine("The Average is "+avg);
            
            //menu print 
            Console.WriteLine(student.CalculateGrade(avg));

        }
    }
}
