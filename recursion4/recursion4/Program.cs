using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberToTest = 1234;
            var digits = displayDigits(numberToTest);
            Console.Write("The digits in the number {0} are: ", numberToTest);
            foreach (char c in digits)
            {
                Console.Write(c.ToString() + " ");
            }
            Console.ReadLine();

            Console.Write("The digits in the number {0} are: ", numberToTest);
            recursiveMethod(numberToTest);
            Console.Read();
        }

        static char[] displayDigits(int myNumber)
        {
            var numberArray = myNumber.ToString().ToCharArray();
            return numberArray;
        }

        static void recursiveMethod(int myNumber)
        {
            if (myNumber < 10){
                Console.Write(myNumber);
            }
            else
            {
                recursiveMethod(myNumber / 10);
                Console.Write(" {0}", myNumber % 10);
            }
        }
    }
}
