using System;

namespace Calculator{

    class Calculation{
            double num1,num2;
            public Calculation(){
                Console.WriteLine("Constructors Called.....");
            }
          public void getnumber(){
              try{
                Console.WriteLine("Enter first number:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                num2 = Convert.ToInt32(Console.ReadLine());
              }catch{
                  Console.WriteLine("Invalid input");
              }
          }

          public void display(){
              if(num1 != 0 && num2 != 0)
              {
               Console.WriteLine($"The sum of the {num1} and {num2} is {num1+num2}");
               Console.WriteLine($"The subtraction of the {num1} and {num2} is {num1-num2}");
               Console.WriteLine($"The multiplication of the {num1} and {num2} is {num1*num2}");
               Console.WriteLine($"The division of the {num1} and {num2} is {num1/num2}");
              }else{
                   Console.WriteLine("---Denied--");
              }
          }
    }
}