namespace Generics
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class GenericList<T> where T : IComparable<T>
    {
        private T[] data;
        public int lastPosition = 0;

        public GenericList(int initialCapacity)
        {
            this.data = new T[initialCapacity];
        }

        public void Add(T element)
        {
            if (lastPosition == data.Length )
            {
               this.AutoGrow();
            }
            this.data[lastPosition] = element;
            this.lastPosition++;

        }

        public T this[int index]
        {
            get
            {
                if (index > this.lastPosition - 1)
                {
                    throw new IndexOutOfRangeException();
                }
                    return this.data[index];
            }
            //set { this.data[index] = value; }
        }

        public void Clear()
        {
            this.data = new T[this.data.Length];
        }

        public void Remove(int index)
        {
            for (int i = index; i < this.lastPosition && i < this.data.Length - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }
            this.lastPosition--;
            this.data[lastPosition] = default(T);
        }

        public void Insert(int index, T element)
        {
            if (lastPosition == this.data.Length)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = lastPosition + 1; i > index; i--)
            {
                this.data[i] = this.data[i -1];
            }
            this.data[index] = element;
            lastPosition++;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < this.lastPosition; i++)
            {
                sb.AppendLine(string.Format("i=[{0}] {1}", i, this.data[i]));
           
            }
            return sb.ToString();
        }

        private void AutoGrow()
        {
            var newData = new T[this.data.Length * 2];
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = data[i];
            }
            this.data = newData;
        }
        
        public T Min()
        {
            if (this.lastPosition == 0)
            {
                throw new ArgumentException("There are no elements in the List");
            }
            T min = this.data[0];
            foreach (var item in this.data)
            {
                if (!item.Equals(default(T)))
                {
                    if (min.CompareTo(item) > 0)
                    {
                        min = item;
                    }
                }

               
            }
            return min;
        }

        public T Max()
        {
            if (this.lastPosition == 0)
            {
                throw new ArgumentException("There are no elements in the List");
            }
            T max = this.data[0];
            foreach (var item in this.data)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }

    }
}
