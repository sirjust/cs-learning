using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyList<T>
    {
        private T[] items;

        private int count;
        private int capacity;

        public T this[int index]
        {
            get
            {
                return this.items[index];
            }
            set
            {
                this.items[index] = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                this.capacity = value;
            }
        }
        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }

        public MyList()
        {
            this.items = new T[2];
            this.capacity = 2;
            this.count = 0;
        }

        public void Add(T item)
        {
            if(this.capacity == this.count)
            {
                T[] clone = (T[])items.Clone();
                this.capacity *= 2;
                this.items = new T[this.capacity];

                Array.Copy(clone, 0, items, 0, clone.Length);
            }
            this.items[this.count] = item;
            this.count++;
        }

        public static MyList<T> operator +(MyList<T> list1, MyList<T> list2)
        {
            MyList<T> result = new MyList<T>();
            if(list1.Count != list2.Count)
            {
                throw new InvalidOperationException("Lists are of different sizes.");
            }
            else
            {
                for(int i = 0; i < list1.Count; i++)
                {
                    result.Add((dynamic)list1[i] + (dynamic)list2[i]);
                }
            }
            return result;
        }

        // this simplifies writing the contents of the result list
        public override string ToString()
        {
            string tempString = string.Empty;

            for (int i = 0; i < this.Count; i++)
            {
                if(i < this.Count - 1)
                {
                    tempString += this.items[i] + ", ";
                }
                else
                {
                    tempString += this.items[i];
                }
            }
            return tempString;
            //return string.Join(", ", this.items);

        }
    }
}
