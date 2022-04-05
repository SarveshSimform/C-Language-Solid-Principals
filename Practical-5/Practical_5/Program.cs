using System;

namespace Practical_5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //initialize array
            int[] arr = { 10, 20, 30, 40 , 50 };
            try
            {
                //loop will until 0 to 4 index
                for (int i = 0; i <=5; i++)
                {
                    Console.WriteLine("Index of array is " + arr[i]);
                    //print 10 20 30 40 50
                }
            }
            //if i=5 than loop break an Exception occur
            catch (IndexOutOfRangeException e)
            {
                //index out of range
                Console.WriteLine(e.Message);
            }
            finally
            {
                //this block is run once whenever run this try catch block
                Console.WriteLine("This is finally block");
            }
        }
    }
}
