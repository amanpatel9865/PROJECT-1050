using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_1
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;

        public static double SumofAllAges;

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            Console.WriteLine("My name is " + this.GetFullName() + ".");
            Console.WriteLine("My age is " + this.Age + ".");
        }
    }

}

