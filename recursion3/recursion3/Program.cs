using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddNaturalNumbers(10));
            Console.Read();
        }

        static int AddNaturalNumbers(int myNumber, int sum = 0)
        {
            sum += myNumber;
            if (myNumber != 0)
            {
                myNumber -= 1;
                return AddNaturalNumbers(myNumber, sum);
            }
            else return sum;
        }
    }
}
