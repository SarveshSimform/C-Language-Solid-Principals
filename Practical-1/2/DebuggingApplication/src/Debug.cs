using System;

namespace DebuggingApplication{
    class Debug{
        public void getstring(){
            String userResponse = Console.ReadLine();
            if(int.TryParse(userResponse,out int value))
            {
                Console.WriteLine("The entered value is a integer");
            }
        }
    }
}