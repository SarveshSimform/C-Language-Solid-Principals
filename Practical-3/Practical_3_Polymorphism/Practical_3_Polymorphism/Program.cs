using System;

namespace Practical_3_Polymorphism
{
    class Bird{
        /// <summary>
        /// base class 
        /// this 
        /// </summary>
        public virtual void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }

    class Duck:Bird
    {
        /// <summary>
        /// Derived class 
        /// base class method override voice method
        /// overriding 
        /// </summary>
        public override void Voice()
        {
            Console.WriteLine("Quack Quack");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //base class called
            Bird myBird = new Bird();

            //Derived class called
            Duck myDuck = new Duck();

            //right to lest assign object this is called Upcast
            Bird bird = new Duck();

            //right to lest assign object this is called downcast
            Duck duck = (Duck)myDuck;

            myBird.Voice();
            //output Turr Turr

            myDuck.Voice();
            // output Quack Quack
            
            bird.Voice();
            //Quack Quack
            
            duck.Voice();
            //output Quack Quack
        }
    }
}
