using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set3
{
    internal class One
    {
        class student
        {
            string name;
            int rollno;
            student(string name, int rollno)
            {
                this.name = name;
                this.rollno = rollno;
            }

            void displaydetails()
            {
                Console.WriteLine("Name : " + name);
                Console.WriteLine("Roll No : " + rollno);
            }

            static void Main(string[] args)
            {
                student stud = new student("Basil", 1);
                stud.displaydetails();

                student stud2 = new student("Rockey",2);
                stud2.displaydetails();

                Console.ReadLine();
            }
        }
    }
}
