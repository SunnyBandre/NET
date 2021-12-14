using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50585006
{
    class Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Value");
            int a = Convert.ToInt16(Console.ReadLine());
            switch (a)
            {
                case 5: Console.WriteLine("value is "+a);
                    break;

                case 10: Console.WriteLine("value is "+a);
                    break;

                case 15: Console.WriteLine("value is "+a);
                    break;

                default: Console.WriteLine("Unknown value");
                    break;
            }
            Console.ReadLine();
        }
    }
}
