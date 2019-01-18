using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public static class ImplementsIComparable
    {
        public static T[] Sort<T>(T[] myArray) where T : IComparable<T>
        {
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    if (myArray[i].CompareTo(myArray[j]) > 0)
                    {
                        T temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }
            return myArray;
        }

        public static bool AreEqual<T>(T num1, T num2) where T : IComparable<T>
        {
            return num1.CompareTo(num2) == 0;
        }
    }
}
