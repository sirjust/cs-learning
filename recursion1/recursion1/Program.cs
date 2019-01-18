using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintNaturalNumber(10, "yes");
            //Console.Read();
            PrintNaturalNumber(10, 1);
            Console.ReadLine();
        }

        static int PrintNaturalNumber(int max, int counter)
        {
            Console.WriteLine(counter.ToString());
            if (counter != max)
            {
                counter += 1;
                return PrintNaturalNumber(max, counter);
            }
            else
            {
                return 0;
            }

        }

        //static void PrintNaturalNumber(int max, string iterate)
        //{
        //    int counter = 1;
        //    while (counter <= max)
        //    {
        //        Console.WriteLine(counter);
        //        counter++;
        //    }
        //}
    }
}
