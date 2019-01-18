using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbersToOne(10);
            Console.ReadLine();
        }

        static int PrintNumbersToOne(int number)
        {
            Console.WriteLine(number.ToString());
            if (number != 1)
            {
                number -= 1;
                return PrintNumbersToOne(number);
            }
            else
            {
                return 0;
            }
        }
    }
}
