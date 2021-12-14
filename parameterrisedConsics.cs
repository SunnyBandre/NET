using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac2CS50065058
{
    class parameterrisedConsics
    {
        public class Employee
        {
            public int id;
            public String name;
            public float salary;
            public Employee(int i, String n, float s)
            {
                id = i;
                name = n;
                salary = s;
            }
            public void display()
            {
                Console.WriteLine(id + " " + name + " " + salary);
            }
        }
        public static void Main(string[] args)
        {
            Employee e1 = new Employee(10,"Neha", 890000f);
            Employee e2 = new Employee(20, "Mayur", 490000f);
            e1.display();
            e2.display();

            Console.ReadLine();
        }
    }
}
