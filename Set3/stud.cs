using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3
{
    internal class stud
    {
        
            public int id;
            public string name;
            public int mark;
            public void read()
            {
                Console.WriteLine("Enter the id");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the mark");
                mark = int.Parse(Console.ReadLine());
            }
            public void swap(stud val, stud val2)
            {
                stud temp = new stud();
                temp = val;
                val = val2;
                val2 = temp;
            }
            public void display()
            {
                Console.WriteLine("Id: {0}", id);
                Console.WriteLine("Name: {0}", name);
                Console.WriteLine("Mark: {0}", mark);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                stud s1 = new stud();
                stud s2 = new stud();
                s1.read();
                s2.read();
                Console.WriteLine("Before Swapping");
                s1.display();
                s2.display();
                s1.swap(s1, s2);
                Console.WriteLine("After Swapping");
                s1.display();
                s2.display();
                Console.ReadLine();
            }
        }
    
}
