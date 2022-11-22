using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3
{
    internal class Two
    {
        public class basee
        {
            public virtual void display()
            {
                Console.WriteLine("Inside Base Class");

            }
        }
        public class derive:basee
        {
            public override void display()
            {
                Console.WriteLine("Inside Derived class");
            }
            static void Main(string[] args)
            {
                derive d=new derive();
                d.display();
                basee b=new basee();
                b.display();
                Console.ReadLine();
            }
        }

    }
}
