using System;
using System.Collections.Generic;
using System.Linq;

namespace AppForTraining
{
    interface ITarget
    {
        void SayTarget();
    }
    public class Target : ITarget
    {
        public void SayTarget()
        {
            Console.WriteLine("I am form the Target!");
        }
    }

    public class Adaptee
    {
        public void SayNewTarget ()
        {
            Console.WriteLine("I am from the Adaptee!");
        }
    }

    public class Adapter : Adaptee, ITarget // case № 1
    {
        public void SayTarget()
        {
            SayNewTarget();
        }
    }

    //public class Adapter : ITarget // case № 2
    //{
    //    New n = new New();
    //    public void SayTarget()
    //    {
    //        n.SayNewTarget();
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            var first = new Target();
            first.SayTarget();
            var second = new Adapter();
            second.SayTarget();
            Console.Read();
        }
    }
   
}
