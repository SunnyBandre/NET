using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50585006
{
    class palindrome
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.Write("enter no ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n>0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Palindrome No");
            else
                Console.WriteLine("Not a Palindrome No");
            Console.ReadLine();
        }
    }
}
