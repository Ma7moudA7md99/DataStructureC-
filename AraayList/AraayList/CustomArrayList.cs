using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AraayList
{
    internal class CustomArrayList<T>
    {
        private T[] arr;
        // Returns the actual list length
        private int count;
        public int Count
        {
            get
            {
                return this.count;
            }
        }
        private const int INITIAL_CAPACITY = 4;
        // Initialize the array-based list - allocate memory
        public CustomArrayList(int capacity = INITIAL_CAPACITY)
        {
            this.arr = new T[capacity];
            this.count = 0;
        }
        // Adds element to the list
        // item = The element you want to add
        public void Add(T item)
        {
            GrowIfItFull();
            this.arr[this.count] = item;
            this.count++;
        }
        // Inserts Method 
        // index = place you want to insert at
        public void Insert(int index, T item)
        {
            if (index < 0 || index > this.count)
            {
                throw new IndexOutOfRangeException(
                    "Invalid index: " + index);
            }
            GrowIfItFull();
            Array.Copy(this.arr, index,
                this.arr, index + 1, this.count - index);
            this.arr[index] = item;
            this.count++;
        }
        // Doubles the size of this.arr (grow) if it's full
        private void GrowIfItFull()
        {
            if (this.count + 1 > this.arr.Length)
            {
                T[] extendedArr = new T[this.arr.Length * 2];
                Array.Copy(this.arr, extendedArr, this.count);
                this.arr = extendedArr;
            }
        }
        // Clears the list (remove everything)
        public void Clear()
        {
            this.arr = new T[INITIAL_CAPACITY];
            this.count = 0;
        }

        // Returns the index of the first occurrence of the specified
        // element in this list (or -1 if it does not exist).
        public int IndexOf(T item)
        {
            for (int i = 0; i < this.arr.Length; i++)
            {
                if (object.Equals(this.arr[i], item))
                {
                    return i;
                }
            }
            return -1;
        }
        // Checks if an element exists
        public bool Contains(T item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);
            return found;
        }
        // Indexer: access to element at given index
        // returns the element at the specified position
        public T this[int index]
        {
            get
            {
                if (index >= this.count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }
                return this.arr[index];
            }
            set
            {
                if (index >= this.count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid index: " + index);
                }
                this.arr[index] = value;
            }
        }
        // Removes the element at the specified index
        // returns the removed element
        public T RemoveAt(int index)
        {
            if (index >= this.count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid index: " + index);
            }
            T item = this.arr[index];
            Array.Copy(this.arr, index + 1,
                this.arr,index ,this.count - index - 1);
            this.arr[this.count - 1] = default(T);
            this.count--;
            return item;
        }
        // Removes the  specified element
        // return -1 if element does not exist or the removed element
        public int Remove(T item)
        {
            int index = IndexOf(item);
            if (index != -1)
            {
                this.RemoveAt(index);
            }
            return index;
        }
    }
}
