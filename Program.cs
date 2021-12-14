using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50585006
{
    class Program
    {
        static void Main(string[] args)
        {
            double f;
            double c = 32;
            Console.WriteLine("Celcius is "+c);
            f=(c*9)/5+32;
            Console.WriteLine("Temp is " + f);
            Console.ReadLine();
        }
    }
}
