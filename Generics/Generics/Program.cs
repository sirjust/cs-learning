using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ImplementsIComparable.AreEqual(1.ToString(), "1"));

            int[] intArray = {3,4,2,1,5,6,7,8,9,2,2,2,1,23,3 };
            string[] stringArray = {"dasfdasf", "jkl;jkl;", "asdasd"};
            Person person1 = new Person() { Age = 15 };
            Person person2 = new Person() { Age = 10 };

            string[] sortedStringArray = ImplementsIComparable.Sort(stringArray);
            int[] sortedIntArray = ImplementsIComparable.Sort(intArray);
            
            Console.WriteLine(string.Join(", ",sortedStringArray));
            Console.WriteLine(string.Join(", ", sortedIntArray));
            Console.WriteLine("Person1 equal to Person2? " + ImplementsIComparable.AreEqual(person1, person2));

            MyList<int> myIntList = new MyList<int>();

            myIntList.Add(2);
            myIntList.Add(23);
            myIntList.Add(1);

            Console.WriteLine(myIntList.Capacity);
            Console.WriteLine(myIntList.Count);
            Console.WriteLine(myIntList[1]);

            MyList<int> firstIntList = new MyList<int>();
            MyList<int> secondIntList = new MyList<int>();

            firstIntList.Add(1);
            firstIntList.Add(10);
            firstIntList.Add(100);
            secondIntList.Add(1);
            secondIntList.Add(5);
            secondIntList.Add(10);

            MyList<int> result = firstIntList + secondIntList;

            Console.WriteLine(result.ToString());
            Console.Read();
        }
        
    }
}
