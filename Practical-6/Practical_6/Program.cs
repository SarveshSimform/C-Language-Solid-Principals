﻿using System;

namespace Practical_6
{
    public delegate void Notify();
    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted; // Event

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here..
            OnProcessCompleted();
        }

        //protected virtual method
        protected virtual void OnProcessCompleted() 
        {
            //if ProcessCompleted is not null then call delegate
            ProcessCompleted?.Invoke();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();
        }
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Method Invoked");
        }
    }
}
