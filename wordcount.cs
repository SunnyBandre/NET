using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS50585006
{
    class wordcount
    {
        static void Main(string[] args)
        {
            int a=0, myword=1;
            Console.WriteLine("enter String");
            string str =Console.ReadLine();
            while(a <= str.Length-1)
            {
                if (str[a] == ' ' || str[a] == '\n' || str[a] == '\t')
                    myword++;
                a++;
            }
            Console.WriteLine("No of Words {0}", myword);
            Console.ReadLine();
        }
    }
}
